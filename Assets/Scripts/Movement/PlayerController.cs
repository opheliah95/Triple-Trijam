using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float gravity = -9.81f;
    public float jumpSpeed = 5f;
    public float rotateSpeed = 3.0f;

    [SerializeField]
    Vector2 move = Vector2.zero;
    [SerializeField]
    Vector2 rotate = Vector2.zero;

    private Vector2 m_Rotation;

    [SerializeField]
    CharacterController controller;

    [SerializeField]
    Transform groundPosition, foot;

    [SerializeField]
    float groundRadius;
    [SerializeField]
    bool _onClap;
    [SerializeField]
    bool _isGrounded;
    private Vector3 m_playerVelocity;
    private Camera m_Camera;
    [SerializeField]
    float yVelocity;
    public AudioClip playerClap;
    public SoundData jumpSounds;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        m_Camera = Camera.main;
        
    }

    // hard code player movement
    
    private void Update()
    {
        // check if player is on the ground
        _isGrounded = GroundCheck();

        // if player is on the ground and still affected by gravity
        // stop gravity, so jump is not affected when called
        if (_isGrounded && yVelocity < 0)
            yVelocity = 0;

        // move player around
        _PlayerMove();

        // update jump
        _PlayerJump();

        // change gravity
        yVelocity += gravity * Time.deltaTime;

    }

    private void _PlayerMove()
    {
        if (move.sqrMagnitude < 0.01)
            return;
        var scaledMoveSpeed = moveSpeed * Time.deltaTime;

        // For simplicity's sake, we just keep movement in a single plane here. Rotate
        // direction according to world Y rotation of player.
        var moveDir = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(move.x, 0, move.y);

        // move player
        controller.Move(moveDir * scaledMoveSpeed);

    }

    private void _PlayerJump()
    {
        controller.Move(new Vector3(0, yVelocity, 0) * Time.deltaTime);
    }

    // I know unity event is preferred but I will stick with send messages for this jam
    // movement function
    void OnWalk(InputValue val)
    {
        move = val.Get<Vector2>();
    }

    // jump function ---it is buggy right now
    void OnJump(InputValue val)
    {
        if (_isGrounded)
        {
            yVelocity += Mathf.Sqrt(gravity * jumpSpeed * -2f);
        }
       
    }

    // on player look
    void OnLook(InputValue val)
    {
        rotate = val.Get<Vector2>();
        if (rotate.sqrMagnitude < 0.01)
            return;
        var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
        m_Rotation.y += rotate.x * scaledRotateSpeed;
        m_Rotation.x = Mathf.Clamp(m_Rotation.x - rotate.y * scaledRotateSpeed, -89, 89);
        //m_Camera.transform.localEulerAngles = m_Rotation;
        // update player's rotation
        transform.localEulerAngles = new Vector3(m_Rotation.x, m_Rotation.y, 0);
    }

    // clapping function
    void OnClap()
    {
        _onClap = !_onClap;
        if (_onClap)
            FindObjectOfType<AudioManager>().PlaySound(playerClap);
        else
            FindObjectOfType<AudioManager>().StopSound();
    }

    /// <summary>
    ///  check if character is grounded
    /// tried to use default CharacterController.isGrounded but it always return false :(
    /// </summary>
    /// <returns> it returns a bool value</returns>

    bool GroundCheck()
    {
        return Physics.CheckSphere(foot.position, groundRadius, LayerMask.GetMask("Ground"), QueryTriggerInteraction.Ignore);
    }

    // visualize a list of elements like foot collider etc
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(foot.position, groundRadius);
    }
}

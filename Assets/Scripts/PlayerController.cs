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
    bool canJump;

    private Vector3 m_playerVelocity;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // hard code player movement
    
    private void FixedUpdate()
    {
        _PlayerMove();

    }

    private void _PlayerMove()
    {
        float groundPos = Mathf.Abs(foot.position.y - groundPosition.position.y);
        Debug.Log(controller.isGrounded);
        Vector3 velocity = controller.velocity;

        if (move.magnitude > 1)
            move.Normalize();

        velocity.x = move.x * moveSpeed;
        velocity.z = move.y * moveSpeed;

        // if the character is in the air, it will fall
        if (!controller.isGrounded)
            velocity.y += gravity * Time.deltaTime;

        // jump
        if (canJump && groundPos < 0.1f)
        {
            canJump = false;
            velocity.y = jumpSpeed;
        }

        // move
        controller.Move(velocity * Time.deltaTime);

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
        canJump = true;

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
        transform.localEulerAngles = m_Rotation;
    }
}

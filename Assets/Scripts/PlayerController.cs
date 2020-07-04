using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//TODO: function to get player moving in direction move vector points to
// TODO: function to make player jump
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float gravity = -20f;
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
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // hard code player movement
    void FixedUpdate()
    {
        _PlayerMove();
    }

    private void _PlayerMove()
    {
        Vector3 velocity = controller.velocity;

        // normalize the vector
        if (move.magnitude > 1)
            move.Normalize();

        // update movement in x and z direction
        velocity.x = move.x * moveSpeed;
        velocity.z = move.y * moveSpeed;

        // enable gravity
        if (!controller.isGrounded && !canJump)
            velocity.y += gravity * Time.deltaTime;

        // check if can jump
        if (controller.isGrounded && canJump)
        {
            velocity.y = jumpSpeed;
            canJump = false;
        }
            

        // apply velocity to the character
        controller.Move(velocity * Time.deltaTime);
    }

    // I know unity event is preferred but I will stick with send messages for this jam
    // movement function
    void OnWalk(InputValue val)
    {
        move = val.Get<Vector2>();
    }

    // jump function
    void OnJump(InputValue val)
    {
        canJump = val.isPressed && !canJump;
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

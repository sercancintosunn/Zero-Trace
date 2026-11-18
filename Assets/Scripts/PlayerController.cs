using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    [SerializeField] private float moveSpeed = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveDirection = ReadMoveDirection();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = moveSpeed * moveDirection;
    }

    private Vector2 ReadMoveDirection()
    {
        Keyboard keybord = Keyboard.current;

        if (keybord == null) return Vector2.zero;

        Vector2 direction = Vector2.zero;

        if (keybord.aKey.isPressed || keybord.leftArrowKey.isPressed) direction.x -= 1f;
        if (keybord.dKey.isPressed || keybord.rightArrowKey.isPressed) direction.x += 1f;
        if (keybord.wKey.isPressed || keybord.upArrowKey.isPressed) direction.y += 1f;
        if (keybord.sKey.isPressed || keybord.downArrowKey.isPressed) direction.y -= 1f;

        return direction.normalized;
        
      

    }


}

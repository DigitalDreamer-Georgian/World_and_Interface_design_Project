using UnityEngine;
using UnityEngine.UI;
//By: tyler ung 3/2/2025
//Description:
//this script is used for dashing as well as main movment
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
 

    private float activeMoveSpeed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Vector2 moveInput;

    public bool isDashing { get; private set; }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        activeMoveSpeed = moveSpeed;
       
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        moveVelocity = moveInput * activeMoveSpeed;

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


}

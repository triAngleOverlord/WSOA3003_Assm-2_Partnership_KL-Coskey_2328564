using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    [SerializeField] private GameObject triggerOBJ;
    private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        triggerOBJ.transform.position = transform.position;
        if (gameObject.tag == "Red")
        {
            if (Input.GetKey(KeyCode.A))
                player.velocity = new Vector2 (-1 * speed, player.velocity.y);
            if (Input.GetKey(KeyCode.D))
                player.velocity = new Vector2(1 * speed, player.velocity.y);
            if (Input.GetKeyDown(KeyCode.W) && isTouchingGround == true)
            {
                player.velocity = new Vector2(player.velocity.x, jumpHeight);
                
            }
                

        }
        else if (gameObject.tag == "Blue")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                player.velocity = new Vector2(-1 * speed, player.velocity.y);
            if (Input.GetKey(KeyCode.RightArrow))
                player.velocity = new Vector2(1 * speed, player.velocity.y);
            if (Input.GetKeyDown(KeyCode.UpArrow) && isTouchingGround == true)
            {
                player.velocity = new Vector2(player.velocity.x, jumpHeight);
                
            }
        }


    }
    

    

}

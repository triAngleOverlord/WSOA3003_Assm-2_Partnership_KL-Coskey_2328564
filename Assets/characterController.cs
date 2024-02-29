using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Red")
        {
            if (Input.GetKeyDown(KeyCode.W))
                transform.Translate(Vector2.up * Time.deltaTime * jumpHeight);
            if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector2.left * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector2.right * Time.deltaTime * speed);


        }
        else if (gameObject.tag == "Blue")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
                transform.Translate(Vector2.up * Time.deltaTime * jumpHeight);
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(Vector2.left * Time.deltaTime * speed);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Translate(Vector2.right * Time.deltaTime * speed);

        }


    }
}

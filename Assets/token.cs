using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class token : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && (collision.gameObject.tag=="Red" || collision.gameObject.tag == "Blue"))
        {
            //Debug.Log(transform.parent.gameObject);
            GameManager.Instance.loading();
        }
    }

   
}

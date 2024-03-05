using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class metaBallActivate : MonoBehaviour
{

    [SerializeField] private GameObject metaQuad;

    public void Start()
    {
        metaQuad.SetActive(false);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision != null && (collision.gameObject.tag == "TrigBlue" || collision.gameObject.tag == "TrigRed"))
        {
            metaQuad.SetActive(true);
            var purples = GameObject.FindGameObjectsWithTag("PlatformPurple");
            foreach (var purple in purples)
            {
                purple.transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("Nothing");
            }
            var reds = GameObject.FindGameObjectsWithTag("PlatformRed");
            foreach (var red in reds)
            {
                red.transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("BluePLAT", "RedPLAT");
            }
            var blues = GameObject.FindGameObjectsWithTag("PlatformBlue");
            foreach (var blue in blues)
            {
                blue.transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("BluePLAT", "RedPLAT");
            }



            //GameObject.FindGameObjectWithTag("Red").transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("RedPLAT", "BluePLAT");
            //GameObject.FindGameObjectWithTag("Blue").transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("RedPLAT","BluePLAT" );
            //Debug.Log("On");
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null && (collision.gameObject.tag == "TrigBlue" || collision.gameObject.tag == "TrigRed"))
        {
            metaQuad.SetActive(false);
            //Debug.Log("Off");
            var purples = GameObject.FindGameObjectsWithTag("PlatformPurple");
            foreach (var purple in purples)
            {
                purple.transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("BluePLAT", "RedPLAT");
            }
            var reds = GameObject.FindGameObjectsWithTag("PlatformRed");
            foreach (var red in reds)
            {
                red.transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("BluePLAT");
            }
            var blues = GameObject.FindGameObjectsWithTag("PlatformBlue");
            foreach (var blue in blues)
            {
                blue.transform.GetComponent<Rigidbody2D>().excludeLayers = LayerMask.GetMask("RedPLAT");
            }
        }

    }
}

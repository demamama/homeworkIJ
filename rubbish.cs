using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubbish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bucket")
        {
            Destroy(gameObject);
        }
    }
}

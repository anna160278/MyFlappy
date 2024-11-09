using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBackgrond : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {     
            Destroy(transform.parent.gameObject);
        }
    }
}
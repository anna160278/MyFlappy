using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private CreateBackground createBackground;
    
    private void Awake() {
        createBackground = FindObjectOfType<CreateBackground>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (createBackground != null && collision.gameObject.tag == "Player") {
            createBackground.CreateBg(transform.parent);
            Destroy(gameObject);
        }
    }
}

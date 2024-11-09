using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public float speed = 0.01f;
    private PlayerMovement playerMovement;

    private void Start() {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    void Update() {
        if (playerMovement.gameActive)
            transform.Translate(Vector2.left * speed);
    }
}

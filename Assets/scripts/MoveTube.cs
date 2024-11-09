using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTube : MonoBehaviour
{
    public float speed = 0.01f;
    private PlayerMovement playerMovement;
    private GameManager gameManager;


    private void Start() {
        playerMovement = FindObjectOfType<PlayerMovement>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update() {
        if (playerMovement.gameActive)
            transform.Translate(Vector2.left * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.tag);
        if (collision.tag == "Killer") {
            Debug.Log("столкнулись с уничтожителем труб");
            Destroy(gameObject);
        }

        if (collision.tag == "PointsCounter") {
            Debug.Log("столкнулись о счётчиком очков");
            gameManager.PointPlus();
        }
    }
}

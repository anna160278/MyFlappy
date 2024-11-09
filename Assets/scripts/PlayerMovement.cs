using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float force = 5f;
    private Rigidbody2D rb;
    public GameManager manager;
    public bool gameActive = true;
   

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (gameActive) {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
                Jump();
            }
        }
    }

    void Jump() {
        rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            manager.DieSoundPlay();
            gameActive = false;
            manager.GameOver();
        }
    }
}

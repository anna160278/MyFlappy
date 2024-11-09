using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen;
    public PlayerMovement playerMovement;
    public int score = 0;
    public int record = 0;
    public TextMeshProUGUI scoreTextGameOver;
    public TextMeshProUGUI recordTextGameOver;
    public TextMeshProUGUI scoreText;
    public AudioSource bgMusicAudioSource;
    public AudioSource gameSoundAudioSource;
    public AudioClip pointSound;
    public AudioClip dieSound;

    void Start() {
        winScreen.gameObject.SetActive(false);
        if (!PlayerPrefs.HasKey("Record")) {
            PlayerPrefs.SetInt("Record", 0);
        }
        else {
            record = PlayerPrefs.GetInt("Record");
        }
    }

    public void UpdateUI() {
        scoreText.text = score.ToString();
    }

    public void GameOver() {
        StartCoroutine(Timer(2));
        Time.timeScale = 0f;
        PlayerPrefs.SetInt("Record", record);
        PlayerPrefs.Save();
        winScreen.gameObject.SetActive(true);
        scoreTextGameOver.text = "score: " + score.ToString();
        recordTextGameOver.text = "best: " + record.ToString();
        bgMusicAudioSource.Stop();
    }

    public void RestartGame() {
        StartCoroutine(Timer(1));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        playerMovement.gameActive = true;
    }

    IEnumerator Timer(float waitTime) {
        yield return new WaitForSeconds(waitTime);
    }

    public void DieSoundPlay() {
        gameSoundAudioSource.PlayOneShot(dieSound);
    }

    public void PointPlus() {
        score++;
        if (score > record) {
            record = score;
            PlayerPrefs.SetInt("Record", record);
        }
        gameSoundAudioSource.PlayOneShot(pointSound);
        UpdateUI();
    }
}

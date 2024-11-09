using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTube : MonoBehaviour
{
    public GameObject tube;
    private float timer;
    public float timeBtwSpawn = 1f;
    public float myDeltaTime = .5f;
    public float minY = -5f;
    public float maxY = -3.3f;
    private Quaternion startRotation;

    void Start() {
        //timer = timeBtwSpawn;
        startRotation = tube.transform.rotation;
    }

    void Update() {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Vector2 spawnPosition = new Vector2(transform.position.x, Random.Range(minY, maxY));
            Instantiate(tube, spawnPosition, startRotation);
            timer = Random.Range(timeBtwSpawn - myDeltaTime, timeBtwSpawn + myDeltaTime);
        }
    }
}

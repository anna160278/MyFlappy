using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public GameObject background;
    public float widthScreen = 19.2f;

    public void CreateBg(Transform parent) {
        Vector2 posBackground = new Vector2(parent.position.x + widthScreen, parent.position.y);
        Instantiate(background, posBackground, Quaternion.identity);
    }
}

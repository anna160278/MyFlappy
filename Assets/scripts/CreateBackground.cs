using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public GameObject background;

    public void CreateBg(Transform parent) {
        Vector2 posBackground = new Vector2(parent.position.x + 19.2f, parent.position.y);
        Instantiate(background, posBackground, Quaternion.identity);
    }
}

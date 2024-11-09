using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float width = 17.78f;

    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform background = transform.GetChild(i);
            background.position += Vector3.left * GameManager.moveSpeed * Time.deltaTime;

            if (background.position.x <= -width)
            {
                background.position += new Vector3(width * 2, 0, 0);
            }
        }
    }
}

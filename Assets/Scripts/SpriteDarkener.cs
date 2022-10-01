using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDarkener : MonoBehaviour
{
    private void Awake()
    {
        foreach (SpriteRenderer sprite in GameObject.FindObjectsOfType<SpriteRenderer>())
        {
            sprite.color = Color.black;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conflicto1 : MonoBehaviour
{
    public SpriteRenderer playerRenderer;

    public void Start()
    {
        playerRenderer = GetComponent<SpriteRenderer>();
        playerRenderer.color = Color.red;
    }
}

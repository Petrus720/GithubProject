using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer playerRenderer;


    public void Start()
    {
        playerRenderer = GetComponent<SpriteRenderer>();
        playerRenderer.color = Color.white;
    }
}

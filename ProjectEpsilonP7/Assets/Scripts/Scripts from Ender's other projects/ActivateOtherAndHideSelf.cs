using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOtherAndHideSelf : MonoBehaviour
{
    public SpriteRenderer visibility;
    public GameObject gameOverScreen;
    void Start()
    {
        visibility = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        gameOverScreen.SetActive(true);
        visibility.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unkown2 : MonoBehaviour
{
    public SpriteRenderer visibility;
    public GameObject MainTitleScreen;
    void Start()
    {
        visibility = GetComponent<SpriteRenderer>();
    }
    void OnClick(Collider2D other)
    {
        MainTitleScreen.SetActive(false);
        
    }
}

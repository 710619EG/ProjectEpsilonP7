using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CredirButton : MonoBehaviour
{
    public GameObject UI;
    public GameObject MainTitleScreen;
    // Start is called before the first frame update
    public void CreditStart()
    {
        UI.SetActive(true);
        MainTitleScreen.SetActive(false);
    }

    // Update is called once per frame
    void OnClick(Collider2D other)
    {
        

    }
}

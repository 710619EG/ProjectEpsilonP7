using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    //This function loads the scene with all the gameplay stuff
    public void LoadContainmentScene()
    {
        SceneManager.LoadScene("ContainmentRooms");
    }

    //Thia lets you go bac to main menu
    public void ReturnToMainMenuScreen()
    {
        SceneManager.LoadScene("MainMenu");
    }


    //This function lets the player(user) to quit the game once they've had enough of our game's jank.
    public void QuitGame()
    {
        Application.Quit();
    }
}

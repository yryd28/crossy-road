using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void MainmenuExit() {
        SceneManager.LoadScene("Main Menu");
    }

    public void Restart(){
        SceneManager.LoadScene("InGame");
    }
   
}

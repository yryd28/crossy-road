using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saving : MonoBehaviour
{
    public InputField valueText;
    public Text scoreText;

    public void SaveScore(){
        int score = int.Parse(valueText.text);

        PlayerPrefs.SetInt("Score: ", score);

        scoreText.text = "Your Score: " + PlayerPrefs.GetInt("Score");
    }
}

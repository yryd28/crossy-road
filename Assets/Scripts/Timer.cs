using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text TextTimer;
    public float Waktu = 100;

    void SetText(){
        int Minutes = Mathf.FloorToInt(Waktu / 60); 
        int Seconds = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Minutes.ToString("00") + ":" + Seconds.ToString("00");

    }
    float s;

    private void Update()
    {
        s += Time.deltaTime; 
        if (s >= 1)
        {
        Waktu++;
        s = 0;
        }
    SetText();
    } 
 
}

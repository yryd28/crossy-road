using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillerPlayerOnTouch : MonoBehaviour
{
   public Gameover gc;
   public void OnCollisionEnter(Collision collision)
   {
      if(collision.collider.GetComponent<Player>() !=null)
      {
         Destroy(collision.gameObject);
         SceneManager.LoadScene("Game Over");
         
      }
   }
}

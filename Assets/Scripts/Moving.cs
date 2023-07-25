using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float speed;
   public bool isLog;

   private void Update()
   {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
         if(col.gameObject.tag == "Ball")
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         }
    }

    
}

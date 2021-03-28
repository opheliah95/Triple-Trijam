using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CommonInteraction : MonoBehaviour
{
   
    public void OnExit()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}

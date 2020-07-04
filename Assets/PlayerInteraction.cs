using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public float rayCastDistance;
    public Vector3 mousePos;
    bool canInteract;

    private void Update()
    {
        
    }


    public void OnHold(InputValue val)
    {
        Debug.Log("mousepos");
        if (val.isPressed)
        {
            canInteract = true;
            mousePos = val.Get<Vector3>();
            Debug.LogFormat("Mouse position is {0}", mousePos);
        }
            

    }

}

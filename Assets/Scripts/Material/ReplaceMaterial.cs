using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReplaceMaterial : MonoBehaviour
{
    public MeshRenderer obj;
    public Material mat;
    [SerializeField]
    InputActionMap debugMap;
    [SerializeField]
    InputAction fireAction;
    private void Awake()
    {
        // create a new input map in run time
        debugMap = new InputActionMap("Debug");
        fireAction = debugMap.AddAction("Test", binding: "<Keyboard>/m");

        // enable map and add relevant key event
        debugMap.Enable();
        fireAction.started += param => UpdateMaterial();
    }

    public void UpdateMaterial()
    {
        obj.material = mat;
    }
}

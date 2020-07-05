﻿// credits to unity input system's InGameHintsExample.cs
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public float rayCastDistance = 10f;
    public Transform rayCastPoint;
    public Vector3 mousePos;
    public float holdDistance;
    public float force = 5f;

    [SerializeField]
    private State m_currentState;
    [SerializeField]
    private Transform m_currentObject;

    private enum State
    {
        Wandering,
        ObjectInSight,
        ObjectPickUp
    }

    public void OnEnable()
    {
        ChangeState(State.Wandering);
    }

    private void Update()
    {
        switch (m_currentState)
        {
            // wandering as default fails through state
            case State.Wandering:
            case State.ObjectInSight:
                // racast to check if there is stuff in sight
                RaycastHit hitInfo;
                // for debuging purpose...
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayCastDistance, Color.green);
                if (Physics.Raycast(transform.position, transform.forward, out hitInfo, rayCastDistance)
                    && !hitInfo.collider.gameObject.isStatic)
                {
                    // check the state player is in
                    if (m_currentState != State.ObjectInSight)
                    {
                        ChangeState(State.ObjectInSight);
                        m_currentObject = hitInfo.collider.transform;
                    }
                } else if (m_currentState != State.Wandering)
                {
                    // change state to wandering
                    // does not hold any current objects
                    ChangeState(State.Wandering);
                    m_currentObject = null;
                
                }
                break;
            case State.ObjectPickUp:
                break;

        }
              
    }


    // update the state of the player
    private void ChangeState(State newState)
    {
        switch (newState)
        {
            case State.Wandering:
                break;
            case State.ObjectInSight:
                break;
            case State.ObjectPickUp:
                break;
        }

        m_currentState = newState;
    }

    public void OnHold(InputValue val)
    {
        if (m_currentObject != null)
        {
            // Mount to our transform.
            m_currentObject.GetComponent<Rigidbody>().isKinematic = true;
            m_currentObject.position = default;
            m_currentObject.rotation = new Quaternion(0, 0, 0, 0);
            m_currentObject.SetParent(transform, worldPositionStays: false);
            m_currentObject.localPosition += new Vector3(0, 0, holdDistance);
            ChangeState(State.ObjectPickUp);
        }

    }

    public void OnRelease(InputValue val)
    {
        // throw the object away
        m_currentObject.parent = null; // unparenting
        m_currentObject.GetComponent<Rigidbody>().isKinematic = false;
        // add an impulse force to rigidbody
        m_currentObject.GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
       ChangeState(State.Wandering);
    
    }

}

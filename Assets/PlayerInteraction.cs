// credits to unity input system's InGameHintsExample.cs
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public float rayCastDistance;
    public Transform rayCastPoint;
    public Vector3 mousePos;

    [SerializeField]
    private State m_currentState;
    [SerializeField]
    private Transform m_currentObjectTransform;

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
                        m_currentObjectTransform = hitInfo.collider.transform;
                    }
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
            

    }

}

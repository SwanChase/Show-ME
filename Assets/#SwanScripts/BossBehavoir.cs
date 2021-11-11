using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavoir : MonoBehaviour
{
    Animator m_Animator;
    WanderingAI AIMovement;
    Rigidbody rig;
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        AIMovement = GetComponentInParent<WanderingAI>();
        rig = GetComponentInParent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            AIMovement.enabled = false;
            m_Animator.SetTrigger("Die");
        }
    }
}

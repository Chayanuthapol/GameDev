using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class MyAnimatorControlScript : MonoBehaviour
{
    protected Animator m_Animator;

    
    private static readonly int Turn = Animator.StringToHash("Turn");
    private static readonly int Forward = Animator.StringToHash("Forward");

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Animator.SetFloat(Turn, 0f);
            m_Animator.SetFloat(Forward,1f);
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Animator.SetFloat(Turn, 1f);
            m_Animator.SetFloat(Forward,1f);
            
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Animator.SetFloat(Turn, 0f);
            m_Animator.SetFloat(Forward,0.5f);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            m_Animator.SetFloat(Turn, 1f);
            m_Animator.SetFloat(Forward,0.5f);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            m_Animator.SetFloat(Turn, 0f);
            m_Animator.SetFloat(Forward,0f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            m_Animator.SetFloat(Turn, 1f);
            m_Animator.SetFloat(Forward,0f);
        }
    }
}

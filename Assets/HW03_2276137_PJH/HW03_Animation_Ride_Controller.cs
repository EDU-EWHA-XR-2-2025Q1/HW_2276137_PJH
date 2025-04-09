using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animation_Ride_Controller : MonoBehaviour
{
    public Animator Animator;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Vehicle")
        {
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;
            Animator.speed = 1f;
            Animator.SetBool("isMoving", true); // �Ǵ� Trigger, speed ��
        }

  
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {

            transform.SetParent(null);

            // Vehicle �ִϸ��̼� ����
            if (Animator != null)
            {
                Animator.speed = 0f;// �Ǵ� animator.speed = 0f;
            }

        }
    }
}

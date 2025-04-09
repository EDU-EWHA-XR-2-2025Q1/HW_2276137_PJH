using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Door_Controller : MonoBehaviour
{
    public Animator Animator;
    public Transform doorTransform; // �� ��ü�� Transform

    private bool enteredFromOutside = false;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 doorForward = doorTransform.forward;
        Vector3 playerToDoor = (doorTransform.position - other.transform.position).normalized;

        float dot = Vector3.Dot(doorForward, playerToDoor);

        if (dot > 0)
        {
            // ���� �ٶ󺸴� ����� �÷��̾ ���� ������ ���� -> �ȿ��� ������ ��
            Animator.SetInteger("status", 1);
            enteredFromOutside = false;
        }
        else
        {
            // �ݴ� ���⿡�� ������ �� -> �ۿ��� ������
            Animator.SetInteger("status", 3);
            enteredFromOutside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enteredFromOutside)
        {
            Animator.SetInteger("status", 4); // �� -> �� ����
        }
        else
        {
            Animator.SetInteger("status", 2); // �� -> �� ����
        }
    }
}

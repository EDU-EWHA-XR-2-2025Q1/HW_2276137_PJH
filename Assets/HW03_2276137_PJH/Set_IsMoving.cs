using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_IsMoving : StateMachineBehaviour
{
    // �ִϸ��̼� ���¿� �� �� ȣ���
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isMoving", false);  // �ִ� ���� ���� �� �ڵ����� false�� ����
    }
}

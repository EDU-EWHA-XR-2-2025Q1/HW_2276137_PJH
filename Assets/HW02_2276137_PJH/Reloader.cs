using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour
{
    public void OnClick_LoadScene()
    {
        SceneManager.LoadScene(0); // �� �ε��� 0 (�Ǵ� �� �̸��� ����)
    }
}

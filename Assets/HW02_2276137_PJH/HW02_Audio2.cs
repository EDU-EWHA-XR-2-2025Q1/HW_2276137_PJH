using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource[] Audio;

    void Start()
    {
           Audio[0].loop = true;
           Audio[0].Play();

    }

    void Update()
    {
        // ���� Ű ������ ��� ����� ���
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Audio[0].Pause();
        }
    }
}

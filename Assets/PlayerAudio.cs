using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����PlatformCharacter2D�ű��������ռ�
using UnityStandardAssets._2D;
public class PlayerAudio : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlatformerCharacter2D cc = GetComponent<PlatformerCharacter2D>();
        // �ҵ�֮ǰ���¼�JumpEvent��Ϊ�����һ���������ߡ�
        // �����߾��������OnPlayerJump���������¼�����ʱ����ĺ����ͻᱻ����
        cc.JumpEvent.AddListener(OnPlayerJump);
    }

    void OnPlayerJump()
    {
        audioSource.clip = Resources.Load<AudioClip>("electronic_01");
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 引入PlatformCharacter2D脚本的命名空间
using UnityStandardAssets._2D;
public class PlayerAudio : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlatformerCharacter2D cc = GetComponent<PlatformerCharacter2D>();
        // 找到之前的事件JumpEvent，为它添加一个“订阅者”
        // 订阅者就是下面的OnPlayerJump函数，当事件发生时下面的函数就会被调用
        cc.JumpEvent.AddListener(OnPlayerJump);
    }

    void OnPlayerJump()
    {
        audioSource.clip = Resources.Load<AudioClip>("electronic_01");
        audioSource.Play();
    }
}

using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    static bool AudioBegin = false;
    public AudioSource bgm;

    void Awake()
    {
        if (!AudioBegin)
        {
            bgm.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}

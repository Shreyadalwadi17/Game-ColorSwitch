using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;

    public List<Sound> clips;
    public static Audio inst;


    public void Awake()
    {
        inst = this;

    }

    public void SoundPlay(SoundName name)
    {
        foreach (var item in clips)
        {
            if (item.bgName == name)
            {
                audioSource.PlayOneShot(item.clip);
                break;
            }
        }

    }
  

    [System.Serializable]
    public class Sound
    {
        public SoundName bgName;
        public AudioClip clip;
    }
    public enum SoundName
    {
        Shoot,
        ColorChange,
        Buttons,
        GameOver,
        Try
    }



}





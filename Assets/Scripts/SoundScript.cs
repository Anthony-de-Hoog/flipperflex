using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;

    public void PlaySound()
    {
        source.PlayOneShot(clip);
    }

}

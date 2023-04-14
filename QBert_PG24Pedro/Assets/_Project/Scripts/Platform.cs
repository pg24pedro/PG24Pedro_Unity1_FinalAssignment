using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour, IPlatform
{
    [SerializeField]
    Material _platformNormal;

    [SerializeField]
    Material _platformFlipped;

    [SerializeField]
    Renderer _platformRenderer;

    [SerializeField]
    AudioClip _flipSound;

    public bool Flipped { get; private set; }

    public void SetFLippedState(bool flipped)
    {
        Flipped = flipped;
        SetPlatformMaterial();

        if (flipped)
        { 
            //Play audio clip
            //Add points to score
        }

        //Tell game manager we flipped the platform
    }


    public void SetPlatformColor(Color color)
    {
        _platformRenderer.material.color = color;
    }
    private void SetPlatformMaterial()
    {
        _platformRenderer.material = Flipped ? _platformFlipped : _platformNormal;
    }

}

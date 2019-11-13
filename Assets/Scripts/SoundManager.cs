﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public void Start(){
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayButtonSound() {
        this.GetComponent<AudioSource>().Play();
    }
}

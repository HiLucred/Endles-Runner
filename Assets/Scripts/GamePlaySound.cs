using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySound : MonoBehaviour
{
    private AudioSource _gamePlaySong;
    
    private void Awake()
    {
        _gamePlaySong = GetComponent<AudioSource>();
    }

    private void Start()
    {
        PlayGamePlaySound();
    }

    private void PlayGamePlaySound()
    {
        StartCoroutine(PlayGamePlaySoundCoroutine());
    }

    public void StopGameplaySound()
    {
        _gamePlaySong.Stop();
    }

    private IEnumerator PlayGamePlaySoundCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        _gamePlaySong.Play();
    }
    
}
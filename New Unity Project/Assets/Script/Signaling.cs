using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Signaling : MonoBehaviour
{
    private AudioSource _audio;

    private bool _exit = false;
    private bool _enter = false;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_exit == true && _audio.volume != 0)
            _audio.volume -= 0.01f;

        else if (_enter == true && _audio.volume != 1)
            _audio.volume += 0.005f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMovement>(out PlayerMovement player))
        {
            _audio.Play();

            _exit = false;
            _enter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMovement>(out PlayerMovement player))
        {
            _exit = true;
            _enter = false;
        }
    }
}


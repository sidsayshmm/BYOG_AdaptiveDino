﻿using System;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace BreakYourOwnGame
{
    public class PlayerTriggered : SerializedMonoBehaviour
    {
        [OdinSerialize] private AudioClip deathClip;

        private GameEnforcer gameEnforcer;
        private void Awake()
        {
            gameEnforcer = FindObjectOfType<GameEnforcer>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
            {
                Sound.audSource.PlayOneShot(deathClip);
                gameEnforcer.GameRunning = false;
            }
        }
    }
}
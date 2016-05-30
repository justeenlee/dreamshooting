﻿using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;

    Animator anim;
	float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameIsOver");
			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) {
				//deprecated
				Application.LoadLevel (Application.loadedLevel);
			}
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
	// Variables
	[SerializeField] private AudioSource _gunShotAudioSource;
	[SerializeField] private AudioClip _gunShotAudioClip;

	[SerializeField] private AudioSource _playerHurtAudioSource;
	[SerializeField] private AudioClip _playerHurtAudioClip;
	[SerializeField] private AudioSource _playerDeathAudioSource;
	[SerializeField] private AudioClip _playerDeathAudioClip;

	[SerializeField] private AudioSource _enemyHurtAudioSource;
	[SerializeField] private AudioClip _enemyHurtAudioClip;
	[SerializeField] private AudioSource _enemyDeathAudioSource;
	[SerializeField] private AudioClip _enemyDeathAudioClip;

	[SerializeField] private AudioSource _winpAudioSource;
	[SerializeField] private AudioClip _winAudioClip;
	[SerializeField] private AudioSource _loseAudioSource;
	[SerializeField] private AudioClip _loseAudioClip;

	// Functions
	private void Start()
	{
		if (_gunShotAudioSource == null)
		{
			_gunShotAudioSource = GetComponent<AudioSource>();
		}
		if (_enemyHurtAudioSource == null)
		{
			_enemyHurtAudioSource = GetComponent<AudioSource>();
		}
		if (_enemyDeathAudioSource == null)
		{
			_enemyDeathAudioSource = GetComponent<AudioSource>();
		}
		if (_playerHurtAudioSource == null)
		{
			_playerHurtAudioSource = GetComponent<AudioSource>();
		}
		if (_playerDeathAudioSource == null)
		{
			_playerDeathAudioSource = GetComponent<AudioSource>();
		}
		if (_winpAudioSource == null)
		{
			_winpAudioSource = GetComponent<AudioSource>();
		}
		if (_loseAudioSource == null)
		{
			_loseAudioSource = GetComponent<AudioSource>();
		}
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			FireGun();
		}
	}
	private void FireGun()
	{
		if (_gunShotAudioSource != null && _gunShotAudioClip != null)
		{
			_gunShotAudioSource.PlayOneShot(_gunShotAudioClip);
		}
	}
}

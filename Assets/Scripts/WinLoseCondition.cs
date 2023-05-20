using System.Collections;
using UnityEngine;
using TMPro;

public class WinLoseCondition : MonoBehaviour
{
	[SerializeField] private int _killCountMax;
	[SerializeField] private KillCounter _killCounter;
	[SerializeField] private TimerScript _timerScript;
	[SerializeField] private GameObject _youWinMessage;
	[SerializeField] private GameObject _youLoseMessage;

	[SerializeField] private AudioSource _winAudioSource;
	[SerializeField] private AudioClip _winAudioClip;

	[SerializeField] private AudioSource _loseAudioSource;
	[SerializeField] private AudioClip _loseAudioClip;

	private bool _isGameWon = false;

	private void Start()
	{
		if (_winAudioSource != null) 
		{
			_winAudioSource= GetComponent<AudioSource>(); 
		}
		if(_loseAudioSource != null)
		{
			_loseAudioSource = GetComponent<AudioSource>();
		}
	}

	private void Update()
	{
		if (_killCounter._killCount == _killCountMax && _timerScript._timeLeft > 0.0f && !_isGameWon)
		{
			if (_winAudioSource != null && _winAudioClip != null)
			{
				_winAudioSource.PlayOneShot(_winAudioClip);
			}
			_isGameWon = true;
			Debug.Log("You Win");
			_youWinMessage.SetActive(true);
			_timerScript.StopTimer();
		}
		else if (_killCounter._killCount < _killCountMax && _timerScript._timeLeft <= 0.0f && !_isGameWon)
		{
			if (_loseAudioSource != null && _loseAudioClip != null)
			{
				_loseAudioSource.PlayOneShot(_loseAudioClip);
			}
			_youLoseMessage.SetActive(true);
			Debug.Log("You Lose");
			_timerScript.StopTimer();
		}
	}
}

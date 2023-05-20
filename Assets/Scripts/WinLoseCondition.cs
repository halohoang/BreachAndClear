using System.Collections;
using UnityEngine;
using TMPro;

public class WinLoseCondition : MonoBehaviour
{
	[SerializeField] private int _killCountMax;
	[SerializeField] private KillCounter _killCounter;
	[SerializeField] private TimerScript _timerScript;

	private bool _isGameWon = false;

	private void Update()
	{
		if (_killCounter._killCount == _killCountMax && _timerScript._timeLeft > 0.0f && !_isGameWon)
		{
			_isGameWon = true;
			Debug.Log("You Win");
			_timerScript.StopTimer();
		}
		else if (_killCounter._killCount < _killCountMax && _timerScript._timeLeft <= 0.0f && !_isGameWon)
		{
			Debug.Log("You Lose");
			_timerScript.StopTimer();
		}
	}
}

using System.Collections;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
	[SerializeField] private float _maximumTime = 60f;
	[SerializeField] internal float _timeLeft;
	[SerializeField] private TextMeshProUGUI _textMeshProUGUI;

	private bool _isTimerRunning = true;

	private void Start()
	{
		_timeLeft = _maximumTime;
	}

	private void Update()
	{
		if (_isTimerRunning)
		{
			_timeLeft -= Time.deltaTime;
			if (_timeLeft <= 0f)
			{
				_timeLeft = 0f;
				// Game Over
				Debug.Log("Game Over");
			}

			// Update the TextMeshProUGUI text with the current time left
			if (_textMeshProUGUI != null)
			{
				_textMeshProUGUI.text = _timeLeft.ToString("F2");
			}
		}
	}

	public void StartTimer()
	{
		_isTimerRunning = true;
	}

	public void StopTimer()
	{
		_isTimerRunning = false;
	}
}

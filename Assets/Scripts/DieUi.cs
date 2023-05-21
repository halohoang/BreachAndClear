using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieUi : MonoBehaviour
{
	// Variables
	[SerializeField] private TimerScript _timerScript;
	[SerializeField] private Image _image;
	[SerializeField] private float _fadeDuration = 2f;
	[SerializeField] private float _maxAlpha = 1f;
	[SerializeField] private float _minAlpha = 0f;

	private bool _isFading = false;

	// Functions

	private void Start()
	{
		Color startColor = _image.color;
		startColor.a = _minAlpha;
		_image.color = startColor;
	}

	private void Update()
	{
		if (_timerScript._timeLeft <= 0f && !_isFading)
		{
			StartFade();
		}
	}

	private void StartFade()
	{
		StartCoroutine(FadeScreenColor());
	}

	private IEnumerator FadeScreenColor()
	{
		_isFading = true;
		float timer = 0f;
		Color startColor = _image.color;
		Color endColor = startColor;
		endColor.a = _maxAlpha;

		while (timer < _fadeDuration)
		{
			timer += Time.deltaTime;
			float normalizedTime = timer / _fadeDuration;
			Color lerpedColor = Color.Lerp(startColor, endColor, normalizedTime);
			_image.color = lerpedColor;
			yield return null;
		}

		_image.color = endColor;
		_isFading = false;
	}
}

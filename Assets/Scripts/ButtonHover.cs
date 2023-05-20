using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonHoverSprite : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField] private GameObject targetObject;
	[SerializeField] private AudioSource _breachAudioSource;
	[SerializeField] private AudioClip _breachAudioClip;

	[SerializeField] private AudioSource _playAudioSource;
	[SerializeField] private AudioClip _playAudioClip;

	[SerializeField] private TextMeshProUGUI _breachText;
	[SerializeField] private TextMeshProUGUI _enterText;



	//private bool _isClipPlaying = false;

	void Start()
	{
		if (_breachAudioSource != null)
		{
			_breachAudioSource = GetComponent<AudioSource>();
		}
	}

	//private void OnEnable()
	//{
	//	SceneManager.sceneLoaded += OnSceneLoaded;
	//}

	//private void OnDisable()
	//{
	//	SceneManager.sceneLoaded -= OnSceneLoaded;
	//}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (_breachAudioSource != null && _breachAudioClip != null)
		{
			UpdateEnter();
			_breachAudioSource.PlayOneShot(_breachAudioClip);
		}
		targetObject.SetActive(true);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		_playAudioSource.PlayOneShot(_playAudioClip);
		UpdateExit();
		targetObject.SetActive(false);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (_playAudioSource != null && _playAudioClip != null)
		{
			//_isClipPlaying = true;
			SceneManager.LoadScene(1);
		}
	}

	void UpdateEnter()
	{
		_breachText.text = "60 SECONDS";
	}
	void UpdateExit()
	{
		_enterText.text = "BREACH";
	}

	//private IEnumerator WaitForClipToEnd()
	//{
	//	while (_isClipPlaying)
	//	{
	//		yield return null;
	//	}

	//	int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	//	int nextSceneIndex = currentSceneIndex + 1;
	//	if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
	//	{
	//		If the next scene index exceeds the total number of scenes, wrap back to the first scene
	//		nextSceneIndex = 0;
	//	}

	//	SceneManager.LoadScene(nextSceneIndex);
	//}

	//private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	//{
	//	_isClipPlaying = false;
	//}
}

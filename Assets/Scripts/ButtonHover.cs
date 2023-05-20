using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverSprite : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] private GameObject targetObject;
	[SerializeField] private AudioSource _breachAudioSource;
	[SerializeField] private AudioClip _breachAudioClip;

	void Start()
	{
		if (_breachAudioSource != null)
		{

			_breachAudioSource = GetComponent<AudioSource>();
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (_breachAudioSource != null && _breachAudioClip != null)
		{
			_breachAudioSource.PlayOneShot(_breachAudioClip);
		}
		targetObject.SetActive(true);
	}

	

	public void OnPointerExit(PointerEventData eventData)
	{
		targetObject.SetActive(false);
	}
}

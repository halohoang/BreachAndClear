using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverSprite : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] private GameObject targetObject;

	public void OnPointerEnter(PointerEventData eventData)
	{
		targetObject.SetActive(true);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		targetObject.SetActive(false);
	}
}

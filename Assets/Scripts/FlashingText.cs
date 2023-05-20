using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonTextAnimation : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI buttonText;
	[SerializeField] private float flashInterval = 0.5f;
	[SerializeField] private Color flashColor = Color.red;
	[SerializeField] private Color defaultColor = Color.white;

	private Coroutine animationCoroutine;

	private void Start()
	{
		// Start the animation when the scene starts
		StartTextAnimation();
	}

	public void StartTextAnimation()
	{
		// Ensure only one instance of the animation is running
		StopTextAnimation();

		// Start the animation coroutine
		animationCoroutine = StartCoroutine(FlashTextAnimation());
	}

	public void StopTextAnimation()
	{
		// Stop the animation coroutine if it's running
		if (animationCoroutine != null)
		{
			StopCoroutine(animationCoroutine);
			animationCoroutine = null;
		}

		// Reset the text color to default
		buttonText.color = defaultColor;
	}

	private IEnumerator FlashTextAnimation()
	{
		while (true)
		{
			// Flash the text to the flash color
			buttonText.color = flashColor;

			yield return new WaitForSeconds(flashInterval);

			// Restore the text to the default color
			buttonText.color = defaultColor;

			yield return new WaitForSeconds(flashInterval);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCounter : MonoBehaviour
{
    // Variables
    internal int _killCount = 0;
	[SerializeField ]private TextMeshProUGUI _killCountText;
	// Functions

	internal void IncrementKillCount()
    {
        _killCount++;
		UpdateKillCountText();

    }
	 void UpdateKillCountText()
	{
		_killCountText.text = "Neutralize:  " + _killCount.ToString();
	}
}

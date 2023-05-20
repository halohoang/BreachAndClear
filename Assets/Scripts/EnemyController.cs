using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Variables
    private int _clickCount = 0;
   [SerializeField] private int _clickCountMin; //Minimum require amount to destroy the enemy
	  KillCounter _killCounter; //Reference to the KillCounter script

	// Functions
	private void Start()
	{
		_killCounter = GameObject.FindObjectOfType<KillCounter>(); //Find the KillCounter script
	}

	private void OnMouseDown()
	{
		_clickCount++; //Each time you click on an enemy the click count will increase by 1

		if( _clickCount >= _clickCountMin ) //The enemy will be destroyed if the click count is greater than or equal to the minimum click count
		{
			_killCounter.IncrementKillCount(); //Increment the kill count
			// Destroy the enemy
			Destroy( transform.parent.gameObject);
		}
	}
}

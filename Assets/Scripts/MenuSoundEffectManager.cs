using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSoundEffectManager : MonoBehaviour
{
	// Variables
	[SerializeField] private AudioSource _breachAudioSource;
	[SerializeField] private AudioClip _breachAudioClip;
	// Functions
	void Start()
    {
        if(_breachAudioSource != null)
        {
            _breachAudioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

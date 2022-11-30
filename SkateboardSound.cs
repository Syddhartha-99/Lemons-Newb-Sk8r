using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateboardSound : MonoBehaviour
{
	[SerializeField]
	AudioSource skateboardRoll;
	
	CrashDetector crashDetector;

	
	void Start()
	{
		crashDetector = GetComponentInParent<CrashDetector>();
	}
	
	void Update()
	
	{
		if (crashDetector.crashState == true)
		
		{
			skateboardRoll.Stop();
		}
	}
	
	private void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Level")
		{
			skateboardRoll.Play();
		}
	}
	
	private void OnTriggerExit2D(Collider2D other) 
	{		
		if (other.gameObject.tag == "Level" )
		{
			skateboardRoll.Pause();
		}	
	}

}

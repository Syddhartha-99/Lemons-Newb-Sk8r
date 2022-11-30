using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustEffect : MonoBehaviour
{
	[SerializeField]
	ParticleSystem dustEffect;
	
	private void OnCollisionEnter2D(Collision2D other) 
	{
		if (other.gameObject.tag == "Level")
		{
			dustEffect.Play();
		}
	}
	
	private void OnCollisionExit2D(Collision2D other) 
	{
		if (other.gameObject.tag == "Level")
		
		{
			dustEffect.Stop();
		}
	}
}

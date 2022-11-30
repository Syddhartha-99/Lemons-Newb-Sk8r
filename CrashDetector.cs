using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
	[SerializeField]
	float reloadSceneTimer = 1f;
	
	[SerializeField]
	ParticleSystem crashEffect;
	
	public bool crashState = false;
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Level" && crashState == false)
		{
			crashEffect.Play();
			crashState = true;
			Invoke("ReloadScene", reloadSceneTimer);
		}
	}
 
	void ReloadScene ()
	
	{
		SceneManager.LoadScene(0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
	[SerializeField]
	ParticleSystem finishEffect;
	
	SurfaceEffector2D surfaceEffector2D;

	
	public float delayTime = 2f;
	
	void Start() 
	{
		surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>(); 
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player")
		{
			finishEffect.Play();
			
			Invoke("DelayedAction", delayTime);
		}
	}
	
	void DelayedAction()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
 
}

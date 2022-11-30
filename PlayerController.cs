using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	[SerializeField]
	float torqueAmount = 1;
	[SerializeField]
	float normalSpeed = 20;
	[SerializeField]
	float boostSpeed = 40;
	
	SurfaceEffector2D surfaceEffector2D;
	
	CrashDetector crashDetector;
	
	Rigidbody2D rb2d;
	
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		crashDetector = GetComponentInChildren<CrashDetector>();
		surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>(); 
	}

	// Update is called once per frame
	void Update()
	{
		RotatePlayer();
		Boost();
		Stop();
	}
	
	void RotatePlayer()
	{
		if (crashDetector.crashState == false)
		
		{
			if (Input.GetKey(KeyCode.A))
		
			{
				rb2d.AddTorque(torqueAmount);
			}
		
			else if (Input.GetKey(KeyCode.D))
		
			{
				rb2d.AddTorque(-torqueAmount);
			}
		}
	}
	
	void Boost()
	{
		if (crashDetector.crashState == false)
		{
			if (Input.GetKey(KeyCode.Space))
			{
				surfaceEffector2D.speed = boostSpeed;
			}
		
			else
			{
				surfaceEffector2D.speed = normalSpeed;
			}
		}
		
		else if (crashDetector.crashState == true)
		
		{
			surfaceEffector2D.speed = 0;
		}
	}
	
	 void Stop()
	{
		if (Input.GetKey(KeyCode.E))
		{
			surfaceEffector2D.speed = 0;
		}
	}
}

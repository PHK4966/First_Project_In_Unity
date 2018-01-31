using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{

	private Light mylight; 
	// Use this for initialization
	void Start ()
	{
		mylight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.A))
		{
			mylight.enabled = !mylight.enabled;
		}
	}
}

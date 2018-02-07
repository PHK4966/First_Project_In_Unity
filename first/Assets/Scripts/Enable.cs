using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{

	private Light mylight; 
	private  float _count = 12;
	// Use this for initialization
	void Start ()
	{
		mylight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//if (Input.GetKeyUp (KeyCode.A))
	//	{
		//	mylight.enabled = !mylight.enabled;
		//}
		_count -=Time.deltaTime;
		if (_count <= 0)
			mylight.enabled = true;

	}
}

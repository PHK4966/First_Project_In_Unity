using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	int x = 50;


	

	// Use this for initialization
	void Start () {
		/*string[] str =  new string[3];
		str[0] = "hossein kolivand";
		str[1] = "Mohammad Javad kolivand";
		str[2] = "Kosar Kolivand";
		foreach (string VARIABLE in str)
		{
			Debug.Log(VARIABLE);
		}
		Debug.Log(mymethod());
		Debug.Log(x);
		*/
		//Debug.Log("Start Called");
	}
	
	// Update is called once per frame
	

	void Update () {
		//Debug.Log("Update Time: " + Time.deltaTime);
	}

	int mymethod()
	{
		x = 45;
		return x;
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fire : MonoBehaviour
{

	public Rigidbody rocketPrefab;
	public Transform fireplace;

	//public Transform bulletbegin;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0))
		{
			Rigidbody shoot;
			shoot = Instantiate(rocketPrefab,fireplace.position,fireplace.rotation) as Rigidbody;
			shoot.AddForce(Vector3.forward* 4000);
		}
	

	}
}

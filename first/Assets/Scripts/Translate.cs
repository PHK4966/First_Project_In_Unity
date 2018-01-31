using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{

	public int turnspeed = 200; 
	// Use this for initialization
	void Start () {
	
			
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
			gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 5,Space.World);
		if(Input.GetKey(KeyCode.D))
			gameObject.transform.Translate(Vector3.right * Time.deltaTime * 5,Space.World);
		if(Input.GetKey(KeyCode.A))
			gameObject.transform.Translate(Vector3.left * Time.deltaTime * 5,Space.World);
		if(Input.GetKey(KeyCode.S))
			gameObject.transform.Translate(Vector3.back * Time.deltaTime * 5,Space.World);
		if(Input.GetKey(KeyCode.Space))
			gameObject.transform.Translate(Vector3.up * Time.deltaTime * 10,Space.World);
		if(Input.GetKey(KeyCode.LeftArrow))
			gameObject.transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime ,Space.World);
		if(Input.GetKey(KeyCode.RightArrow))
			gameObject.transform.Rotate(Vector3.up, +turnspeed * Time.deltaTime,Space.World);	
		
	}
}

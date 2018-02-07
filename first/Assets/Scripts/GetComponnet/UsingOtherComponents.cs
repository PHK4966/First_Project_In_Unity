using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{

	public GameObject othergameobject;
	
	private YetAnotherScript yetAnotherscript;
	private AnotherScript anotherScript;

	private BoxCollider _boxCollider;
	// Use this for initialization
	private void Awake()
	{
		anotherScript = GetComponent<AnotherScript>();
		yetAnotherscript = othergameobject.GetComponent<YetAnotherScript>();
		_boxCollider = othergameobject.GetComponent<BoxCollider>();
	}

	void Start () {
		_boxCollider.size = new Vector3(3,3,3);
		Debug.Log("The Player's score is: " + anotherScript.PlayerScore);
		Debug.Log("The Pkayer has died " + yetAnotherscript.numberOfPlayerDeaths + "times");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

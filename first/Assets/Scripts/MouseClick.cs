using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {
    private void OnMouseDown()
    {
        
        GetComponent<Rigidbody>().AddForce(transform.forward *100,ForceMode.Impulse);
        GetComponent<Rigidbody>().useGravity = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour {

	public float standingTreshold = 3f;
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (name + IsStandind ());
	}
	public bool IsStandind ()
	{
		Vector3 rotationInEuler = transform.rotation.eulerAngles;

		float tiltInX = Mathf.Abs (rotationInEuler.x);
		float tiltInZ = Mathf.Abs (rotationInEuler.z);

		if (tiltInX < standingTreshold && tiltInZ < standingTreshold)
			return true;
		return false;

	}
}

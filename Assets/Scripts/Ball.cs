using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public bool inPlay = false;

	private Rigidbody rigidbody;
	private AudioSource audioSource;
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
		rigidbody.useGravity = false;
	}
	public void Lunch(Vector3 lunchVelocity)
	{
		rigidbody.useGravity = true;
		rigidbody.velocity = lunchVelocity;
		audioSource.Play ();
		inPlay = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

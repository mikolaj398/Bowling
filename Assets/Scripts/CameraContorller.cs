﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContorller : MonoBehaviour {

	public Ball ball;
	private Vector3 offset;
	void Start () {
		offset = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z <= 1829) {
			transform.position = ball.transform.position + offset;
		}
	}
}

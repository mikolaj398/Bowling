using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Ball))]
public class DragLunch : MonoBehaviour {


	private Vector3 dragStart, dragEnd;
	private float startTime, endTime;
	private Ball ball;
	void Start () 
	{
		ball = GetComponent<Ball> ();
	}

	public void MoveStart(float amount)
	{
		if (!ball.inPlay) ball.transform.Translate (new Vector3 (amount, 0, 0));
	}
	public void OnDragStart()
	{
		dragStart = Input.mousePosition;
		startTime = Time.time;
	}
	public void OnDragEnd()
	{
		dragEnd = Input.mousePosition;
		endTime = Time.time;

		float dragDuration = endTime - startTime;

		float lunchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
		float lunchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

		ball.Lunch (new Vector3 (lunchSpeedX, 0, lunchSpeedZ));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour {

	public Text standingDisplay;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		standingDisplay.text = CountStanding ().ToString ();
	}
	int CountStanding ()
	{
		int standing = 0;

		foreach (Pins pin in GameObject.FindObjectsOfType<Pins>()) 
		{
			if (pin.IsStandind())
			{
				standing++;
			}
		}
		return standing;
	}
}

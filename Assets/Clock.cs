using UnityEngine;
using System.Collections;
using System;

public class Clock : MonoBehaviour 
{
	public GameObject hourHand;
	public GameObject minuteHand;
	public GameObject secondHand;


	void Update()
	{
		DateTime time = DateTime.Now; 

		int second = time.Second;

		// map seconds (0,60) to a rotation (0, 360)
		float seconds_normalized = second / 60f;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;
		
		Vector3 secondsRotation = new Vector3(0f, 0f, clockwise_seconds); 
		Quaternion secondsRotationQuat = Quaternion.Euler(secondsRotation);
		secondHand.transform.rotation = secondsRotationQuat; 

		int minutes = time.Minute;
		Vector3 minutesEuler = new Vector3 (0f, 0f (1f - (minutes / 60f)) * 360f);
		minuteHand.transform.rotation = Quaternion.Euler (minutesEuler);

		hourHand.transform.rotation = Quaternion.Euler (
			Vector3.forward * (1f - (time.Hour / 12f) * 360f));
	
	}


}

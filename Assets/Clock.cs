using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour 
{

	// Use this for initialization

	

	
	// Update is called once per frame
	void Update () 
	{
		Quaternion euler = Quaternion.Euler(
			new Vector3 (0f, 0f, Time.time * 30f) );
		
		transform.localRotation = euler;
	
	}
}

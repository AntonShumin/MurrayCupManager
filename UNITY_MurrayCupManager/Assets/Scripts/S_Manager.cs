using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class S_Manager : MonoBehaviour 
{
	//rotating mustang
	private GameObject hShip;
	private float xDeg;
	private float yDeg;
	private Quaternion fromRotation;
	private Quaternion toRotaion;

	public int speed;
	public float lerpSpeed;
	



	//UI Text
	public GameObject header;
	
	void Awake () 
	{
		hShip = GameObject.FindWithTag ("Ship");
		yDeg = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		rotateDragShip ();
		//headerText ();

	}



	// Drag rotate the ship in main menu
	private void rotateDragShip()
	{
		if ( Input.GetMouseButton(0) ) 
		{
			xDeg -= Input.GetAxis("Mouse X") * speed;
			fromRotation = hShip.transform.rotation;
			toRotaion = Quaternion.Euler(yDeg,xDeg,0);
			hShip.transform.rotation = Quaternion.Lerp(fromRotation,toRotaion,Time.deltaTime*lerpSpeed);
		}
	}
	
}

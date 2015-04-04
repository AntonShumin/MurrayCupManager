using UnityEngine;
using System.Collections;

public class S_MovingPlayer : MonoBehaviour 
{
	public bool pit = false;
	public GameObject hHelper;
	public GameObject hShip;
	private Vector3 offset;

	public void ChooseSubway (ref int i,Vector3[] nextPos)
	{
		if (!pit) 
			i = 1;
		else
			i = 0;
	}

	void Awake()
	{
		hHelper = gameObject;
		offset =  transform.position - hShip.transform.position;
	}

	//void LateUpdate()
	void nothing()
	{
		Vector3 _position = transform.position;
		hShip.transform.position = _position + offset;
		hShip.transform.LookAt (_position);
		//transform.localPosition.y += 10;
	}


}

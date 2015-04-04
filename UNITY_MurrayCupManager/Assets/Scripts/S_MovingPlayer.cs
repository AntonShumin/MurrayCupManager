using UnityEngine;
using System.Collections;

public class S_MovingPlayer : MonoBehaviour 
{
	public bool pit = false;

	public void ChooseSubway (ref int i,Vector3[] nextPos)
	{
		if (!pit) 
			i = 1;
		else
			i = 0;
	}

}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class S_UI: MonoBehaviour 
{
	//Sound
	public AudioClip uiSound1;
	public AudioClip uiSound2;

	Dictionary<string,GameObject> UI_Collection = new Dictionary<string,GameObject>();

	void Awake () 
	{
		setupUI ();
	}

	void setupUI()
	{
		List<string> list_UInames = new List<string>{"Ship"};
		
		string name_container = "";
		GameObject go_container = null;
		foreach (string l in list_UInames) 
		{
			name_container = l + "_container" ;
			go_container = GameObject.Find(name_container);
//			List<GameObject> container_subWindows = new List<GameObject>();
			UI_Collection.Add(l,go_container);
		}
	}

	public void clickButton(string name)
	{
		S_Sound.instance.RandomizeSfx (uiSound1,uiSound2);
		//S_Sound.instance.musicSource.Stop ();
		
	}
	
}

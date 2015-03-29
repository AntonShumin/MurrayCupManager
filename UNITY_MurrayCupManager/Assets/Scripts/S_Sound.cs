using UnityEngine;
using System.Collections;

public class S_Sound : MonoBehaviour 
{
	public AudioSource efxSource;
	public AudioSource musicSource;
	public static S_Sound instance = null; // instance of this script, checks for doubles in Awake()

	public float lowPitchRange = 0.95f;
	public float highPitchRange = 1.05f;


	// Use this for initialization
	void Awake () 
	{
	 	if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	public void PlaySingle(AudioClip clip)
	{
		efxSource.clip = clip;
		efxSource.Play ();
	}

	public void RandomizeSfx (params AudioClip[] clips) 
	{
		int randomIndex = Random.Range(0,clips.Length);
		float randomPitch = Random.Range (lowPitchRange, highPitchRange);

		efxSource.pitch = randomPitch;
		efxSource.clip = clips [randomIndex];
		efxSource.Play ();
	}

	public void menuClicked()
	{
		Debug.Log ("test");
	}
	

}

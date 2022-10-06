using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{

	// Use this for initialization
	private AudioSource source;


	void Start ()
	{
		source = GetComponent <AudioSource> ();	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void setAudio (AudioClip audio)
	{
		source.clip = audio;
	}

	public AudioClip getAudio ()
	{
		return source.clip;
	}

	public void PlaySource ()
	{
		source.Play ();
	}

	public void StopSource ()
	{
		source.Stop ();
	}

	public bool isStoped ()
	{
		return !source.isPlaying;
	}

	public void looping (bool isloop)
	{
		source.loop = isloop;
	}

}

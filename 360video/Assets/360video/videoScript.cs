using UnityEngine;
using System.Collections;

public class videoScript : MonoBehaviour {
	public bool loop = true;
	public MovieTexture movie;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
		movie.Play ();
		movie.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

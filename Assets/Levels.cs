using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour {

	public string name;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		if(name!="exit") Application.LoadLevel(name);
		else Application.Quit();
	}
}

using UnityEngine;
using System.Collections;

public class show_menu : MonoBehaviour {

	public GameObject f;
	public int num;

	// Use this for initialization
	void Start () {
		f.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		if(num==1)
		{
			f.SetActive(true);
		}
		if(num==-1)
		{
			f.SetActive(false);
		}
	}
}
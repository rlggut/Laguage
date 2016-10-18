using UnityEngine;
using System.Collections;

public class Mains : MonoBehaviour {

	public int num;
	public int max;
	public GameObject m1,m2,m3,m4;

	public int r;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("main_sel", 1);
	}
	
	// Update is called once per frame
	void Update () {
		m1.SetActive (false);m2.SetActive (false);m3.SetActive (false);m4.SetActive (false);
		r=PlayerPrefs.GetInt ("main_sel");
		if (r == 1)	m1.SetActive (true);
		if (r == 2)	m2.SetActive (true);
		if (r == 3)	m3.SetActive (true);
		if (r == 4)	m4.SetActive (true);
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt ("main_sel", (max+PlayerPrefs.GetInt ("main_sel")+num-1)%max+1);
		PlayerPrefs.SetInt ("recreate", 1);
		PlayerPrefs.SetInt ("rpack", 1);
		PlayerPrefs.SetInt ("rrays", 1);
		PlayerPrefs.SetInt ("rmark", 1);
	}
}
using UnityEngine;
using System.Collections;

public class times : MonoBehaviour {

	public int time;
	private int t,r;
	// Use this for initialization
	void Start () {
		time=PlayerPrefs.GetInt ("time");
		t = System.DateTime.Now.Hour * 3600 + System.DateTime.Now.Minute * 60 + System.DateTime.Now.Second;
	}
	
	// Update is called once per frame
	void Update () {
		r = System.DateTime.Now.Hour * 3600 + System.DateTime.Now.Minute * 60 + System.DateTime.Now.Second;
		if ((r - t) == 1) {
			PlayerPrefs.SetInt("time",time);
				time--;
			t=r;
		}
	}
}
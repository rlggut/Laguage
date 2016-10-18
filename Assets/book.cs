using UnityEngine;
using System.Collections;

public class book : MonoBehaviour {
	public GameObject page;
	public int num,way;
	public bool onway;

	private int t;
	// Use this for initialization
	void Start () {
		onway = false;
		t = 0;
		PlayerPrefs.SetInt ("p" + num.ToString (), 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (t > 0) {
			onway=true;
			page.transform.Rotate(0,0,way*9);
			page.transform.position=page.transform.position+new Vector3(0,-way*(6-num)*0.0005f,0);
			t--;
			if(t==0) PlayerPrefs.SetInt ("p" + num.ToString (), 0);
		}
		else onway=false;
	}
	void OnMouseDown()
	{
		if (PlayerPrefs.GetInt ("p" + num.ToString ()) == 0) {
			t=20;
			PlayerPrefs.SetInt ("p" + num.ToString (), 1);
		}
	}
}

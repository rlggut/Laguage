using UnityEngine;
using System.Collections;

public class choose_lvl : MonoBehaviour {

	public int num;
	private int kf,max,pack;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt ("max_level")<=1) PlayerPrefs.SetInt ("max_level",1);
		max=PlayerPrefs.GetInt ("max_level");

		kf = 60;
		pack = 1;
		PlayerPrefs.SetInt ("level", max);

		PlayerPrefs.SetInt ("level_packs", pack);
		PlayerPrefs.GetInt ("time", pack*kf);
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("level") > 3) kf = 60;
		if (PlayerPrefs.GetInt ("level") > 5) kf = 30;
		if (PlayerPrefs.GetInt ("level") > 7) kf = 20;
		if (PlayerPrefs.GetInt ("level") > 10) kf = 10;
		if (PlayerPrefs.GetInt ("level") > 15) kf = 8;


		if (PlayerPrefs.GetInt ("level") > 2) pack = 2;
		if (PlayerPrefs.GetInt ("level") > 4) pack = 3;
		if (PlayerPrefs.GetInt ("level") > 6) pack = 5;
		if (PlayerPrefs.GetInt ("level") > 9) pack = 7;
		if (PlayerPrefs.GetInt ("level") > 14) pack = 10;
		if (PlayerPrefs.GetInt ("level") > 18) pack = 10+(PlayerPrefs.GetInt ("level")-14);


		PlayerPrefs.SetInt ("level_packs", pack);
		PlayerPrefs.SetInt ("time", pack*kf);
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt ("level", (PlayerPrefs.GetInt ("level")-1+num+max)%max+1);
	}
}
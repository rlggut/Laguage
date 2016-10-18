using UnityEngine;
using System.Collections;

public class history_choose : MonoBehaviour {

	public GameObject Ends, Retry;
	public int num;
	public int turn,bads,goods;
	private int t;

	// Use this for initialization
	void Start () {
		Ends.SetActive (false);
		Retry.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("packs") == 0) {
			if(PlayerPrefs.GetInt ("level")==PlayerPrefs.GetInt ("max_level")) PlayerPrefs.SetInt ("max_level",PlayerPrefs.GetInt ("level")+1);
			Ends.SetActive(true);
		}
	}
	void OnMouseDown()
	{
		if (((num == -1) && (PlayerPrefs.GetInt ("OK") == 0)) || ((num == 1) && (PlayerPrefs.GetInt ("OK") == 1))) {
			PlayerPrefs.SetInt ("recreate", 1);
			PlayerPrefs.SetInt ("rpack", 1);
			PlayerPrefs.SetInt ("rmark",1);
			PlayerPrefs.SetInt ("packs", PlayerPrefs.GetInt ("packs") - 1);
			if(PlayerPrefs.GetInt ("level")>5) PlayerPrefs.SetInt ("rrays", 1);
		} else {
			Retry.SetActive(true);
		}
	}
}

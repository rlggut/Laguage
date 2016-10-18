using UnityEngine;
using System.Collections;

public class Choose : MonoBehaviour {

	public int num;
	public int turn,bads,goods;
	private int t;
	// Use this for initialization
	void Start () {
/*		t = 0;
		turn = 0;
		bads = 0;
		goods = 0;
		PlayerPrefs.SetInt ("max_packs", 0);
*/	}
	
	// Update is called once per frame
	void Update () {
/*		if ((t==0)&&(num == 1))
		{
			t=2;
			turn++;
			if(PlayerPrefs.GetInt ("OK") == 1)
			{
				goods++;
				PlayerPrefs.SetInt ("recreate", 1);
				PlayerPrefs.SetInt ("rpack", 1);
				PlayerPrefs.SetInt ("rrays", 1);
				PlayerPrefs.SetInt ("rmark", 1);
				PlayerPrefs.SetInt ("packs", PlayerPrefs.GetInt ("packs") + 1);
				if(PlayerPrefs.GetInt ("max_packs")<PlayerPrefs.GetInt ("packs")) PlayerPrefs.SetInt ("max_packs", PlayerPrefs.GetInt ("packs"));
			}
			else
			{
				bads++;
				PlayerPrefs.SetInt ("recreate", 1);
				PlayerPrefs.SetInt ("rpack", 1);
				PlayerPrefs.SetInt ("rrays", 1);
				PlayerPrefs.SetInt ("rmark", 1);
				PlayerPrefs.SetInt ("packs", 0);
			}
		}
		if (t > 0)
			t--;
*/
	}
	void OnMouseDown()
	{
		if (((num == -1) && (PlayerPrefs.GetInt ("OK") == 0)) || ((num == 1) && (PlayerPrefs.GetInt ("OK") == 1))) {
			PlayerPrefs.SetInt ("recreate", 1);
			PlayerPrefs.SetInt ("rpack", 1);
			PlayerPrefs.SetInt ("rrays", 1);
			PlayerPrefs.SetInt ("rmark", 1);
			PlayerPrefs.SetInt ("packs", PlayerPrefs.GetInt ("packs") + 1);
			if(PlayerPrefs.GetInt ("max_packs")<PlayerPrefs.GetInt ("packs")) PlayerPrefs.SetInt ("max_packs", PlayerPrefs.GetInt ("packs"));
		} else {
			PlayerPrefs.SetInt ("recreate", 1);
			PlayerPrefs.SetInt ("rpack", 1);
			PlayerPrefs.SetInt ("rrays", 1);
			PlayerPrefs.SetInt ("rmark", 1);
			PlayerPrefs.SetInt ("packs", 0);
		}
	}
}
using UnityEngine;
using System.Collections;

public class Marks : MonoBehaviour {
	public GameObject m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12;
	private int r,num;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt ("rmark")==1)
		{
			num = Random.Range (1, 4);
			PlayerPrefs.SetInt ("marks", 0);
			PlayerPrefs.SetInt ("vent", 0);
			PlayerPrefs.SetInt ("hazar", 0);
			PlayerPrefs.SetInt ("vip", 0);
			m1.SetActive (false);m2.SetActive (false);m3.SetActive (false);m4.SetActive (false);m5.SetActive (false);
			m6.SetActive (false);m7.SetActive (false);m8.SetActive (false);m9.SetActive (false);m10.SetActive (false);
			m11.SetActive (false);m12.SetActive (false);
			while(num>0)
			{
				num--;
				r = Random.Range (0, 42);
				if(r==0)
				{
					m1.SetActive(true);
					PlayerPrefs.SetInt ("hazar",PlayerPrefs.GetInt ("hazar")+1);
				}
				if(r==1)
				{
					m2.SetActive(true);
					PlayerPrefs.SetInt ("vip",PlayerPrefs.GetInt ("vip")+1);
				}
				if(r==2)
				{
					PlayerPrefs.SetInt ("vent",PlayerPrefs.GetInt ("vent")+1);
					m3.SetActive(true);
				}
				if(r==3)
				{
					PlayerPrefs.SetInt ("vent",PlayerPrefs.GetInt ("vent")+1);
					m4.SetActive(true);
				}
				if(r==4)
				{
					m5.SetActive(true);
					PlayerPrefs.SetInt ("hazar",PlayerPrefs.GetInt ("hazar")+1);
				}
				if(r==5)
				{
					m6.SetActive(true);
					PlayerPrefs.SetInt ("vip",PlayerPrefs.GetInt ("vip")+1);
				}
				if(r==6)
				{
					PlayerPrefs.SetInt ("vent",PlayerPrefs.GetInt ("vent")+1);
					m7.SetActive(true);
				}
				if(r==7)
				{
					m8.SetActive(true);
					PlayerPrefs.SetInt ("hazar",PlayerPrefs.GetInt ("hazar")+1);
				}
				if(r==8)
				{
					m9.SetActive(true);
					PlayerPrefs.SetInt ("vip",PlayerPrefs.GetInt ("vip")+1);
				}
				if(r==9)
				{
					PlayerPrefs.SetInt ("vent",PlayerPrefs.GetInt ("vent")+1);
					m10.SetActive(true);
				}
				if(r==10)
				{
					m11.SetActive(true);
					PlayerPrefs.SetInt ("vip",PlayerPrefs.GetInt ("vip")+1);
				}
				if(r==11)
				{
					PlayerPrefs.SetInt ("vent",PlayerPrefs.GetInt ("vent")+1);
					m12.SetActive(true);
				}
			}
			PlayerPrefs.SetInt ("rmark",0);
		}		
	}
}
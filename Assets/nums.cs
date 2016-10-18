using UnityEngine;
using System.Collections;

public class nums : MonoBehaviour {

	public string name;
	public bool isFloat;
	public int dec;
	public GameObject n0,n1,n2,n3,n4,n5,n6,n7,n8,n9;
	private int i,r;
	private float h;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		n0.SetActive (false);n1.SetActive (false);n2.SetActive (false);n3.SetActive (false);n4.SetActive (false);
		n5.SetActive (false);n6.SetActive (false);n7.SetActive (false);n8.SetActive (false);n9.SetActive (false);
		if (!isFloat) {
			r = PlayerPrefs.GetInt (name);
		} else {
			if(dec>=0)
			{
				h=PlayerPrefs.GetFloat (name);
				r=Mathf.FloorToInt(h);
			}
			else
			{
				r=Mathf.FloorToInt(h*10);
				dec=0;
			}
		}
		i=0;
		while(i<dec)
		{
			i++;
			r=(r-r%10)/10;
		}
		r=r%10;
		if(r==0) n0.SetActive(true);
		if(r==1) n1.SetActive(true);
		if(r==2) n2.SetActive(true);
		if(r==3) n3.SetActive(true);
		if(r==4) n4.SetActive(true);
		if(r==5) n5.SetActive(true);
		if(r==6) n6.SetActive(true);
		if(r==7) n7.SetActive(true);
		if(r==8) n8.SetActive(true);
		if(r==9) n9.SetActive(true);
	}
}
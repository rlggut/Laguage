using UnityEngine;
using System.Collections;

public class package_cr : MonoBehaviour {
	public GameObject p11,p12,p21,p22,p31,p32,p41,p42,p51,p52,p61,p62,p71,p72;
	private int r;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt ("rpack")==1)
		{
			p11.SetActive (false);p12.SetActive (false);
			p21.SetActive (false);p22.SetActive (false);
			p31.SetActive (false);p32.SetActive (false);
			p41.SetActive (false);p42.SetActive (false);
			p51.SetActive (false);p52.SetActive (false);
			p61.SetActive (false);p62.SetActive (false);
			p71.SetActive (false);p72.SetActive (false);
			
			r = Random.Range (0, 7);
			if(r<4) PlayerPrefs.SetInt("package_sp",0);
			else PlayerPrefs.SetInt("package_sp",1);
			
			if(r==0){p11.SetActive (true);p12.SetActive (true);}
			if(r==1){p21.SetActive (true);p22.SetActive (true);}
			if(r==2){p31.SetActive (true);p32.SetActive (true);}
			if(r==3){p41.SetActive (true);p42.SetActive (true);}
			if(r==4){p51.SetActive (true);p52.SetActive (true);}
			if(r==5){p61.SetActive (true);p62.SetActive (true);}
			if(r==6){p71.SetActive (true);p72.SetActive (true);}
			PlayerPrefs.SetInt ("rpack",0);
		}	
	}
}
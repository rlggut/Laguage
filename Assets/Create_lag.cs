using UnityEngine;
using System.Collections;

public class Create_lag : MonoBehaviour {

	public bool OK;
	public GameObject co1,co2,co3,co4,co5,co6,co7,co8,co9;
	private int r;
	public int weidth;
	public bool animals,technical,other;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("packs",0);
		PlayerPrefs.SetInt ("recreate",1);
		PlayerPrefs.SetInt ("rpack",1);
		PlayerPrefs.SetInt ("rrays",1);
		PlayerPrefs.SetInt ("rmark",1);
	}

	// Update is called once per frame
	//правила
	void Update () {
		if (PlayerPrefs.GetInt ("recreate") == 1) {
			animals = false;technical = false;other = false;
			OK = true;
			r = Random.Range (0, 30);
			co1.SetActive (false);co2.SetActive (false);co3.SetActive (false);co4.SetActive (false);
			co5.SetActive (false);co6.SetActive (false);co7.SetActive (false);co8.SetActive (false);co9.SetActive (false);
			if (r == 0) {
				co1.SetActive (true);
				PlayerPrefs.SetString ("cont","CA");
			}
			if (r == 1) {
				co2.SetActive (true);
				PlayerPrefs.SetString ("cont","CH");
			}
			if (r == 2) {
				co3.SetActive (true);
				PlayerPrefs.SetString ("cont","DO");
			}
			if (r == 3) {
				co4.SetActive (true);
				PlayerPrefs.SetString ("cont","MO");
			}
			if (r == 4) {
				co5.SetActive (true);
				PlayerPrefs.SetString ("cont","RA");
			}
			if (r <= 4)	animals = true;
			
			if (r == 5) {
				co6.SetActive (true);
				PlayerPrefs.SetString ("cont","LI");
			}
			if (r == 6) {
				co7.SetActive (true);
				PlayerPrefs.SetString ("cont", "VI");
			}
			if (r == 7) {
				co8.SetActive (true);
				PlayerPrefs.SetString ("cont", "PH");
			}
			if ((r > 4) && (r <= 7)) technical = true;
			
			if (r >= 8) {
				co9.SetActive (true);
				other = true;
				PlayerPrefs.SetString ("cont","OT");
			}
			PlayerPrefs.SetFloat ("weidth",Random.Range(80,270)/10.0f);
			PlayerPrefs.SetInt ("recreate",0);
		}
		OK = true;


		//допустимый вес для страны
		if ((PlayerPrefs.GetFloat ("weidth") > PlayerPrefs.GetInt ("max_weidth"))&&(PlayerPrefs.GetInt ("vip") == 0))
			OK = false;
		//вентилируемость для животных и техники
		if (((PlayerPrefs.GetInt ("package_sp") == 1) && (technical==true)) || ((PlayerPrefs.GetInt ("package_sp") == 0) && (animals == true)))
			OK = false;

		if ((PlayerPrefs.GetInt ("package_sp") == 1) && (PlayerPrefs.GetString ("cont") == "OT") && (PlayerPrefs.GetInt ("vent") == 0))
			OK = false;
		//запрещенные животные
		if(( ((PlayerPrefs.GetString ("cont")=="MO")&&(PlayerPrefs.GetString ("rays")=="IN")) || ((PlayerPrefs.GetString ("cont")=="CH")&&(PlayerPrefs.GetString ("rays")=="UA")) ||
		    ((PlayerPrefs.GetString ("cont")=="RA")&&(PlayerPrefs.GetString ("rays")=="AU")) ) &&(PlayerPrefs.GetInt ("vip") == 0) )
		   OK=false;
		//запрещенная видео съемка
		if((PlayerPrefs.GetString ("cont")=="VI")&&((PlayerPrefs.GetString ("rays")=="US")||(PlayerPrefs.GetString ("rays")=="RU")||
		                                            (PlayerPrefs.GetString ("rays")=="UA")))
			OK=false;
		//запрещена любая съемка и техника к ней
		if((technical==true)&&((PlayerPrefs.GetString ("rays")=="SY")||(PlayerPrefs.GetString ("rays")=="IR")||
		                                            (PlayerPrefs.GetString ("rays")=="IQ")))
			OK=false;
		//марки на вентилируемость
		if ((PlayerPrefs.GetInt ("vent") > 0) && (PlayerPrefs.GetInt ("package_sp") != 1))
			OK = false;
		//марок каждого типа не больше 1
		if ((PlayerPrefs.GetInt ("vent") > 1) || (PlayerPrefs.GetInt ("hazar") > 1) || (PlayerPrefs.GetInt ("vip") > 1) )
			OK = false;
		//пометка на опасные токсины и на вентилируемость
		if ((PlayerPrefs.GetInt ("hazar") > 0) && (PlayerPrefs.GetInt ("package_sp") == 1))
			OK = false;
		//метки только на общих вещах
		if (((PlayerPrefs.GetInt ("vent") > 0) || (PlayerPrefs.GetInt ("hazar") > 0) || (PlayerPrefs.GetInt ("vip") > 0))&&(PlayerPrefs.GetString ("cont")!="OT"))
			OK = false;
		//hazar только в список стран
		if ((PlayerPrefs.GetInt ("pruf_hazar") == 0) && ((PlayerPrefs.GetInt ("hazar") > 0)))
			OK = false;
		
		if(OK) PlayerPrefs.SetInt ("OK", 1);
		else PlayerPrefs.SetInt ("OK", 0);
	}
}
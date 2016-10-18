using UnityEngine;
using System.Collections;

public class Rays_cr : MonoBehaviour {

	public GameObject c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12;
	private int r;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("rrays") == 1) {
			c1.SetActive (false);
			c2.SetActive (false);
			c3.SetActive (false);
			c4.SetActive (false);
			c5.SetActive (false);
			c6.SetActive (false);
			c7.SetActive (false);
			c8.SetActive (false);
			c9.SetActive (false);
			c10.SetActive (false);
			c11.SetActive (false);
			c12.SetActive (false);
			r = Random.Range (0, 12);
			PlayerPrefs.SetInt ("pruf_hazar", 0);
			if (r == 0) {
				PlayerPrefs.SetString ("rays", "IN");
				c1.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 15);
			}
			if (r == 1) {
				PlayerPrefs.SetString ("rays", "RU");
				c2.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 25);
				PlayerPrefs.SetInt ("pruf_hazar", 1);
			}
			if (r == 2) {
				PlayerPrefs.SetString ("rays", "UA");
				c3.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 20);
			}
			if (r == 3) {
				PlayerPrefs.SetString ("rays", "UK");
				c4.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 25);
				PlayerPrefs.SetInt ("pruf_hazar", 1);
			}
			if (r == 4) {
				PlayerPrefs.SetString ("rays", "US");
				c5.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 25);
				PlayerPrefs.SetInt ("pruf_hazar", 1);
			}
			if (r == 5) {
				PlayerPrefs.SetString ("rays", "AU");
				c6.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 23);
			}
			if (r == 6) {
				PlayerPrefs.SetString ("rays", "BY");
				c7.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 25);
			}
			if (r == 7) {
				PlayerPrefs.SetString ("rays", "SY");
				c8.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 20);
			}
			if (r == 8) {
				PlayerPrefs.SetString ("rays", "IR");
				c9.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 20);
			}
			if (r == 9) {
				PlayerPrefs.SetString ("rays", "IQ");
				c10.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 20);
			}
			if (r == 10) {
				PlayerPrefs.SetString ("rays", "SE");
				c11.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 25);
				PlayerPrefs.SetInt ("pruf_hazar", 1);
			}
			if (r == 11) {
				PlayerPrefs.SetString ("rays", "DE");
				c12.SetActive (true);
				PlayerPrefs.SetInt ("max_weidth", 25);
				PlayerPrefs.SetInt ("pruf_hazar", 1);
			}

			r = Random.Range (1013, 9999);
			PlayerPrefs.SetInt ("rays_num", r);
			PlayerPrefs.SetInt ("rrays", 0);
		}	
	}
}
using UnityEngine;
using System.Collections;

public class phones : MonoBehaviour {

	public GameObject ph,ph11,ph12,ph21,ph22,ph31,ph32,intro;

	public int tm;
	public int r;
	// Use this for initialization
	void Start () {
		r = Random.Range (1, 4);
		tm = 600;
	}
	
	// Update is called once per frame
	void Update () {
		if (tm > 0) tm--;
		if(tm==0) Application.LoadLevel("Main");
		if (tm<550 && tm > 450) transform.position = transform.position + new Vector3 (0, 0, 0.025f);
		else
		{
			if (tm == 400)
			{
				ph.SetActive(false);
				if(r == 1) ph11.SetActive(true);
				if(r == 2) ph21.SetActive(true);
				if(r > 2) ph31.SetActive(true);
			}
			if (tm == 300)
			{
				ph11.SetActive(false);
				ph21.SetActive(false);
				ph31.SetActive(false);
				if(r == 1) ph12.SetActive(true);
				if(r == 2) ph22.SetActive(true);
				if(r > 2) ph32.SetActive(true);
			}
			if(tm==200)
			{
				ph12.SetActive(false);
				ph22.SetActive(false);
				ph32.SetActive(false);
				intro.SetActive(true);
			}
		}
	}
}
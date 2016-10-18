using UnityEngine;
using System.Collections;

public class cr_locks : MonoBehaviour {

	public GameObject l11,l12,l21,l22,l31,l32;
	private int r;
	// Use this for initialization
	void Start () {
		r = Random.Range (0, 3);
		l11.SetActive (false);l12.SetActive (false);
		l21.SetActive (false);l22.SetActive (false);
		l31.SetActive (false);l32.SetActive (false);
		if (r == 0) {
			l11.SetActive(true);
			l12.SetActive(true);
		}
		if (r == 1) {
			l21.SetActive(true);
			l22.SetActive(true);
		}
		if (r == 2) {
			l31.SetActive(true);
			l32.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

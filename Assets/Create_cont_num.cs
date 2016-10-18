using UnityEngine;
using System.Collections;

public class Create_cont_num : MonoBehaviour {
	public GameObject n1,n2,n3,n4,n5,n6;
	public int r;
	// Use this for initialization
	void Start () {
		n1.SetActive (false);
		n2.SetActive (false);
		n3.SetActive (false);
		n4.SetActive (false);
		n5.SetActive (false);
		n6.SetActive (false);
		r=Random.Range(0,6);
		if (r == 0) n1.SetActive (true);
		if (r == 1) n2.SetActive (true);
		if (r == 2) n3.SetActive (true);
		if (r == 3) n4.SetActive (true);
		if (r == 4) n5.SetActive (true);
		if (r == 5) n6.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	public int num;
	public GameObject lag;
	private int t;
	private float x,y,z,dx,dy,dz;
	public float X,Y,Z;
	public int sel;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("rot_lag", 0);
		PlayerPrefs.SetInt ("rot_lag_pos", 2);
	}
	
	// Update is called once per frame
	void Update () {

		X = lag.transform.eulerAngles.x;
		Y = lag.transform.eulerAngles.y;
		Z = lag.transform.eulerAngles.z;
		sel = PlayerPrefs.GetInt ("rot_lag_pos");
		if (t > 0) {
			lag.transform.Rotate(-dx,-dy,-dz);
			t--;
			if(t==0)
			{
				PlayerPrefs.SetInt ("rot_lag", 0);
				lag.transform.Rotate(x-lag.transform.eulerAngles.x, y - lag.transform.eulerAngles.y, z - lag.transform.eulerAngles.z);
			}
		}
	}
	void OnMouseDrag()
	{
		lag.transform.Rotate (Input.GetAxis ("Mouse Y")*2, 0, -Input.GetAxis ("Mouse X")*2);
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetInt ("rot_lag") == 0)&&(PlayerPrefs.GetInt ("rot_lag_pos")!=num))
	    {
			PlayerPrefs.SetInt ("rot_lag", 1);
			PlayerPrefs.SetInt ("rot_lag_pos",num);
			if (num == 1) {
				x = -90;
				y = 0;
				z = 0;
			}
			if (num == 2) {
				x = 0;
				y = 0;
				z = 0;
			}
			if (num == 3) {
				x = 0;
				y = 0;
				z = 90;
			}
			if (num == 4) {
				x = 0;
				y = 0;
				z = -90;
			}
			if (num == 5) {
				x = 90;
				y = 0;
				z = 0;
			}
			if (num == 6) {
				x = 180;
				y = 0;
				z = 0;
			}
			t = 1;
			dx = (lag.transform.eulerAngles.x - x);
			dy = (lag.transform.eulerAngles.y - y);
			dz = (lag.transform.eulerAngles.z - z);
		}
	}
}
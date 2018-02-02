using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            rotate();
        }
    }

    private void rotate()
    {
        double self = transform.localEulerAngles.y;
        double target = (Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * 180 / Mathf.PI + 360) % 360;

        double temp = target - self;

        if ((temp < 180 && temp >= 0) || temp < -180)
        {
            //Debug.Log(temp);
            transform.Rotate(Vector3.up * Mathf.Min(((float)temp + 360) % 360, Time.deltaTime * 400));
            //transform.Rotate(Vector3.up * Time.deltaTime * 400);
        }
        else
        {
            //Debug.Log(temp);
            transform.Rotate(Vector3.up * Mathf.Max(((float)temp - 360) % 360 , Time.deltaTime * -400));
            //transform.Rotate(Vector3.up * Time.deltaTime * -400);
        }
    }



}

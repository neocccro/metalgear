using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

    [SerializeField]
    private Transform Player;
    private Vector3 target;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        target = new Vector3(0, Player.transform.position.y, Player.transform.position.z);
        transform.LookAt(target);
        //transform.eulerAngles = new Vector3(transform.eulerAngles.x - 0.3f, 0, 0);
	}
}

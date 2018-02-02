using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    [SerializeField]
    GameObject player;
	// Use this for initialization
	void Start()
    {

	}
	
	// Update is called once per frame
	void Update()
    {
        FollowPlayer();
	}

    private void FollowPlayer()
    {
        this.transform.position = player.transform.position;
    }
}

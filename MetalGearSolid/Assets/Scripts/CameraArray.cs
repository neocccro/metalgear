using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArray : MonoBehaviour {
    
    [SerializeField]
    private Camera[] cameras;
    [SerializeField]
    private Transform[] boxes;
    [SerializeField]
    private Transform player;


    // Use this for initialization
    void Start()
    {
        Vector3 temp2 = new Vector3(0, 0, 0);
        for (var i = 0; i < boxes.Length / 2; i++)
        {
            temp2 = new Vector3(0, 0, 0);
            if (boxes[i * 2].transform.position.x > boxes[i * 2 + 1].transform.position.x)
            {
                temp2 += new Vector3(boxes[i * 2].transform.position.x - boxes[i * 2 + 1].transform.position.x, 0, 0);
            }
            if (boxes[i * 2].transform.position.y > boxes[i * 2 + 1].transform.position.y)
            {
                temp2 += new Vector3(0, boxes[i * 2].transform.position.y - boxes[i * 2 + 1].transform.position.y, 0);
            }
            if (boxes[i * 2].transform.position.z > boxes[i * 2 + 1].transform.position.z)
            {
                temp2 += new Vector3(0, 0, boxes[i * 2].transform.position.z - boxes[i * 2 + 1].transform.position.z);
            }
            boxes[i * 2].transform.position -= temp2;
            boxes[i * 2 + 1].transform.position += temp2;
        }
    }
	
	// Update is called once per frame
	void Update()
    {
        for (var i = 0; i < boxes.Length / 2; i++)
        {
            if
            (
                boxes[i * 2] != null &&
                boxes[i * 2 + 1] != null &&
                cameras[i] != null &&
                player.transform.position.x >= boxes[i * 2].transform.position.x &&
                player.transform.position.x <= boxes[i * 2 + 1].transform.position.x &&
                player.transform.position.y >= boxes[i * 2].transform.position.y &&
                player.transform.position.y <= boxes[i * 2 + 1].transform.position.y &&
                player.transform.position.z >= boxes[i * 2].transform.position.z &&
                player.transform.position.z <= boxes[i * 2 + 1].transform.position.z
            )
            {
                AcitvateCamera(i);
            }
        }
    }
    
    private void SetAllFalse()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
    }
    private void AcitvateCamera(int input)
    {
        SetAllFalse();
        cameras[input].gameObject.SetActive(true);
    }
}

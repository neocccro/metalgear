using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarDisapearing : MonoBehaviour {

    [SerializeField]
    private Image healthbar;
    public bool apear;
    public bool disapear;
    public bool pause;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (apear)
        {
            StopAllCoroutines();
            StartCoroutine(Apear());
            apear = !apear;
        }
        if (disapear)
        {
            StopAllCoroutines();
            StartCoroutine(Disapear());
            disapear = !disapear;
        }
        if (pause)
        {
            StopAllCoroutines();
            pause = !pause;
        }
    }

    private IEnumerator Disapear()
    {
        while (healthbar.transform.position.y - healthbar.canvas.pixelRect.height < healthbar.rectTransform.rect.height)
        {
            healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.transform.position.y + 1f, healthbar.transform.position.z);
            yield return 0;
        }
    }

    private IEnumerator Apear()
    {
        while (healthbar.transform.position.y - healthbar.canvas.pixelRect.height > -healthbar.rectTransform.rect.height)
        {
            healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.transform.position.y - 1f, healthbar.transform.position.z);
            yield return 0;
        }
    }
}

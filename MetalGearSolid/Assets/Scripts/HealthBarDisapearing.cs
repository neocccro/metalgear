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
    private float speed = 2f;

	// Update is called once per frame
	void Update () {
        if (apear)
        {
            StopAllCoroutines();
            StartCoroutine(Apear(speed));
            apear = !apear;
        }
        if (disapear)
        {
            StopAllCoroutines();
            StartCoroutine(Disapear(speed));
            disapear = !disapear;
        }
        if (pause)
        {
            StopAllCoroutines();
            pause = !pause;
        }
    }

    private IEnumerator Disapear(float acceleration)
    {
        while (healthbar.transform.position.y - healthbar.canvas.pixelRect.height < healthbar.rectTransform.rect.height)
        {
            healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.transform.position.y + acceleration, healthbar.transform.position.z);
            yield return 0;
        }
    }

    private IEnumerator Apear(float acceleration)
    {
        while (healthbar.transform.position.y - healthbar.canvas.pixelRect.height > -healthbar.rectTransform.rect.height)
        {
            healthbar.transform.position = new Vector3(healthbar.transform.position.x, healthbar.transform.position.y - acceleration, healthbar.transform.position.z);
            yield return 0;
        }
    }
}

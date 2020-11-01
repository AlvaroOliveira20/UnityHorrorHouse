using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
	public float timeLeft = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
    	int r = Random.Range(1, 5);
    	if (r == 1)
        	transform.Find("load1").gameObject.SetActive(true);
        if (r == 2)
        	transform.Find("load2").gameObject.SetActive(true);
        if (r == 3)
        	transform.Find("load3").gameObject.SetActive(true);
        if (r == 4)
        	transform.Find("load4").gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    	timeLeft -= Time.deltaTime;
    	if(timeLeft < 00) {	
        	UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
}

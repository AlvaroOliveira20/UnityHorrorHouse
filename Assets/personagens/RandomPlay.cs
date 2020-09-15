using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlay : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
    	int r = Random.Range(1, 3);
		if (r == 1){
    		transform.Find("amnesia").gameObject.SetActive(false);
    	} else if (r == 2){
         	transform.Find("hill").gameObject.SetActive(false);
    	}
    	
    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}

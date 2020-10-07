using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public bool ok = false;
	public float detectionRange;
	public Transform hill;
	public Transform amnesia;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange){
    		gameObject.SetActive(false);
    		ok = true;
    	}
    	if( Vector3.Distance( hill.position, transform.position) <= detectionRange){
    		gameObject.SetActive(false);
    		ok = true;
    	}

    	
    }
}

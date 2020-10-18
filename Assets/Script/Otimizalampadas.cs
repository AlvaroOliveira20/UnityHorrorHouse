using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otimizalampadas : MonoBehaviour
{
	public float _proximity = 0;
    private float detectionRange = 40;
    public Transform amnesia;
 	public Transform hill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if( Vector3.Distance(amnesia.position, transform.position) <= detectionRange || Vector3.Distance(hill.position, transform.position) <= detectionRange){
    		transform.Find("lightf").gameObject.SetActive(true);
 		}
 		else if(Vector3.Distance(amnesia.position, transform.position) > detectionRange || Vector3.Distance(hill.position, transform.position) > detectionRange){
            	transform.Find("lightf").gameObject.SetActive(false);
           }
        
    }
}

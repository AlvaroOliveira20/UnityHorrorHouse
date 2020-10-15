using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximidadeLampada : MonoBehaviour
{
	public float timeLeft;
	public int state = 1;
	public int i;
	public float _proximity = 0;
    public float detectionRange;
    public Transform amnesia;
 	public Transform hill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	if( Vector3.Distance(amnesia.position, transform.position) <= detectionRange ){
    		timeLeft -= Time.deltaTime;
            transform.Find("Spotlightf").gameObject.SetActive(false);
            if(timeLeft < 0){
            	transform.Find("corpo").gameObject.SetActive(true);
            	transform.Find("Spotlightf").gameObject.SetActive(true);
            }
 		}
 		if( Vector3.Distance(hill.position, transform.position) <= detectionRange ){
    		timeLeft -= Time.deltaTime;
            transform.Find("Spotlightf").gameObject.SetActive(false);
            if(timeLeft < 0){
            	transform.Find("corpo").gameObject.SetActive(true);
            	transform.Find("Spotlightf").gameObject.SetActive(true);
            }
 		}
    }
}

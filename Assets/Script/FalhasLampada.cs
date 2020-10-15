using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalhasLampada : MonoBehaviour
{
	public float timeLeft = 0.05f;
	public int state = 1;
	public int i;
	public Material lamps_emit;
	// public float _proximity = 0;
 //    public float detectionRange;
  //   public Transform amnesia;
 	// public Transform hill;
    // Start is called before the first frame update
    void Start()
    {
    	
        
    }

    // Update is called once per frame
    void Update()
    {
    	//if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange ){
 			
 		float r = Random.Range(0.01f, 0.5f);
    	timeLeft -= Time.deltaTime;
 		if(timeLeft < 0 && state == 0) {	
            transform.Find("Spotlightf").gameObject.SetActive(true);
            //lamps_emit.SetColor("_EmissionColor", Color.white);
            state = 1;
            timeLeft = r;
        }
        if( timeLeft < 0 && state == 1) {	
            transform.Find("Spotlightf").gameObject.SetActive(false);
            //lamps_emit.SetColor("_EmissionColor", Color.black);
            state = 0;
            timeLeft = r;  
        }
 			
 		//}

    	
    }
}

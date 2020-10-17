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
    	// lamps_emit = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
    	//if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange ){
 			
 		float r = Random.Range(0.01f, 0.4f);
    	timeLeft -= Time.deltaTime;
 		if(timeLeft < 0 && state == 0) {	
            transform.Find("Spotlightf").gameObject.SetActive(true);
            lamps_emit.EnableKeyword("_EMISSION");
            state = 1;
            timeLeft = r;
        }
        if( timeLeft < 0 && state == 1) {	
            transform.Find("Spotlightf").gameObject.SetActive(false);
            lamps_emit.DisableKeyword("_EMISSION");
            state = 0;
            timeLeft = r;  
        }
 			
 		//}

    	
    }
}

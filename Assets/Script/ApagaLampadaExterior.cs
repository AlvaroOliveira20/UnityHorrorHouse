using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ApagaLampadaExterior : MonoBehaviour
{
	public Transform amnesia;
 	public Transform hill;
 	public float detectionRange;
 	public Transform lampada;
 	public Material lamps_emit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if( Vector3.Distance(amnesia.position, transform.position) <= detectionRange || Vector3.Distance(hill.position, transform.position) <= detectionRange ){	
    		lampada.gameObject.SetActive(false);
    		lamps_emit.DisableKeyword("_EMISSION");
    	}
        
    }
}

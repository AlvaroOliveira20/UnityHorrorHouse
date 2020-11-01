using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorRand : MonoBehaviour
{
	public Transform z1;
	public Transform z2;
	public Transform z3;
	public Transform z4;
	public Transform z5;
	public Transform z6;
    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(1, 7);
        if(r==1){
    		z1.gameObject.SetActive(true);
    	}else if(r==2){
    		z2.gameObject.SetActive(true);
    	}else if(r==3){
    		z3.gameObject.SetActive(true);
    	}else if(r==4){
    		z4.gameObject.SetActive(true);
    	}else if(r==5){
    		z5.gameObject.SetActive(true);
    	}else if(r==6){
    		z6.gameObject.SetActive(true);
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

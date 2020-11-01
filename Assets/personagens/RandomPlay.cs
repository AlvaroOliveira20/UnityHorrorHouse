using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlay : MonoBehaviour
{
    public static RandomPlay Instance;
    public Transform hill;
    public Transform amnesia;
    public int r;
	
     void Awake(){
        r = Random.Range(1, 3);
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
    	
		if (r == 1){
            
    		amnesia.gameObject.SetActive(false);
    	} else if (r == 2){
            hill.gameObject.SetActive(false);
    	}
    	
    }
    public int getChar(){
        if (r == 1){
            return 0;
        } else {
            return 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
    	
    }
}

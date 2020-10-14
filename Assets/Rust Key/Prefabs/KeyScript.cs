using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public static KeyScript Instance;
	public float distancia;
	public float detectionRange;
	public Transform hill;
	public Transform amnesia;
	public Transform key;
	public Transform key2;
	public Transform key3;
	public Transform key4;
	public float teste; 
    void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start() {

    	int r = Random.Range(1, 5);
		if (r == 1){
    		transform.Find("key").gameObject.SetActive(true);
            SceneController.Instance.setMapState(1);
    	} else if (r == 2){
         	transform.Find("key2").gameObject.SetActive(true);
         	SceneController.Instance.setMapState(2);
    	}
    	else if (r == 3){
         	transform.Find("key3").gameObject.SetActive(true);
         	SceneController.Instance.setMapState(3);
    	}
    	else if (r == 4){
         	transform.Find("key4").gameObject.SetActive(true);
         	SceneController.Instance.setMapState(4);
    	}

    	
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

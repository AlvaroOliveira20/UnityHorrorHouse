using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static Key Instance;
	public int ok;
	public float detectionRange;
	public Transform hill;
	public Transform hillkey;
	public Transform amnesiakey;
	public Transform amnesia;
	public Transform amnesiaScene1;
	private GameObject _amnesiaPos;
	public Transform porta;

	
    void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange){
    		gameObject.SetActive(false);
    		amnesiakey.gameObject.SetActive(true);
    		ok = 1;
            SceneController.Instance.setShow(0);
            SceneController.Instance.setStatus(1);
    	}
    	if( Vector3.Distance( hill.position, transform.position) <= detectionRange){
    		gameObject.SetActive(false);
    		hillkey.gameObject.SetActive(true);
    		ok = 1;
            SceneController.Instance.setShow(0);
            SceneController.Instance.setStatus(1);
    	}    	
    }
    public int getKey(){
        return ok;
    }
}

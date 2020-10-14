using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static Key Instance;
	public int ok;
	public float detectionRange;
	public Transform hill;
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
   //  	Debug.Log("ok");
    	
   //  	if( Vector3.Distance( amnesiaScene1.position, porta.position) <= detectionRange && ok == 1){
   //  		_amnesiaPos = GameObject.Find("amnesia");
 		// 	_amnesiaPos.transform.position = new Vector3(72f, 0f, 34f);
 		// 	_amnesiaPos.transform.Rotate(0f, 180.0f, 0.0f);
 		// 	transform.Find("Cena1").gameObject.SetActive(false);
 		// 	transform.Find("Cena2").gameObject.SetActive(true);
 		// }
    	if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange){
    		gameObject.SetActive(false);
    		ok = 1;
            SceneController.Instance.setShow(0);
            SceneController.Instance.setStatus(1);
    	}
    	if( Vector3.Distance( hill.position, transform.position) <= detectionRange){
    		gameObject.SetActive(false);
    		ok = 1;
            SceneController.Instance.setShow(0);
            SceneController.Instance.setStatus(1);
    	}    	
    }
    public int getKey(){
        return ok;
    }
}

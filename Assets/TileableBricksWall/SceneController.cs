using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
	private GameObject _hillPos;
	private GameObject _hill2Pos;
	private GameObject _amnesiaPos;

    // Start is called before the first frame update
    void Start()
    {
        
       
        
    }
    public float detectionRange;
    public Transform amnesiaScene1;
 	public Transform hillScene1;
 	public Transform hillScene2;
 	


    // Update is called once per frame
    void Update()
    {

    	if( Vector3.Distance( amnesiaScene1.position, transform.position) <= detectionRange){
    		_amnesiaPos = GameObject.Find("amnesia");
 			_amnesiaPos.transform.position = new Vector3(72f, 0f, 34f);
 			_amnesiaPos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(false);
 			transform.Find("Cena2").gameObject.SetActive(true);
 		}
 		if( Vector3.Distance( hillScene1.position, transform.position) <= detectionRange){
 			_hillPos = GameObject.Find("hill");
 			_hillPos.transform.position = new Vector3(72f, 0f, 34f);
 			_hillPos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(false);
 			transform.Find("Cena2").gameObject.SetActive(true);
 		}
 		if( Vector3.Distance( hillScene2.position, transform.position) <= detectionRange){
 			_hill2Pos = GameObject.Find("hill2");
 			_hill2Pos.transform.position = new Vector3(79f, 0f, 34f);
 			_hill2Pos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(true);
 			transform.Find("Cena2").gameObject.SetActive(false);
 		}

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winscript : MonoBehaviour
{
	public Transform hill;
 	public Transform amnesia;
 	public float detectionRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Vector3.Distance( amnesia.position, transform.position) <= detectionRange || Vector3.Distance( hill.position, transform.position) <= detectionRange){
    		UnityEngine.SceneManagement.SceneManager.LoadScene("EndGameWin");
    	}
    }
}

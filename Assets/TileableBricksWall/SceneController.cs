using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SceneController : MonoBehaviour
{
    public static SceneController Instance;
	private GameObject _hillPos;
	private GameObject _hill2Pos;
	private GameObject _amnesiaPos;
	// private GameObject _amnesia2Pos;

    void Awake(){
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float detectionRange;
    public Transform amnesiaScene1;
    public Transform amnesiaScene2;
     public Transform amnesiaR;
      public Transform hillR;
      public Transform locked;
 	public Transform hillScene1;
 	public Transform hillScene2;
    public int Show = 0;
    public int piscar = 1;
    public int ShowStatus = 0;
    public int MinimapStatus = 0;
    public Texture2D minimap;
    public Texture2D minimapk1;
    public Texture2D minimapk2;
    public Texture2D minimapk3;
    public Texture2D minimapk4;
    public Texture2D minimapFinal;
    public Texture2D minimapFinal2;
    

    // Update is called once per frame
    void OnGUI() {

        if(Key.Instance.getKey() == 0 && Show == 0)
            GUI.Label(new Rect(10, 10, 250, 250), minimap);
        if(MinimapStatus == 1 && Show == 1)
            GUI.Label(new Rect(10, 10, 250, 250), minimapk1);
        if(MinimapStatus == 2 && Show == 1)
            GUI.Label(new Rect(10, 10, 250, 250), minimapk2);
        if(MinimapStatus == 3 && Show == 1)
            GUI.Label(new Rect(10, 10, 250, 250), minimapk3);
        if(MinimapStatus == 4 && Show == 1)
            GUI.Label(new Rect(10, 10, 250, 250), minimapk4);
        if(ShowStatus == 1){
            GUI.Label(new Rect(10, 10, 250, 250), minimapFinal);
        }
        if(Show == 1)
            GUI.Label(new Rect(10, 260, 1000, 20), "Encontre a chave para abrir.");
        if(ShowStatus == 1)
            GUI.Label(new Rect(10, 260, 1000, 20), "Você encontrou a chave!");

    }

    public void setShow(int Param){
        Show = Param;
    }

    public void setMapState(int Param){
        MinimapStatus = Param;
    }

    public void setStatus(int Param){
        ShowStatus = Param;
    }
    void Update()
    {
        if( Vector3.Distance( amnesiaScene1.position, transform.position) <= detectionRange && Key.Instance.getKey() == 0 || Vector3.Distance( hillScene1.position, transform.position) <= detectionRange && Key.Instance.getKey() == 0){
            Show = 1;
            locked.gameObject.SetActive(true);
        }

    	if( Vector3.Distance( amnesiaScene1.position, transform.position) <= detectionRange && Key.Instance.getKey() == 1){
    		_amnesiaPos = GameObject.Find("amnesia");
 			_amnesiaPos.transform.position = new Vector3(72f, 0f, 34f);
 			_amnesiaPos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(false);
 			transform.Find("Cena2").gameObject.SetActive(true);
            hillScene2.gameObject.SetActive(false);
            amnesiaR.gameObject.SetActive(false);
            ShowStatus = 0;
            MinimapStatus = 5;
 		}
 		if( Vector3.Distance( hillScene1.position, transform.position) <= detectionRange && Key.Instance.getKey() == 1){
 			_hillPos = GameObject.Find("hill");
 			_hillPos.transform.position = new Vector3(72f, 0f, 34f);
 			_hillPos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(false);
 			transform.Find("Cena2").gameObject.SetActive(true);
            amnesiaScene2.gameObject.SetActive(false);
            hillR.gameObject.SetActive(false);
            ShowStatus = 0;
            MinimapStatus = 5;
 		}
 		if( Vector3.Distance( hillScene2.position, transform.position) <= detectionRange && Key.Instance.getKey() == 1){
 			_hill2Pos = GameObject.Find("hill2");
 			_hill2Pos.transform.position = new Vector3(79f, 0f, 34f);
 			_hill2Pos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(true);
 			transform.Find("Cena2").gameObject.SetActive(false);
            ShowStatus = 0;
            MinimapStatus = 5;
 		}
 		if( Vector3.Distance( amnesiaScene2.position, transform.position) <= detectionRange && Key.Instance.getKey() == 1){
 			_hill2Pos = GameObject.Find("amnesia2");
 			_hill2Pos.transform.position = new Vector3(79f, 0f, 34f);
 			_hill2Pos.transform.Rotate(0f, 180.0f, 0.0f);
 			transform.Find("Cena1").gameObject.SetActive(true);
 			transform.Find("Cena2").gameObject.SetActive(false);
            ShowStatus = 0;
            MinimapStatus = 5;
 		}
    }
    
}

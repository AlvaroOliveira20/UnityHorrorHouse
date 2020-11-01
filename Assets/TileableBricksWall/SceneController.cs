using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SceneController : MonoBehaviour
{
    public static SceneController Instance;
	private GameObject _hillPos;
	private GameObject _hill2Pos;
	private GameObject _amnesiaPos;
    public int r;
	// private GameObject _amnesia2Pos;

    void Awake(){
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(1, 4);
    }
    public float detectionRange;
    public Transform amnesiaScene1;
    public Transform amnesiaScene2;
    public Transform amnesiaR;
    public Transform hillR;
    public Transform amnesiaR2;
    public Transform hillR2;
    public Transform amnesiaR3;
    public Transform hillR3;
    public Transform locked;
    public Transform notify;
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
    public float timeLeft;
    public Transform zombie1;
    public Transform zombie2;
    public Transform zombie3;
    public int charInterior;
    

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
            GUI.Label(new Rect(10, 260, 1000, 20), "Encontre a chave para abrir." );
        if(ShowStatus == 1){
            notify.gameObject.SetActive(true);
            GUI.Label(new Rect(10, 260, 1000, 20), "Você encontrou a chave!");
        }
        if (RandomPlay.Instance.getChar() == 0){
            GUI.Label(new Rect(Screen.width - 330, Screen.height - 70, 1000, 20), "Tempo até a Amnesia ser assassinada pelo alien: "+ Mathf.RoundToInt(timeLeft));
        }else if (RandomPlay.Instance.getChar() == 1){
            GUI.Label(new Rect(Screen.width - 300, Screen.height - 70, 1000, 20), "Tempo até o Hill ser assassinado pelo alien: " + Mathf.RoundToInt(timeLeft));
        }
    }

    public void setShow(int Param){
        Show = Param;
    }
    public int getCharInterior(){
        return charInterior;
    }

    public void setMapState(int Param){
        MinimapStatus = Param;
    }

    public void setStatus(int Param){
        ShowStatus = Param;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0){
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndGameDeath");
        }
        if (Input.GetKey(KeyCode.Escape)){
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        

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
            charInterior = 0;
            if (r == 1){
                zombie2.gameObject.SetActive(true);
                zombie3.gameObject.SetActive(true);
                hillR.gameObject.SetActive(true);
            }else if (r == 2){
                zombie2.gameObject.SetActive(true);
                zombie1.gameObject.SetActive(true);
                hillR2.gameObject.SetActive(true);
            }else if (r == 3){
                zombie3.gameObject.SetActive(true);
                zombie1.gameObject.SetActive(true);
                hillR3.gameObject.SetActive(true);
            }
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
            charInterior = 1;
            if (r == 1){
                zombie2.gameObject.SetActive(true);
                zombie3.gameObject.SetActive(true);
                amnesiaR.gameObject.SetActive(true);
            }else if (r == 2){
                zombie2.gameObject.SetActive(true);
                zombie1.gameObject.SetActive(true);
                amnesiaR2.gameObject.SetActive(true);
            }else if (r == 3){
                zombie3.gameObject.SetActive(true);
                zombie1.gameObject.SetActive(true);
                amnesiaR3.gameObject.SetActive(true);
            }
            
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

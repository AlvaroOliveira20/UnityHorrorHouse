using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWalk : MonoBehaviour
{
    public float _rodar = 100;
    private Animator _animator;
    private float _andar = 0;
    private float _pular = 0;
    private float _direcao = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _andar = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift) && _andar > 0){
            _andar += 1;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && _andar > 0){
            _andar = 1;
        }
        if (Input.GetKey(KeyCode.Space)){
            _pular -= 1;
        }
        if (Input.GetKeyUp(KeyCode.Space)){
            _pular = 0;
        }


        if (Input.GetKey(KeyCode.D)){
            _direcao += 1;
        }
        if (Input.GetKeyUp(KeyCode.D)){
            _direcao = 0;
        }
        if (Input.GetKey(KeyCode.A)){
            _direcao -= 1;
        }
        if (Input.GetKeyUp(KeyCode.A)){
            _direcao = 0;
        }


        // if (transform.position.y > 0){
        //  transform.position += Vector3.down * Time.deltaTime;
        // }

        _animator.SetFloat("Andar", _andar);
        _animator.SetFloat("Pular", _pular);
        _animator.SetFloat("Direcao", _direcao);
        
        this.transform.Rotate(0, (Input.GetAxis("Horizontal")* _rodar) * Time.deltaTime, 0);
    }
}

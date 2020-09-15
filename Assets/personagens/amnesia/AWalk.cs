using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWalk : MonoBehaviour
{
    public float _rodar = 100;
    private Animator _animator;
    private float _andar = 0;
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
        

        _animator.SetFloat("Andar", _andar);

        this.transform.Rotate(0, (Input.GetAxis("Horizontal")* _rodar) * Time.deltaTime, 0);
    }
}

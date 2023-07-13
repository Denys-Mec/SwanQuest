using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SleepingBagAnim : MonoBehaviour
{

    // private Animator _anim;


    [SerializeField]
    public UnityEvent onClick;

    // public void Start()
    // {
	//     _anim = GetComponent<Animator>();
    // }



    private void OnMouseDown()
    {
        onClick.Invoke();
        // this.Interaction();
        // Debug.Log("Ok");
    }

}

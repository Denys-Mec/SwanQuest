using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SleepingBagAnim : MonoBehaviour, IPointerDownHandler
{

    // private Animator _anim;
    private bool flag = false;

    // public void Start()
    // {
	//     _anim = GetComponent<Animator>();
    // }

    public void Interaction()
    {
        flag = !flag;
        GetComponent<Animator>().SetBool("open", flag);
        GetComponent<Animator>().SetBool("close", !flag);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
	   this.Interaction();
    }
}

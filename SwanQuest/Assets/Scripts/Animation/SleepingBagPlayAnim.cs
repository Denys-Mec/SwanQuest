using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SleepingBagPlayAnim : MonoBehaviour
{
    private bool flag = false;

    public void Interaction()
    {
        flag = !flag;
        GetComponent<Animator>().SetBool("open", flag);
        GetComponent<Animator>().SetBool("close", !flag);
    }
}


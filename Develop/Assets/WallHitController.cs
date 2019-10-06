using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHitController : MonoBehaviour
{

    [SerializeField]
    private PlayerController pControll;

    private void OnTriggerExit(Collider other)
    {

        if(other.gameObject.tag == "Wall")
        {
            pControll.TriggerEvent(true);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            pControll.TriggerEvent(false);
        }
    }
}

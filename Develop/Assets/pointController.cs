using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointController : MonoBehaviour
{
    // Start is called before the first frame update
    Coordinates co;
    private void Start()
    {
        co = Coordinates.Instance;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if((co.index+1)< co.points.Count)
            {
                co.index++;
            }
        }
    }
}



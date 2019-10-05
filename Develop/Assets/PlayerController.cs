using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int index;
    Vector3 toGo;
    Coordinates co;
    bool startPressed;
    // Start is called before the first frame update
    void Start()
    {
        co = Coordinates.Instance;
        startPressed = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(!Coordinates.Instance.isEmpty())
        {

            if (startPressed)
            {
                toGo = co.points[co.index];
                this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, toGo, 0.1f);
              
            }


           
        }

    }

    public void StartClicked()
    {
        startPressed = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool startLerp;
    public GameObject destination;

    private void Start()
    {
        startLerp = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (startLerp)
        {
            this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, destination.transform.position, 0.03f);
            this.gameObject.transform.rotation = Quaternion.Lerp(this.gameObject.transform.rotation, destination.transform.rotation, 0.03f);
        }


        if(this.gameObject.transform.rotation.y <= 0.0001f)
        {
            Debug.Log(Application.dataPath);
            destination.gameObject.transform.GetChild(0).gameObject.active = true;

            this.gameObject.active = false;

        }

    }


}

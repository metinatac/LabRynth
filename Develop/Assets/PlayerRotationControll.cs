using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationControll : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * 20 * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * 20 * Mathf.Deg2Rad;


       player.transform.RotateAround(Vector3.up, -rotX);
        player.transform.RotateAround(Vector3.right, rotY);

    }
}


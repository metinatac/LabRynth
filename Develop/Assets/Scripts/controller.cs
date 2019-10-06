using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private List<GameObject> allObj;
  
    [SerializeField]
    private GameObject prefab;

 

    [SerializeField]
    private Camera cam;

    private Vector3 prevCamPos;



    private int instanceCounter = 0;
    private GameObject currentObject;


    Vector3 start;
    Vector3 target;
    float duration;


    
    // Start is called before the first frame update
    void Start()
    {
        allObj = new List<GameObject>();
      
        duration = 0.3f;

        
        
    }

    // Update is called once per frame
    void Update()
    {



    }

}

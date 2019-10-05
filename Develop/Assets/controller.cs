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

        /* if (Input.GetMouseButtonDown(0)){
            InstantiateObject();
             instanceCounter++;

         }*/


        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray,out hit))
                   
                if(hit.transform.gameObject.tag == "Ground")
                {
                    Collider[] hitColliders = Physics.OverlapSphere(hit.point, 0.2f,LayerMask.GetMask("pathPoint"));


                    if (hitColliders.Length < 1)
                    {
                       var g = Instantiate(prefab, hit.point, transform.rotation);
                        Coordinates c = Coordinates.Instance;

                        c.points.Add(g.transform.position);
                       

                    }
                }

           
            }





    }



}

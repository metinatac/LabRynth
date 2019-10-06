using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    int index;
    Vector3 toGo;
    Coordinates co;
    bool startPressed;

    public float turnSpeed;

    public float walkSpeed;

    public float camHight;

    public float camDistance;

    [SerializeField]
    private Joystick stickTurn;
    [SerializeField]
    private GameObject WalkStickOb;

    [SerializeField]
    private Joystick stickWalk;

    [SerializeField]
    private GameObject PlayerCam;

    private Rigidbody rb;
    bool movePlayer;
    bool triggerIsOk;


    private Vector3 forward;
    private Vector3 right;


    // Start is called before the first frame update
    void Start()
    {
        forward = this.gameObject.transform.forward;
        right = this.gameObject.transform.right;


        co = Coordinates.Instance;
        startPressed = false;
        movePlayer = false;
        triggerIsOk = true;
        PlayerCam.transform.rotation = this.gameObject.transform.rotation;
   rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
  

     void FixedUpdate()
    {
        if (triggerIsOk)
        {
            rb.velocity = PlayerCam.transform.forward * (stickWalk.Vertical * walkSpeed) * Time.deltaTime +
            PlayerCam.transform.right * (stickWalk.Horizontal * walkSpeed) * Time.deltaTime;


        }
        float Xpos = this.gameObject.transform.position.x;
        float Ypos = this.gameObject.transform.position.y + camHight;
        float Zpos = this.gameObject.transform.position.z;

        PlayerCam.transform.position = new Vector3(Xpos, Ypos, Zpos);

        // turning with Joystick around Y-Axis.
        Vector3 localEuler = this.gameObject.transform.localEulerAngles;
        Vector3 camEuler = PlayerCam.transform.localEulerAngles;
        Vector3 walkEuler = WalkStickOb.transform.localEulerAngles;




        walkEuler.z = stickTurn.Horizontal * turnSpeed;
        localEuler.y += stickTurn.Horizontal * turnSpeed;
        camEuler.y += stickTurn.Horizontal * turnSpeed;
        WalkStickOb.transform.localEulerAngles = walkEuler;
        PlayerCam.transform.localEulerAngles = camEuler;
        this.gameObject.transform.localEulerAngles = localEuler;

    }

    public void StartClicked()
    {
        startPressed = true;
    }

    public void move(bool state)
    {
        movePlayer = state;
    }
    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }


  public void TriggerEvent(bool state)
    {
        triggerIsOk = state;
    }


}

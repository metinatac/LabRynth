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

    bool movePlayer;
    bool triggerIsOk;
    // Start is called before the first frame update
    void Start()
    {
        co = Coordinates.Instance;
        startPressed = false;
        movePlayer = false;
        triggerIsOk = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (movePlayer)
        {
            if (triggerIsOk)
            {
                float moveSpeed = 2.0f;
                this.gameObject.transform.position += this.gameObject.transform.forward * Time.deltaTime * moveSpeed;
            }
          
        }



        if (Input.touchCount == 1)
        {
            if (!IsPointerOverUIObject())
            {
                float rotateSpeed = 0.2f;
                Touch touchZero = Input.GetTouch(0);

                //Rotate the model based on offset
                Vector3 localAngle = this.gameObject.transform.localEulerAngles;
                localAngle.y -= rotateSpeed * touchZero.deltaPosition.x;

                this.gameObject.transform.localEulerAngles = localAngle;
            }

        }
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

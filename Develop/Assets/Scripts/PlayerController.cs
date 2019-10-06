using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int index;
    Vector3 toGo;
    Coordinates co;
    bool startPressed;

    bool movePlayer;
    // Start is called before the first frame update
    void Start()
    {
        co = Coordinates.Instance;
        startPressed = false;
        movePlayer = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (movePlayer)
        {
            float moveSpeed = 2.0f;
            this.gameObject.transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        }



        if (Input.touchCount == 1)
        {
            float rotateSpeed = 3.0f;
            Touch touchZero = Input.GetTouch(0);

            //Rotate the model based on offset
            Vector3 localAngle = this.gameObject.transform.localEulerAngles;
            localAngle.y -= rotateSpeed * touchZero.deltaPosition.x;
            localAngle.x += rotateSpeed * touchZero.deltaPosition.y;

            this.gameObject.transform.localEulerAngles = localAngle;
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

    }

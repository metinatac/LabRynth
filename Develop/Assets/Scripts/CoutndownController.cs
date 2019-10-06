using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoutndownController : MonoBehaviour
{
    // Start is called before the first frame update
    float start;
    float current;

    [SerializeField]
    private MainCamController camera;

    [SerializeField]
    private Text countdownText;
    void Start()
    {
        start = 3.0f;
        current = start;
    }

    // Update is called once per frame
    void Update()
    {
        current -= 1 * Time.deltaTime;
        countdownText.text = current.ToString("0");

        if(current <= 0.0f)
        {
            camera.startLerp = true;
            this.gameObject.active = false;


        }
    }
}

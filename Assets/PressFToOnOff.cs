using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressFToOnOff : MonoBehaviour
{ public GameObject Flashlight;
    public float PowerOnFlashlight;
    public GameObject PhoneFlashlight;
    public GameObject defaltHand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PowerOnFlashlight > 0)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {

                if (Flashlight.activeSelf == true)
                {
                    Flashlight.SetActive(false);
                }
                else if (Flashlight.activeSelf == false)
                {

                    Flashlight.SetActive(true);
                }


                if (PhoneFlashlight.activeSelf == true)
                {
                    PhoneFlashlight.SetActive(false);
                }
                else if (PhoneFlashlight.activeSelf == false)
                {

                    PhoneFlashlight.SetActive(true);
                }

                if (defaltHand.activeSelf == false)
                {
                    defaltHand.SetActive(true);
                }
                else if (defaltHand.activeSelf == true)
                {

                    defaltHand.SetActive(false);
                }


            }
            if (Flashlight.activeSelf == true)
            {
                PowerOnFlashlight -= 1 * Time.deltaTime;

            }
        }
        else
        {
            Flashlight.SetActive(false);
        }

        print(PowerOnFlashlight);

    }
}

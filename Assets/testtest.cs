using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtest : MonoBehaviour
{
    public GameObject Flashlight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print(Flashlight.activeSelf);
            if (Flashlight.activeSelf == true)
            {
                Flashlight.SetActive(false);
            }
            else if (Flashlight.activeSelf == false)
            {

                Flashlight.SetActive(true);
            }


        }
    }
}

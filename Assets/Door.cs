using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int doorID;
    public GameObject TellDoorYes;
    private bool AllowPlayerPressE;
    public Animator DoorMePlease;
    // Start is called before the first frame update
    void Update()
    {
        if (AllowPlayerPressE)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorMePlease.Play("OpenDoor");
            }
        }
    }

    // Update is called once per frame
  
        private void OnTriggerEnter(Collider other)
        {
            //Kresten, lav et tag til din box der skal trigger
            // som hedder "TriggerBox"
            if (other.tag == "Player")
            {
            Inventory playerinventory = other.gameObject.GetComponent<Inventory>();
            for(int i=0;i<playerinventory.InteractKey.Count;i++)
            {
                if(doorID==playerinventory.InteractKey[i])
                {
                    TellDoorYes.SetActive(true);
                    AllowPlayerPressE = true;
                }
            }
            }
        }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TellDoorYes.SetActive(false);
            AllowPlayerPressE = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EToGetKey : MonoBehaviour
   
{ public GameObject Key;
    private bool KeyAllow;
    public GameObject TellKeyYes;
    public GameObject Player;
    public int keyID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyAllow)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Key.SetActive(false);
                TellKeyYes.SetActive(false);
                Player.GetComponent<Inventory>().InteractKey.Add(keyID);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Kresten, lav et tag til din box der skal trigger
        // som hedder "TriggerBox"
        if (other.tag == "Player")
        {
            KeyAllow = true;
            TellKeyYes.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Kresten, lav et tag til din box der skal trigger
        // som hedder "TriggerBox"
        if (other.tag == "Player")
        {
            KeyAllow = false;
            TellKeyYes.SetActive(false); 
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EToGetKey : MonoBehaviour
   
{ public GameObject Key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerStay(Collider other)
    {
        //Kresten, lav et tag til din box der skal trigger
        // som hedder "TriggerBox"
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Key.SetActive(false);
            }
        }
    }
}

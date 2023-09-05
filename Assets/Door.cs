using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int doorID;
    // Start is called before the first frame update
    void Start()
    {
        
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
                    gameObject.SetActive(false);
                }
            }
            }
        }
}

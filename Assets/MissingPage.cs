using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingPage : MonoBehaviour
{
    public GameObject HUD;
    // Start is called before the first frame update
   
    void OnTriggerStay2D(Collider2D col)
    {
        if ((Input.GetAxis("Submit") > 0))
        {
            HUD.GetComponent<HUD>().addMissingPage();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

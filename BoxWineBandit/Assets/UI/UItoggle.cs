using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItoggle : MonoBehaviour
{
    private bool shown;
    
    // Start is called before the first frame update
    void Start()
    {
        shown = false;
        this.gameObject.GetComponent<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (shown)
            {
                this.gameObject.GetComponent<Canvas>().enabled = false;
                shown = false;

            }
            else
            {
                this.gameObject.GetComponent<Canvas>().enabled = true;
                shown = true;

            }
        }
    }
}

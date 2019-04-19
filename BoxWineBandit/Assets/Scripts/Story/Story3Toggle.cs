using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3Toggle : MonoBehaviour
{

    public static bool complete;

    // Start is called before the first frame update
    void Start()
    {

        complete = false;
        this.gameObject.GetComponent<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (TurnBasedCombatStateMachine.storyCount == 3 && !complete)
        {
            this.gameObject.GetComponent<Canvas>().enabled = true;


        }
        else
        {
            this.gameObject.GetComponent<Canvas>().enabled = false;

        }
    }
}

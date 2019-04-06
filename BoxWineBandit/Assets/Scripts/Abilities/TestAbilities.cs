using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAbilities : MonoBehaviour
{

    public GameObject target, source;
    public CardAttack ability;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.J))
        {
            ability.getInfo(target, source);
        }


    }
}

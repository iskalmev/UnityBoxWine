using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGui : MonoBehaviour
{

    private BaseClass class1 = new BaseBoxWineBandit();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {

        GUILayout.Label("Try Me!");
        GUILayout.Label(class1.CharacterClassDescription);
    }
}

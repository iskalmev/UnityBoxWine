using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatWall : MonoBehaviour
{

    private GameObject source;
    private bool isMoving;
    private Vector3 direction;
    public float speed = 5f;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void getInfo(GameObject t, GameObject s)
    {
        source = s;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;

        this.gameObject.transform.position = source.transform.position + new Vector3(2f, 1.5f, 0);
        //direction = ((source.transform.position + new Vector3(.25f, 0, 0)) - transform.position).normalized;
        anim.Rebind();
    }
}

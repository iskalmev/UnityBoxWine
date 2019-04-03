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
        

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {

            if (transform.position == source.transform.position + new Vector3 (0,10,0))
            {
                isMoving = false;
            }
            else
            {
                transform.position += direction * speed * Time.deltaTime;
            }
        }
    }


    public void getInfo(GameObject t, GameObject s)
    {
        source = s;
        transform.Translate(source.transform.position + new Vector3(10, 0, 0));
        direction = ((source.transform.position + new Vector3(10, 0, 0)) - transform.position).normalized;
        anim.Play("Entry");
    }
}

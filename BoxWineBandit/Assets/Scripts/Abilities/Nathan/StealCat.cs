using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealCat : MonoBehaviour
{

    private GameObject target, source;
    private Vector3 ogSource;
    private bool isMoving, damaged, forward;
    private Vector3 direction;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(forward && isMoving)
        {
            if (source.transform.position == target.transform.position)
            {
                forward = false;
                direction = (ogSource - transform.position).normalized;
            }
            else
            {
                source.transform.position = Vector3.MoveTowards(source.transform.position, target.transform.position, speed);
            }
        }
        else if(!forward && isMoving)
        {
            if (transform.position == ogSource)
            {
                isMoving = false;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, ogSource, speed);
                source.transform.position = Vector3.MoveTowards(source.transform.position, ogSource, speed);

            }
        }
        else
        {
            if (!damaged)
            {
                StartCoroutine(Damagespriteflash());
            }

        }
    }



    IEnumerator Damagespriteflash()
    {
        var damagecolor = new Color32(22, 225, 69, 166);
        SpriteRenderer renderer = source.GetComponent<SpriteRenderer>();

        renderer.material.color = damagecolor;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = Color.white;
        damaged = true;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void getInfo(GameObject t, GameObject s)
    {
        target = t;
        source = s;
        ogSource = source.transform.position;
        isMoving = true;
        forward = true;
        damaged = false;
        transform.position = target.transform.position;
        direction = (target.transform.position - transform.position).normalized;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
}

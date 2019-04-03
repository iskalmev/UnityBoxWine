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
       

    }

    // Update is called once per frame
    void Update()
    {
        if(forward && isMoving)
        {
            if (transform.position == target.transform.position)
            {
                forward = false;
                direction = (ogSource - transform.position).normalized;
            }
            else
            {
                source.transform.position += direction * speed * Time.deltaTime;
            }
        }
        else if(!forward && isMoving)
        {
            if (transform.position == target.transform.position)
            {
                forward = false;
            }
            else
            {
                transform.position += direction * speed * Time.deltaTime;
                source.transform.position += direction * speed * Time.deltaTime;
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
        SpriteRenderer renderer = target.GetComponent<SpriteRenderer>();

        renderer.material.color = damagecolor;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = Color.white;
        damaged = true;
    }

    public void getInfo(GameObject t, GameObject s)
    {
        target = t;
        source = s;
        ogSource = source.transform.position;
        forward = true;
        damaged = false;
        transform.Translate(target.transform.position);
        direction = (target.transform.position - transform.position).normalized;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
}

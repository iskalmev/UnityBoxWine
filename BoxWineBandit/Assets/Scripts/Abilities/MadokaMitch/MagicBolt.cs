using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBolt : MonoBehaviour
{

    private GameObject target, source;
    private bool isMoving, damaged;
    private Vector3 direction;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<TrailRenderer>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {

            if (this.gameObject.transform.position == target.transform.position)
            {
                isMoving = false;
            }
            else
            {
               // this.gameObject.transform.position += direction * speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
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
        var damagecolor = new Color32(255, 117, 177, 166);
        SpriteRenderer renderer = target.GetComponent<SpriteRenderer>();

        renderer.material.color = damagecolor;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = Color.white;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = damagecolor;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = Color.white;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = damagecolor;
        yield return new WaitForSeconds(.1f);
        renderer.material.color = Color.white;
        damaged = true;
        this.gameObject.GetComponent<TrailRenderer>().enabled = false;

    }

    public void getInfo(GameObject t, GameObject s)
    {
        target = t;
        source = s;
        isMoving = true;
        damaged = false;
        this.gameObject.GetComponent<TrailRenderer>().enabled = true;
        this.gameObject.GetComponent<TrailRenderer>().time = 0;
        this.gameObject.transform.position = source.transform.position;
        direction = (target.transform.position - transform.position).normalized;
        this.gameObject.GetComponent<TrailRenderer>().time = 0.75f;


    }
}

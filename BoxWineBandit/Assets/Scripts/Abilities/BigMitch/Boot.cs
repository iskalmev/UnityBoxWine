using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : MonoBehaviour
{

    private GameObject target, source;
    private bool isMoving, damaged;
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
        if (isMoving)
        {

            if (transform.position == target.transform.position)
            {
                isMoving = false;
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                transform.position += direction * speed * Time.deltaTime;
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
        damaged = true;
    }

    public void getInfo(GameObject t, GameObject s)
    {
        target = t;
        source = s;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        damaged = false;
        transform.Translate(source.transform.position + new Vector3(0,50,0));
        direction = (target.transform.position - transform.position).normalized;
    }
}

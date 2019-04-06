using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxWine : MonoBehaviour
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

    }

    IEnumerator boxWineFlash()
    {


        yield return new WaitForSeconds(.75f);
        StartCoroutine(Damagespriteflash());
    }



    IEnumerator Damagespriteflash()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

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
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        damaged = false;
        transform.position = source.transform.position;
        direction = (target.transform.position - transform.position).normalized;
        StartCoroutine(boxWineFlash());
    }
}


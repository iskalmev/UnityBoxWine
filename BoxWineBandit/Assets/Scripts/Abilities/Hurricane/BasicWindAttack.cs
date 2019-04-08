using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWindAttack : MonoBehaviour
{

    private GameObject target, source;
    private bool isMoving, damaged;
    private Vector3 direction;
    public float speed = 5f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
                anim.SetTrigger("isHit");
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);

            }
        }
        else
        {
            if (!damaged)
            {
              //  this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
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
    }

    public void getInfo(GameObject t, GameObject s)
    {
        target = t;
        source = s;
        damaged = false;
        isMoving = true;
        transform.position = source.transform.position;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        direction = (target.transform.position - transform.position).normalized;
        anim.ResetTrigger("isHit");
        anim.Play("WindAttackStart");
    }
}

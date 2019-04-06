using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitchAttack : MonoBehaviour
{

    private GameObject target, source;
    private bool isMoving, damaged;
    private Vector3 direction;
    public Animator anim;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
      
       this.gameObject.GetComponent<SpriteRenderer>().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
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
        transform.position = target.transform.position + new Vector3(0,0,1);
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        damaged = false;
        anim.Rebind();
        
        direction = (target.transform.position - transform.position).normalized;
        StartCoroutine(Damagespriteflash());
        
    }
}


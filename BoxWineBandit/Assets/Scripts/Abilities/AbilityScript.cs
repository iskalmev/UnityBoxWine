using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityScript : MonoBehaviour
{



    private Vector3 source, target;
    private string abilityName, animName;
    private bool isMoving, doesMove;
    Vector3 direction;

    public Animator animator;
    public float speed = 5f;



    // Start is called before the first frame update
    void Start()
    {
        if (abilityName == this.gameObject.name)
        {
            transform.position = source;
            direction = (target - source).normalized;
            if (doesMove)
            {
                isMoving = true;
            }
            getAnimControler();
            animator.ResetTrigger("hitTarget");

            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            animator.Play(animName, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (isMoving)
        {
            moveObject();
        }
        else
        {

        }
        
    }

    private void moveObject()
    {
        if (transform.position != target)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        else
        {
            isMoving = false;
            if(abilityName == "BasicWindAttak")
            {
                animator.SetTrigger("hitTarget");
            }
            
        }
    }

    public void GetAbilityInfo(string name, Vector3 s, Vector3 t, bool move)
    {
        source = s;
        target = t;
        abilityName = name;
        doesMove = move;
    }

    private void getAnimControler()
    {
        if(abilityName == "MitchAttack") { animName = "MitchAttack"; }
        else if(abilityName == "BasicWindAttack") { animName = "BasicWindStart"; }
        else if (abilityName == "RatThrow") { animName = "RatThrow"; }
        else if (abilityName == "RatWall") { animName = "RatWall"; }
        else if (abilityName == "GatorBite") { animName = "GatorBite"; }
        else if (abilityName == "BasicWindAttack") { animName = "BasicWindStart"; }
    }
}

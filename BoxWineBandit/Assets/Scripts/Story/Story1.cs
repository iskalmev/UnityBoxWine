using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{

    //private bool backButton;
    public Sprite Mitch, FMM, Hurricane, Gator, Big, Madoka, Heart, Easter, Halloween, Itchell, RatKing, Nathan;
    private int count = 0;
    public Text textObj, textCount;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buttonClicked()
    {
       // print("clicked");
        switch (count)
        {

            case 0:

                gameObject.GetComponent<Image>().overrideSprite = Mitch;
                textObj.text = "This is Mitchell Hash.\nMitchell lives down in the bayous of North Carolina.\nBut not everthing is rainbows and shunshine for Mitchell";
                break;

            case 1:

                this.gameObject.SetActive(false);
                textObj.text = "Mitchell gets bullied by his friends.\nLike a lot...\nWhile this isn't that big of a problem in itself, the bullying happened so frequently that the jokes being made about Mitchell started to gain power, and continued to gain it until they became real.";
                break;

            case 2:

                textObj.text = "Now Mitchell has decided that it is time to take back his life and defeat these misconceptions about his life and maybe finally find peace.\n \nTo help him on his quest his friends The Rat King and Nathan have decided to accompany Mitchell.";
                break;

            case 3:

                textObj.text = "Mitchell walks out of his house and into the bayou in which he lives.\nIn front of him wait the enemy to all that dare dwell in the bayou...\n...Gators.";
                break;



        }
    }

    //public void BackClicked()
    //{
    //    backButton = true;
    //    if (count > 0)
    //    {
    //        count -= 1;
    //    }
    //    buttonClicked();
    //    textCount.text = (count + 1).ToString() + "/12";

    //}

    public void NextClicked()
    {

        //backButton = false;
        if (count < 3)
        {
            count += 1;
            buttonClicked();
        }
        else
        {
            Story1Toggle.complete = true;
        }
        
        //textCount.text = (count + 1).ToString() + "/12";
    }


}

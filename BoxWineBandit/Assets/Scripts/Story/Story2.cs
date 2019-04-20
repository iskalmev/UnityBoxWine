using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story2 : MonoBehaviour
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
                this.gameObject.SetActive(false);
               // gameObject.GetComponent<Image>().overrideSprite = Mitch;
                textObj.text = "Now that Mitch has defeated the first obstacle in his path, he can now start on his quest.";
                break;

            case 1:

                this.gameObject.SetActive(false);
                textObj.text = "While Mitchell is walking through the bayou the wind starts to pick up.\nRain starts to pour, getting more and more intense the more they travel, until eventually they see it...";
                break;

            case 2:
                gameObject.GetComponent<Image>().overrideSprite = Hurricane;
                this.gameObject.SetActive(true);
                textObj.text = "...Hurricane Mitch.\nThis is it. The first misconception to defeat.\nLucky for them that Hurricane Mitch is a lesser joke and not that powerful.";
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
        if (count < 2)
        {
            count += 1;
            buttonClicked();
        }
        else
        {
            Story2Toggle.complete = true;
        }

        //textCount.text = (count + 1).ToString() + "/12";
    }


}
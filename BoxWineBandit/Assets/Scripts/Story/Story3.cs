using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story3 : MonoBehaviour
{

    //private bool backButton;
    public Sprite Mitch, FMM, Hurricane, Gator, Big, Madoka, Heart, Easter, Halloween, Itchell, RatKing, Nathan;
    private int count = 0;
    public Text textObj, textCount;


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        // gameObject.GetComponent<Image>().overrideSprite = Mitch;
        textObj.text = "Hurricane Mitch has been defeated and Mitchell feels himself getting stronger and more confidant now that it is gone.";
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
                textObj.text = "Hurricane Mitch has been defeated and Mitchell feels himself getting stronger and more confidant now that it is gone.";
                break;

            case 1:

                this.gameObject.SetActive(false);
                textObj.text = "Celebration is cut short however, when the ground starts to shake, and the sun is blocked from the sky...";
                break;

            case 2:
                gameObject.GetComponent<Image>().overrideSprite = Big;
                this.gameObject.SetActive(true);
                textObj.text = "He is here.\nOne of the Elder Mitch,\na a joke of old.\nBig Mitch is a quite respected joke, but one eroded by time.\nBig Mitch has lost some of his power since his prime,and a good thing too, because if he were at full power his size would be infinite.";
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
            Story3Toggle.complete = true;
        }

        //textCount.text = (count + 1).ToString() + "/12";
    }


}

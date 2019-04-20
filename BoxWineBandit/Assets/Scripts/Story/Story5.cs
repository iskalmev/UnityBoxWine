using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story5 : MonoBehaviour
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
        textObj.text = "A huge success for Mitchell for defeating an Elder Mitch is no small task.\nBut now is not the time to rest; more fights are on the horizon";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buttonClicked()
    {
        //print("clicked");
        switch (count)
        {

            case 0:
                this.gameObject.SetActive(false);
                // gameObject.GetComponent<Image>().overrideSprite = Mitch;
                textObj.text = "A huge success for Mitchell for defeating an Elder Mitch is no small task.\nBut now is not the time to rest; more fights are on the horizon";
                break;

            case 1:
                gameObject.GetComponent<Image>().overrideSprite = Heart;
                this.gameObject.SetActive(true);
                textObj.text = "Oh no!\nIt's Mitchell's one true weakness...\nMagic the Gathering!";
                break;

            case 2:

                // this.gameObject.SetActive(true);
                textObj.text = "This Mitch is very powerful, most likely to Mitchell's borderline obsession with Magic the Gathering!\nWill Mitchell and Co. be able to take him down?";
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
            Story5Toggle.complete = true;
        }

        //textCount.text = (count + 1).ToString() + "/12";
    }


}

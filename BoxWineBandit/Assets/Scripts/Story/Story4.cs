using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4 : MonoBehaviour
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
                gameObject.GetComponent<Image>().overrideSprite = Madoka;
                this.gameObject.SetActive(true);
                textObj.text = "Madoka Michika appears before Mitchell. Mithcell's love of anime personifeid!";
                break;

            case 2:
                
               // this.gameObject.SetActive(true);
                textObj.text = "But Mitchell is not afraid of this Mitch for his friends are by his side and they will get him through this!";
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
            Story4Toggle.complete = true;
        }

        //textCount.text = (count + 1).ToString() + "/12";
    }


}

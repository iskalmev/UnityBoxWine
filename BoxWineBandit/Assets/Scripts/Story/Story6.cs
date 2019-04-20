using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story6 : MonoBehaviour
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
        //print("clicked");
        switch (count)
        {

            case 0:
                this.gameObject.SetActive(false);
                // gameObject.GetComponent<Image>().overrideSprite = Mitch;
                textObj.text = "Finally...\n\nIt's over.";
                break;

            case 1:
               // gameObject.GetComponent<Image>().overrideSprite = Heart;
               // this.gameObject.SetActive(true);
                textObj.text = "Mitchell did it.\nHe defeated his enemies.";
                break;

            case 2:

                // this.gameObject.SetActive(true);
                textObj.text = "Mitchell finally free from his nightmares, is free to return home.\n He says goodbye to his friends who helped him with his quest and started back.\nFinally he can be at peice.";
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
            Story6Toggle.complete = true;
        }

        //textCount.text = (count + 1).ToString() + "/12";
    }


}

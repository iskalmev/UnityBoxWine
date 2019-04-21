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
    public Button buttonObj;


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        // gameObject.GetComponent<Image>().overrideSprite = Mitch;
        textObj.text = "After Heart of the Cards Mitch was defeated, the party started forward again feeling they were close to the end.\nSuddenly a sense of stillness washed over them, almost as if entering a state of limbo.";
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
                textObj.text = "After Heart of the Cards Mitch was defeated, the party started forward again feeling they were close to the end.\nSuddenly a sense of stillness washed over them, almost as if entering a state of limbo.";
                break;

            case 1:
                gameObject.GetComponent<Image>().overrideSprite = FMM;
                this.gameObject.SetActive(true);
                textObj.text = "There he is.\n\nFeelsMitchMan.\nThe Ancient joke.\nFeelsMitchMan is the culmination of all of Mitchell's failure.";
                break;

            case 2:

                // this.gameObject.SetActive(true);
                textObj.text = "He is the final obstacle. \nDefeat him and you defeat your past failures and your past self.";
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

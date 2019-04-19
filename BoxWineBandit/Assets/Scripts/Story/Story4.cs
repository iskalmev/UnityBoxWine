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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buttonClicked()
    {
        print("clicked");
        switch (count)
        {

            case 0:

                gameObject.GetComponent<Image>().overrideSprite = Mitch;
                textObj.text = "Mitchell Hash:\n \nA big loser. \nMitch is a man… well let’s not go too far there. \nMitch is a person who dwells in the depths of North Carolina. \nMitch often gets bullied by his friends and by himself.";
                break;

            case 1:

                gameObject.GetComponent<Image>().overrideSprite = RatKing;
                textObj.text = "The Rat King Jaret:\n \nThe king and covetor of all things rat. \nVery skittish and will scream at you.";
                break;

            case 2:

                gameObject.GetComponent<Image>().overrideSprite = Nathan;
                textObj.text = "Nathan:\n \nNathan, the alternate persona of one of Mitch's friends, loves cats. \nHe loves then so much infact that he tries to steal other people's cats. \nHis key signature is spilled ranch because he is a clumsy idiot. \nBest not to look at him too long. \n \nArtist rendition in WWE '13";
                break;

            case 3:

                gameObject.GetComponent<Image>().overrideSprite = FMM;
                textObj.text = "FeelsMitchMan (FMM) : \n \nThe original and first personification of Mitch. \nMitch sucks so much that his failure had to be immortalized in an emote. \nHaving only three layers of mitch, a greyscale filter, and the league of legends defeat icon, FMM is the simplest picture created, but is the most powerful picture.";
                break;

            case 4:

                gameObject.GetComponent<Image>().overrideSprite = Hurricane;
                textObj.text = "Hurricane Mitch : \n \nA hurricane in 98 that has the same name as Mitch";
                break;

            case 5:

                gameObject.GetComponent<Image>().overrideSprite = Gator;
                textObj.text = "Gators: \n \nAlligators that populate the bayou that Mitch lives next to. \nUsually they kind of just sit there, but Mitchell being the man he is fights every single gator he sees.";
                break;

            case 6:

                gameObject.GetComponent<Image>().overrideSprite = Big;
                textObj.text = "Big Mitch : \n \nThis Mitch is a Mitch that when ever mentioned grows larger in size.\nThe initial size of this Mitch can change with the context in which he is being mentioned, but can never be smaller than a house. ";
                break;

            case 7:

                gameObject.GetComponent<Image>().overrideSprite = Madoka;
                textObj.text = "Madoka Mitchika : \n \nMadoka Mitchika is the personification of Mitchell’s like of anime, cause he is a giant weeb. \nAlthough called Madoka Mitchika, it is actually spelled “Michika.” \nNo one knows why it is spelled this way as the answer has been lost to time.";
                break;

            case 8:

                gameObject.GetComponent<Image>().overrideSprite = Heart;
                textObj.text = "Heart of the Cards Mitch : \n \nMitchell’s love of Magic the Gathering turned too far into obsession and thus this Mitch grew to power. \nThis Mitch is so powerful that it uses references from other card games when playing Magic and no one can stop him from doing so.";
                break;

            case 9:
                gameObject.GetComponent<Image>().overrideSprite = Easter;
                textObj.text = "Easter Mitch : \n \nThis is an Easter Special Mitch. \nMade in the spirit of the holiday and out of boredom.";
                break;

            case 10:
                gameObject.GetComponent<Image>().overrideSprite = Halloween;
                textObj.text = "Hashoween : \n \nThe Halloween version of Mitch. \nFun Fact : This Mitch didn't get finished for a whole year and is the most recent picture created.";
                break;

            case 11:
                gameObject.GetComponent<Image>().overrideSprite = Itchell;
                textObj.text = "Itchell Rash : \n \nHa ha \nLow effort joke.";
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
        if (count < 11)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalTextAndImage : MonoBehaviour
{

    private bool backButton;
    public Sprite Mitch, FMM, Hurricane, Gator, Big, Madoka, Heart;
    private int count = 0;
    public Text textObj;


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
                textObj.text = "Mitchell Hash:\n \nA big loser. \nMitch is a man… well let’s not go too far there. \nMitch is a person who dwells in the depths of North Carolina.";
                break;

            case 1:
 
                gameObject.GetComponent<Image>().overrideSprite = FMM;
                textObj.text = "FeelsMitchMan (FMM) : \n \nThe original and first personification of Mitch. \nMitch sucks so much that his failure had to be immortalized in an emote. \nHaving only three layers of mitch, a greyscale filter, and the league of legends defeat icon, FMM is the simplest picture created, but is the most powerful picture.";
                break;

            case 2:

                gameObject.GetComponent<Image>().overrideSprite = Hurricane;
                textObj.text = "Hurricane Mitch : \n \nA hurricane in 98 that has the same name as Mitch";
                break;

            case 3:

                gameObject.GetComponent<Image>().overrideSprite = Gator;
                textObj.text = "Gators: \n \nAlligators that populate the bayou that Mitch lives next to. \nUsually they kind of just sit there, but Mitchell being the man he is fights every single gator he sees.";
                break;

            case 4:

                gameObject.GetComponent<Image>().overrideSprite = Big;
                textObj.text = "Big Mitch : \n \nThis Mitch is a Mitch that when ever mentioned grows larger in size.\nThe initial size of this Mitch can change with the context in which he is being mentioned, but can never be smaller than a house. ";
                break;

            case 5:

                gameObject.GetComponent<Image>().overrideSprite = Madoka;
                textObj.text = "Madoka Mitchika : \n \nMadoka Mitchika is the personification of Mitchell’s like of anime, cause he is a giant weeb. \nAlthough called Madoka Mitchika, it is actually spelled “Michika.” \nNo one knows why it is spelled this way as the answer has been lost to time.";
                break;

            case 6:

                gameObject.GetComponent<Image>().overrideSprite = Heart;
                textObj.text = "Heart of the Cards Mitch : \n \nMitchell’s love of Magic the Gathering turned too far into obsession and thus this Mitch grew to power. \nThis Mitch is so powerful that it uses references from other card games when playing Magic and no one stops him from doing so.";
                break;


        }
    }

    public void BackClicked()
    {
        backButton = true;
        if(count > 0)
        {
            count -= 1;
        }
        buttonClicked();


    }

    public void NextClicked()
    {
        
        backButton = false;
        if(count < 6)
        {
            count += 1;
        }
        buttonClicked();
    }

   
}

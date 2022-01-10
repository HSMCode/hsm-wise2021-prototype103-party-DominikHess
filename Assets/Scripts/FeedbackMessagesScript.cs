using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackMessagesScript : MonoBehaviour
{
    public Text feedbackMessage;
    private float fadingTime = 1.5f;
    private Color bonusColor;
    private Color malusColor;


    void Start()
    {
        bonusColor = new Color(0.1881425f, 0.4528302f, 0.1644713f, 1.0f);
        malusColor = new Color(0.6037736f, 0.06550375f, 0.06550375f, 1.0f);
        feedbackMessage.enabled = false;
    }

    public void DisplayFeedbackMessage()
    {
        feedbackMessage.enabled = true;
        StartCoroutine(FadeTextToZeroAlpha());
    }

    public void ShotPatriotFeedback()
    { 
        feedbackMessage.text = "Patriot killed! Score: +5";
        feedbackMessage.color = bonusColor;
        DisplayFeedbackMessage();
    }

    public void ShotPassengerFeedback()
    {
        feedbackMessage.text = "Civillian killed! Score: -5";
        feedbackMessage.color = malusColor;
        DisplayFeedbackMessage();
    }

    public void PassengerOnBoardFeedback() 
    {
        feedbackMessage.text = "Civillian on board! Score: +1";
        feedbackMessage.color = bonusColor;
        DisplayFeedbackMessage();
    }

    public void PatriotOnBoardFeedback()
    {
        feedbackMessage.text = "Patriot on board!";
        feedbackMessage.color = malusColor;
        DisplayFeedbackMessage();
    }

    private IEnumerator FadeTextToZeroAlpha()
    {
        feedbackMessage.color = new Color(feedbackMessage.color.r, feedbackMessage.color.g, feedbackMessage.color.b, 1);
        while (feedbackMessage.color.a > 0.0f)
        {
            feedbackMessage.color = new Color(feedbackMessage.color.r, feedbackMessage.color.g, feedbackMessage.color.b, feedbackMessage.color.a - (Time.deltaTime / fadingTime));
            yield return null;
        }
    }
}





using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackMessagesScript : MonoBehaviour
{
    public Text feedbackMessage;
    private float displayTime = 1.25f;
    private float fadingTime = 0.75f; 
    private Color bonusColor;
    private Color malusColor;

    void Start()
    {
        bonusColor = new Color(0.1881425f, 0.4528302f, 0.1644713f, 1.0f);
        malusColor = new Color(0.6037736f, 0.06550375f, 0.06550375f, 1.0f);
        feedbackMessage.enabled = false;
    }

    public void DisplayText(Text text)
    {
        feedbackMessage.enabled = true;
        StartCoroutine(FadeTextToZeroAlpha(text));
    }

    public void ShotPatriotFeedback()
    { 
        feedbackMessage.text = "Patriot killed! Score: +3";
        feedbackMessage.color = bonusColor;
        DisplayText(feedbackMessage);
    }

    public void ShotPassengerFeedback()
    {
        feedbackMessage.text = "Civillian killed! Score: -10";
        feedbackMessage.color = malusColor;
        DisplayText(feedbackMessage);
    }

    public void PassengerOnBoardFeedback() 
    {
        feedbackMessage.text = "Civillian on board! Score: +1";
        feedbackMessage.color = bonusColor;
        DisplayText(feedbackMessage);
    }

    public void PatriotOnBoardFeedback()
    {
        feedbackMessage.text = "Patriot on board!";
        feedbackMessage.color = malusColor;
        DisplayText(feedbackMessage);
    }

    private IEnumerator FadeTextToZeroAlpha(Text text)
    {
        yield return new WaitForSeconds(displayTime);

        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
        while (text.color.a > 0.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - (Time.deltaTime / fadingTime));
            yield return null;
        }
        feedbackMessage.enabled = false;
    }
}

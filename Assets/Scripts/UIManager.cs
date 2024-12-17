using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject ExamplePanel;
    public TextMeshProUGUI textComponent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            TextsolutionOne();
        }
    }

    public void TextsolutionOne()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 localPoint;
 
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(textComponent.rectTransform, mousePos, null, out localPoint))
        {
            Vector2 textSize = textComponent.rectTransform.sizeDelta;
            Vector2 textPos = textComponent.rectTransform.anchoredPosition;
 
            if (localPoint.x > textPos.x - textSize.x / 2 && localPoint.x < textPos.x + textSize.x / 2 &&
                    localPoint.y > -textPos.y - textSize.y / 2 && localPoint.y < -textPos.y + textSize.y / 2)
            {
                CheckTextResult();
            }    

        }
    }

    public void CheckTextResult()
    {
        Debug.Log("Text has been clicked");
    }

    public void CheckOResult()
    {
        Debug.Log("O has been clicked");
    }

}

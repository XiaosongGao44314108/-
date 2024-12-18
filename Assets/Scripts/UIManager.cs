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
    public CapsuleCollider2D capsuleCollider;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            TextsolutionOne();
            OsoultionOne();
            OsolutionTwo();
            OsolutionThree();
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

    public void OsoultionOne()
    {
            Vector2 mousePos = Input.mousePosition;
            if (capsuleCollider.OverlapPoint(mousePos))
            {
                CheckOResult();
            }
    }
    public void OsolutionTwo()
    {
        RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.zero);

        if(hit.collider == capsuleCollider)
        {
            CheckOResult();
        }

    }

    public void OsolutionThree()
    {
        Vector2 mousePos = Input.mousePosition;
        Collider2D hitCollider = Physics2D.OverlapCircle(mousePos, 0.01f, 1 << capsuleCollider.gameObject.layer);
        if (hitCollider == capsuleCollider)
        {
            CheckOResult();
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

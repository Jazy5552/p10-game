using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// To be used within a card prefab

public class Card : MonoBehaviour
{
    public enum Colors { Blue, Red, Green, Yellow };
    [HideInInspector]
    public Colors color;
    [HideInInspector]
    public int number;
    [HideInInspector]
    public bool isWild = false;
    [HideInInspector]
    public bool isSkip = false;

    // assets to be set in editor
    [Header("Sprites to use for card values")]
    [SerializeField] 
    private Sprite blueBGSprite;
    [SerializeField] 
    private Sprite redBGSprite;
    [SerializeField] 
    private Sprite greenBGSprite;
    [SerializeField] 
    private Sprite yellowBGSprite;
    [Tooltip("Must be in order! Where Element n => Sprite Number n+1")]
    [SerializeField] 
    private Sprite[] numberSprites;
    [SerializeField] 
    private Sprite borderSprite;

    [Header("Components in which to update sprites accordingly")]
    [SerializeField] 
    private SpriteRenderer cardNumberSpriteRenderer;
    [SerializeField] 
    private SpriteRenderer cardBGSpriteRenderer;
    [SerializeField] 
    private SpriteRenderer cardBorderSpriteRenderer;

    [Space(10)]
    [SerializeField] 
    private GameObject wildCardGameObject;
    [SerializeField] 
    private GameObject skipCardGameObject;

    // Start is called before the first frame update
    void Start()
    {
        if (isWild)
        {
            SetAsWild();
            return;
        }
        if (isSkip)
        {
            SetAsSkip();
            return;
        }
        // set the cards color and value
        SetCardColor(color);
        SetCardNumber(number);
    }

    void SetCardColor(Colors c)
    {
        switch (c)
        {
            case Colors.Blue:
                cardBGSpriteRenderer.sprite = blueBGSprite;
                break;
            case Colors.Red:
                cardBGSpriteRenderer.sprite = redBGSprite;
                break;
            case Colors.Green:
                cardBGSpriteRenderer.sprite = greenBGSprite;
                break;
            case Colors.Yellow:
                cardBGSpriteRenderer.sprite = yellowBGSprite;
                break;
        }
    }

    void SetCardNumber(int n)
    {
        cardNumberSpriteRenderer.sprite = numberSprites[n - 1];
    }

    void SetAsWild()
    {
        wildCardGameObject.SetActive(true);
    }

    void SetAsSkip()
    {
        skipCardGameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

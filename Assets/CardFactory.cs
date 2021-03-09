using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    public GameObject CreateNormalCard(int n, Card.Colors c)
    {
        GameObject card = Instantiate(cardPrefab, this.gameObject.transform);
        Card cc = card.GetComponent<Card>();
        cc.color = c;
        cc.number = n;
        return card;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

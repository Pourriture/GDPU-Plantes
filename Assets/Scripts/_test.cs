using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cards;

public class _test : MonoBehaviour
{
    private List<Card> cardList = CardDatabase.cardList;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(cardList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

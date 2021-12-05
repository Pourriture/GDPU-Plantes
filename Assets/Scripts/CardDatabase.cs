using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cards;
using Choices;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();
    private List<Choice> choiceList = ChoiceDatabase.choiceList;

    private void Awake()
    {
        Choice[] card0Choices = { choiceList[0] };
        cardList.Add(new Card(0, "firstCard", "family", card0Choices));
    }

    //TODO Check if list is correct (ascending and incremented by one id)
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cards;
using Choices;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();

    private void Awake()
    {
        List<Choice> card0Choices = new List<Choice>{ 
            new Choice(0, "noname", "Affronter le vent +3a", true, 0, 0, 3, 0),
            new Choice(1, "noname", "Couvrir la plante -1a", true, 0, 0, -1, 0) 
        };
        cardList.Add(new Card(0, "noname", "Le vent approche :", "Printemps", card0Choices));
    }

    //TODO Check if list is correct (ascending and incremented by one id) same for CHOICES
}

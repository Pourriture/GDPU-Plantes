using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Choices;

public class ChoiceDatabase : MonoBehaviour
{
    public static List<Choice> choiceList = new List<Choice>();

    private void Awake()
    {
        choiceList.Add(new Choice(0));
    }

    //TODO Check if list is correct (ascending and incremented by one id)
}

using System.Collections.Generic;

using Choices;

namespace Cards
{
    public class Card
    {
        private int _id = -1;
        private string _name = "defaultcard"; //the interlocutor
        private string _description = "defaultcarddescription"; //the description of the event
        private string _family;      // Utiliser un ID avec des define pour améliorer les performances ?
                                     // familles de cartes débloquées

        List<Choice> _choices = new List<Choice>();

        public Card(int id, string name, string description, string family, List<Choice> choices)
        {
            _id = id;
            _name = name;
            _description = description;
            _family = family;
            _choices = choices;
        }

        public override string ToString()
        {
            string choices = "\n";

            for (int i = 0; i < _choices.Count; i++)
            {
                choices += "[" + _choices[i] + "]\n";
            }

            return "ID: " + _id + ", Name: " + _name + ", Description: \"" + _description + "\", Family: " + _family + ", Choices: " + choices; //TODO print choices correctly
        }
    }

   
}

using Choices;

namespace Cards
{
    public class Card
    {
        int _id = -1;
        string _name = "defaultcard";
        public string description = "defaultcarddescription";
        string _family;      // Utiliser un ID avec des define pour améliorer les performances ?
                            // familles de cartes débloquées
        Choice[] choices;

        public Card(int id, string name, string family, Choice[] choices)
        {
            _id = id;
            _name = name;
            _family = family;
            this.choices = choices;
        }

        public Card(int id, string name, string description, string family, Choice[] choices)
        {
            _id = id;
            _name = name;
            this.description = description;
            _family = family;
            this.choices = choices;
        }

        public override string ToString()
        {
            return "ID: " + _id + ", Name: " + _name + ", Description: " + description + ", Family: " + _family + ", Choices: " + choices; //TODO print choices correctly
        }
    }

   
}

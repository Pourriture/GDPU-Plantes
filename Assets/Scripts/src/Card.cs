using Choices;

namespace Cards
{
    class Card
    {
        string _name = "defaultcard";
        public string description = "defaultcarddescription";
        int _id = -1;
        string _family;      // Utiliser un ID avec des define pour améliorer les performances ?
                            // familles de cartes débloquées
        Choice[] choices;

        public Card(int id)
        {
            _id = id;
        }
    }

   
}

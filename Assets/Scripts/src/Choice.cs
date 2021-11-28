namespace Choices
{
    class Choice
    {
        protected string _name = "defaultchoice";
        public string _description = "defaultchoicedescription";
        protected int _id = -1;
        protected int _modLove = 0;
        protected int _modHum = 0;
        protected int _modAir = 0;
        protected int _modSoil = 0;
        protected bool _deleteOnPick = false;
        // Peut verouiller des cartes
        // Peut ajouter des cartes

        public virtual bool choose(int plant)
        {

            // Opérations standard sur la plante
            // Ajouter amour, modificateur d'air, d'humidité et de sol

            // Retourner deleteOnPick pour dire à l'appelant si la carte doit être supprimée du deck
            return _deleteOnPick;
        }

        public Choice (int id)
        {
            _id = id;
        }

    }
    // TODO : toutes les méthodes 

}
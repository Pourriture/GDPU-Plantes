using System;

namespace Choices
{
    [Serializable]
    public class Choice
    {
        private string _name = "defaultchoice";
        private string _description = "defaultchoicedescription";
        private int _id = -1;
        private int _modLove = 0;
        private int _modHum = 0;
        private int _modAir = 0;
        private int _modSoil = 0;
        private bool _deleteOnPick = false;
        // Peut verouiller des cartes
        // Peut ajouter des cartes

        public virtual bool choose(int plant)
        {

            // Opérations standard sur la plante
            // Ajouter amour, modificateur d'air, d'humidité et de sol

            // Retourner deleteOnPick pour dire à l'appelant si la carte doit être supprimée du deck
            return _deleteOnPick;
        }

        public Choice (int id, string name, string description, bool deleteOnPick, int modLove=0, int modHum=0, int modAir=0, int modSoil=0)
        {
            _id = id;
            _name = name;
            _description = description;
            _deleteOnPick = deleteOnPick;
            _modLove = modLove;
            _modHum = modHum;
            _modAir = modAir;
            _modSoil = modSoil;
        }

        public override string ToString()
        {
            string idReadable = "wrong id!";
            if (_id == 0) idReadable = "left";
            if (_id == 1) idReadable = "right";
            if (_id == 2) idReadable = "down";
            if (_id == 3) idReadable = "up";
            return "ID: " + _id + ", Direction " + idReadable + ", Name: " + _name + ", Description: " + _description + ", deleteOnPick: " + _deleteOnPick + ", modLove: " + _modLove + ", modHum: " + _modHum + ", modAir: " + _modAir + ", modSoil: " + _modSoil;
        }

    }
    // TODO : toutes les méthodes 

}
namespace Plants
{
    public class Plant
    {
        private string _name;
        private int _love;
        private int _humidity;
        private int _air;
        private int _soil;
        private float _age; //months
        //private int _flags; ?

        public Plant(string name, int startingLove, int startingHumidity, int startingAir, int startingSoil, float age = 0)
        {
            _name = name;
            _love = startingLove;
            _humidity = startingHumidity;
            _air = startingAir;
            _soil = startingSoil;
            _age = age;
        }

        public void addMod(int modLove, int modHumidity, int modAir, int modSoil, float modAge)
        {

        }
        // toutes les fonctions de la plante
    }
}

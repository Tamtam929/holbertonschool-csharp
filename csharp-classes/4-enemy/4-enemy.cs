namespace Enemies
{
    /// <summary>Create an empty public class Zombie within Enemies that defines a zombie</summary>
    public class Zombie
    {
        /// <summary>Int that represents the value of the Zombie health</summary>
        private int health;

        // Private field that should be a string and have a default value of (No name)
        private string name = "(No name)";

        /// <summary>String that represents the name of the Zombie instance.</summary>

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }		

        /// <summary>Initializes a new instance of the <see cref="Zombie"/>class.</summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/>class that value must be greater than or equal to 0</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");

            else
                this.health = value;
        }
        /// <summary>public method that returns the value of health of the Zombie object</summary>
        public int GetHealth()
        {
            return (this.health);
        }
    }
}

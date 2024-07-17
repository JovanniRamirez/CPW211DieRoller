
namespace DieRoller
{
	/// <summary>
	/// Represents a single six sided die (1-6)
	/// </summary>
	internal class Die
	{
		/// <summary>
		/// Creates the die and rolls it to start with a random number
		/// </summary>
        public Die()
        {
			Roll();
        }

        /// <summary>
        /// Face up value (what was rolled?)
        /// </summary>
        public byte FaceValue { get; private set; }

		/// <summary>
		/// True if the die is currently held
		/// </summary>
		public bool IsHeld { get; set; }

		/// <summary>
		/// Roll the die and sets the <see cref="FaceValue"/>
		/// to the new number. Returns the new number 
		/// </summary>
		/// <returns>Returns the new random number</returns>
		public byte Roll()
		{
			//Generate random number
			Random random = new Random();
			byte newValue = (byte)random.Next(1, 7);
			FaceValue = newValue;

			return FaceValue;
		}
	}
}

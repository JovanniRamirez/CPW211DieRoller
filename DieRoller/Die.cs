
namespace DieRoller
{
	/// <summary>
	/// Represents a single six sided die (1-6)
	/// </summary>
	internal class Die
	{
		private static Random _random;

		static Die()
		{
			_random = new Random();
		}
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
		/// to the new number if the die is not curently held.
		/// Returns the <see cref="FaceValue"/>
		/// </summary>
		/// <returns>Returns the <see cref="FaceValue"/> </returns>
		public byte Roll()
		{
			if (!IsHeld)
			{
				//Generate random number
				byte newValue = (byte)_random.Next(1, 7);
				FaceValue = newValue;
			}
			
			return FaceValue;
		}
	}
}

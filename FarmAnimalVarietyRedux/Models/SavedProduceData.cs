﻿namespace FarmAnimalVarietyRedux.Models
{
    /// <summary>Contains the data that gets saved on each animal about the current state of a produce.</summary>
    public class SavedProduceData
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The unique name of the produce.</summary>
        public string UniqueName { get; set; }

        /// <summary>The days until the animal can produce this produce again.</summary>
        public int DaysLeft { get; set; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="uniqueName">The unique name of the produce.</param>
        /// <param name="daysLeft">The days until the animal can produce this produce again.</param>
        public SavedProduceData(string uniqueName, int daysLeft)
        {
            UniqueName = uniqueName;
            DaysLeft = daysLeft;
        }
    }
}

﻿namespace BfavToFavrModConverter.Favr
{
    /// <summary>Represents the shop information of an FAVR animal.</summary>
    public class FavrAnimalShopInfo
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The description of the animal.</summary>
        public string Description { get; set; }

        /// <summary>The cost of the animal.</summary>
        public int BuyPrice { get; set; }


        /*********
        ** Public Methods
        *********/
        /// <summary>Constructs an instance.</summary>
        /// <param name="description">The description of the animal.</param>
        /// <param name="buyPrice">The cost of the animal.</param>
        public FavrAnimalShopInfo(string description, int buyPrice)
        {
            Description = description;
            BuyPrice = buyPrice;
        }
    }
}

﻿using StardewValley;
using System.Collections.Generic;

namespace FarmAnimalVarietyRedux.Patches
{
    /// <summary>Contains patches for patching game code in the <see cref="Utility"/> class.</summary>
    internal class UtilityPatch
    {
        /*********
        ** Internal Methods
        *********/
        /// <summary>The post fix for the <see cref="Utility.getPurchaseAnimalStock"/> method.</summary>
        /// <param name="__result">The return value of the method.</param>
        /// <remarks>This is used to add the custom animals to the purchasable animal stock.</remarks>
        internal static void GetPurchaseAnimalStockPostFix(ref List<Object> __result) => __result = ModEntry.Instance.Api.GetAllBuyableAnimalObjects();
    }
}

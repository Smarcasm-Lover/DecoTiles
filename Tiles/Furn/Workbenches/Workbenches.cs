﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Workbenches
{
    public class CardboardWorkbenchTile : QuickBench
    {
        public CardboardWorkbenchTile() : base("Cardboard Workbench", 0, false, ItemType<CardboardWorkbench>()) { }
    }
    public class CardboardWorkbench : QuickTileItem
    {
        public CardboardWorkbench() : base("Cardboard Workbench", "", TileType<CardboardWorkbenchTile>(), 0) { }
        public override void AddRecipes()
        {
            base.AddRecipes();
            {
                ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.Wood, 8);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    }

}

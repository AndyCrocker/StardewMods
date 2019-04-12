﻿using BetterCrabPots.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCrabPots
{
    class ModConfig
    {
        public bool EnableTrash { get; set; } = true;
        public bool RequiresBait { get; set; } = true;
        public int PercentChanceForTrash { get; set; } = 20;
        public bool EnableBetterQuality { get; set; } = false;
        public bool EnablePassiveTrash { get; set; } = false;
        public int PercentChanceForPassiveTrash { get; set; } = 20;
        public Dictionary<int, int> WhatCanBeFoundAsPassiveTrash { get; set; } = new Dictionary<int, int> { { 168, 1 }, { 169, 1 }, { 170, 1 }, { 171, 1 }, { 172, 1 } };

        public ConfigItem FarmLand { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem CindersapForest { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem MountainsLake { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Town { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Mines_Layer20 { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Mines_Layer60 { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Mines_Layer100 { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem MutantBugLair { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem WitchsSwamp { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem SecretWoods { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Desert { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Sewers { get; set; } = new ConfigItem(new List<Item> { { new Item(716, 1, 1) }, { new Item(721, 1, 1) }, { new Item(722, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
        public ConfigItem Beach { get; set; } = new ConfigItem(new List<Item> { { new Item(715, 1, 1) }, { new Item(372, 1, 1) }, { new Item(717, 1, 1) }, { new Item(718, 1, 1) }, { new Item(719, 1, 1) }, { new Item(720, 1, 1) }, { new Item(723, 1, 1) } }, new List<Item> { { new Item(168, 1, 1) }, { new Item(169, 1, 1) }, { new Item(170, 1, 1) }, { new Item(171, 1, 1) }, { new Item(172, 1, 1) } });
    }
}

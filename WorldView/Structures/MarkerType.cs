﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreTerra.Structures
{
	public enum MarkerType
	{
		Unknown = -1, 
		Altar = 0,
        GoldCache,
		Heart,
        HeartFruit,
		Hellforge,
        Picture = 5,
        PlanteraBulb,
		ShadowOrb,
        Sign,
        Statue,
        Torch = 10,
        Tombstone = 11,

		Amethyst = 20,
		Diamond,
		Emerald,
		Ruby,
		Sapphire,
		Topaz = 25,


		Copper = 40,
		Iron,
		Silver,
		Gold,
		Demonite = 45,
		Obsidian, 
		Meteorite,
		Hellstone,
		Cobalt,
		Mythril = 50,
		Adamantite,
        Tin,
        Lead,
        Tungsten,
        Platinum = 55,
        Crimtane,
        Chlorophyte,
        Palladium,
        Orichalcum,
        Titanium = 60,

		// Extra space here for improvement room.
		ArmsDealer = 70,
		Clothier,
        Cyborg,
		Demolitionist,
		Dryad,
        DyeTrader = 75,
		GoblinTinkerer,
		Guide,
		Mechanic,
		Merchant,
		Nurse = 80,
		OldMan,
        Painter,
        PartyGirl,
        Pirate,
		SantaClaus = 85,
		Steampunker,
        Truffle,
        WitchDoctor,
		Wizard,
		Spawn = 90,

		// Extra space again.
		Chest = 100,
		GoldChest,
		LockedGoldChest,
		ShadowChest,
		LockedShadowChest,
		Barrel = 105,
		TrashCan,
        EbonwoodChest,
        RichMahoganyChest,
        PearlwoodChest,
        IvyChest = 110,
        IceChest,
        LivingWoodChest,
        SkywareChest,
        ShadewoodChest,
        WebCoveredChest = 115,
        LihzahrdChest,
        WaterChest,
        JungleChest,
        CorruptionChest,
        CrimsonChest = 120,
        HallowedChest,
        FrozenChest,
        LockedJungleChest,
        LockedCorruptionChest,
        LockedCrimsonChest = 125,
        LockedHallowedChest,
        LockedFrozenChest = 127


		// Extra space again.

	}
}

﻿using System;

namespace Bejeweled3
{
	[Flags]
	public enum PIECEFLAG
	{
		PIECEFLAG_INVISIBLE = -1,
		PIECEFLAG_NONE = 0,
		PIECEFLAG_FLAME = 1,
		PIECEFLAG_HYPERGEM = 2,
		PIECEFLAG_LASER = 3,
		PIECEFLAG_RESERVED = 4,
		PIECEFLAG_DRAGONSTONE = 5,
		PIECEFLAG_POINT_MULTIPLIER = 6,
		PIECEFLAG_BOMB = 7,
		PIECEFLAG_REALTIME_BOMB = 8,
		PIECEFLAG_SCROLL = 9,
		PIECEFLAG_FRAGMENT = 10,
		PIECEFLAG_SKULL = 11,
		PIECEFLAG_DOOM = 12,
		PIECEFLAG_COUNTER = 13,
		PIECEFLAG_CAT = 14,
		PIECEFLAG_MOUSE = 15,
		PIECEFLAG_COIN = 16,
		PIECEFLAG_DETONATOR = 17,
		PIECEFLAG_SCRAMBLE = 18,
		PIECEFLAG_INFERNO_SWAP = 19
	}
}
﻿using System;

namespace SexyFramework.Graphics
{
	public enum SEXY3DTEXTUREOP
	{
		SEXY3DTOP_DISABLE = 1,
		SEXY3DTOP_SELECTARG1,
		SEXY3DTOP_SELECTARG2,
		SEXY3DTOP_MODULATE,
		SEXY3DTOP_MODULATE2X,
		SEXY3DTOP_MODULATE4X,
		SEXY3DTOP_ADD,
		SEXY3DTOP_ADDSIGNED,
		SEXY3DTOP_ADDSIGNED2X,
		SEXY3DTOP_SUBTRACT,
		SEXY3DTOP_ADDSMOOTH,
		SEXY3DTOP_BLENDDIFFUSEALPHA,
		SEXY3DTOP_BLENDTEXTUREALPHA,
		SEXY3DTOP_BLENDFACTORALPHA,
		SEXY3DTOP_BLENDTEXTUREALPHAPM,
		SEXY3DTOP_BLENDCURRENTALPHA,
		SEXY3DTOP_PREMODULATE,
		SEXY3DTOP_MODULATEALPHA_ADDCOLOR,
		SEXY3DTOP_MODULATECOLOR_ADDALPHA,
		SEXY3DTOP_MODULATEINVALPHA_ADDCOLOR,
		SEXY3DTOP_MODULATEINVCOLOR_ADDALPHA,
		SEXY3DTOP_BUMPENVMAP,
		SEXY3DTOP_BUMPENVMAPLUMINANCE,
		SEXY3DTOP_DOTPRODUCT3,
		SEXY3DTOP_MULTIPLYADD,
		SEXY3DTOP_LERP,
		SEXY3DTOP_FORCE_DWORD = 2147483647
	}
}
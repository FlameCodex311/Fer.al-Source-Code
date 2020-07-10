/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldSurfaceChartData : ChartDataObject<BaseDef, WorldSurfaceChartData> // TypeDefIndex: 10229
{
	// Fields
	private List<Dictionary<string, WorldSurfaceDefComponent>> _matchStringToSurfaceDefComponentDicts; // 0x78

	// Constructors
	public WorldSurfaceChartData(); // 0x0000000181003FF0-0x0000000181004050

	// Methods
	public WorldSurfaceDefComponent GetMatchingSurfaceDef(string inMatchString, WorldSurfaceType inSurfaceType); // 0x00000001810037A0-0x0000000181003AC0
	private WorldSurfaceDefComponent GetWorldSurfaceDefComponent(string inMatchString, out string outMatchString, WorldSurfaceType inSurfaceType); // 0x0000000181003AC0-0x0000000181003FF0
}


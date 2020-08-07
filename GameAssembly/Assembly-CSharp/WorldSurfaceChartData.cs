/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldSurfaceChartData : ChartDataObject<BaseDef, WorldSurfaceChartData> // TypeDefIndex: 11720
{
	// Fields
	private List<Dictionary<string, WorldSurfaceDefComponent>> _matchStringToSurfaceDefComponentDicts; // 0x78

	// Constructors
	public WorldSurfaceChartData(); // 0x00000001805EB710-0x00000001805EB770

	// Methods
	public WorldSurfaceDefComponent GetMatchingSurfaceDef(string inMatchString, WorldSurfaceType inSurfaceType); // 0x00000001805EAED0-0x00000001805EB1F0
	private WorldSurfaceDefComponent GetWorldSurfaceDefComponent(string inMatchString, out string outMatchString, WorldSurfaceType inSurfaceType); // 0x00000001805EB1F0-0x00000001805EB710
}


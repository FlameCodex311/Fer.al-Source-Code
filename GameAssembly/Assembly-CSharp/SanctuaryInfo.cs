/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class SanctuaryInfo : BaseInfo // TypeDefIndex: 12484
{
	// Fields
	[ChartDef] // 0x00000001801D4B50-0x00000001801D4BD0
	public string houseDefID; // 0x10
	[ChartDef] // 0x00000001801D4EE0-0x00000001801D4F60
	public string islandDefID; // 0x18
	public string houseDefId; // 0x20
	public string islandDefId; // 0x28
	public string houseInvId; // 0x30
	public string islandInvId; // 0x38
	public string classInvId; // 0x40
	[NonSerialized]
	public PlacementInfo placementInfo; // 0x48

	// Nested types
	public class PlacementInfo // TypeDefIndex: 12485
	{
		// Fields
		public Inventory placement; // 0x10

		// Constructors
		public PlacementInfo(JsonData jsonData); // 0x0000000180BE5240-0x0000000180BE52B0
	}

	// Constructors
	public SanctuaryInfo(); // 0x00000001803F46D0-0x00000001803F46E0
}


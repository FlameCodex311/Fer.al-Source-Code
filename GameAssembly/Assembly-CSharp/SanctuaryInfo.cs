/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class SanctuaryInfo : BaseInfo // TypeDefIndex: 10961
{
	// Fields
	[ChartDef] // 0x00000001800F9F40-0x00000001800F9FC0
	public string houseDefID; // 0x10
	[ChartDef] // 0x00000001800FA410-0x00000001800FA490
	public string islandDefID; // 0x18
	public string houseDefId; // 0x20
	public string islandDefId; // 0x28
	public string houseInvId; // 0x30
	public string islandInvId; // 0x38
	public string classInvId; // 0x40
	[NonSerialized]
	public PlacementInfo placementInfo; // 0x48

	// Nested types
	public class PlacementInfo // TypeDefIndex: 10962
	{
		// Fields
		public Inventory placement; // 0x10

		// Constructors
		public PlacementInfo(JsonData jsonData); // 0x0000000181361BA0-0x0000000181361C10
	}

	// Constructors
	public SanctuaryInfo(); // 0x000000018037E800-0x000000018037E810
}


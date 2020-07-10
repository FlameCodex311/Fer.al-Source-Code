/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class HouseItemComponent : ItemComponent // TypeDefIndex: 10535
{
	// Fields
	public string themeDefId; // 0x20
	public int x; // 0x28
	public int y; // 0x2C
	public int stage; // 0x30
	public List<int> enlargedAreas; // 0x38
	public List<RoomData> roomData; // 0x40
	public int gridId; // 0x48

	// Constructors
	public HouseItemComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180F55320-0x0000000180F55640
	protected override JsonData ToJsonOverride(); // 0x0000000180F55640-0x0000000180F55810
}


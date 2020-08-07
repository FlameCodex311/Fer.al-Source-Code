/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class HouseItemComponent : ItemComponent // TypeDefIndex: 12023
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
	public HouseItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018061F7D0-0x000000018061FAE0
	protected override JsonData ToJsonOverride(); // 0x000000018061FAE0-0x000000018061FCB0
}


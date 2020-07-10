/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class UserVarItemComponent : ItemComponent // TypeDefIndex: 10548
{
	// Fields
	public Dictionary<int, ObscuredLong> values; // 0x20

	// Constructors
	public UserVarItemComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018121FEC0-0x00000001812204A0
	protected override JsonData ToJsonOverride(); // 0x00000001812204A0-0x0000000181220710
}


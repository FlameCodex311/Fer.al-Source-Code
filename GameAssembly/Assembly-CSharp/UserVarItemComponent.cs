/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class UserVarItemComponent : ItemComponent // TypeDefIndex: 12036
{
	// Fields
	public Dictionary<int, ObscuredLong> values; // 0x20

	// Constructors
	public UserVarItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x000000018066BD10-0x000000018066C2E0
	protected override JsonData ToJsonOverride(); // 0x000000018066C2E0-0x000000018066C540
}


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
public class LoginData // TypeDefIndex: 12437
{
	// Fields
	public string uuid; // 0x10
	public string email; // 0x18
	public string displayName; // 0x20
	public string activeLookId; // 0x28
	public int avatarInvId; // 0x30
	public string sanctuaryLookId; // 0x38
	public uint pendingFlags; // 0x40
	public Dictionary<string, int> inventoryMaxes; // 0x48
	public int userId; // 0x50
	public int sessionId; // 0x54
	public long jamaaTime; // 0x58
	public bool renameRequired; // 0x60
	public bool renameRequiredKey; // 0x61

	// Constructors
	public LoginData(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public void Load(JsonData json); // 0x00000001803774A0-0x00000001803774B0
}


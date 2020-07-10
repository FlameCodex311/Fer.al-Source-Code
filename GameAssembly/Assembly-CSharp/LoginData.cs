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
public class LoginData // TypeDefIndex: 10914
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

	// Constructors
	public LoginData(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public void Load(JsonData json); // 0x00000001803581E0-0x00000001803581F0
}


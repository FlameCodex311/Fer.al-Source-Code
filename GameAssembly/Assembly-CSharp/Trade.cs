/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Trade // TypeDefIndex: 12306
{
	// Fields
	public UserInfo targetUser; // 0x10
	public UserInfo initiatedByUser; // 0x18
	public bool isStarted; // 0x20
	public List<Item> itemsToGive; // 0x28
	public List<Item> itemsToReceive; // 0x30
	public bool readyStatusMe; // 0x38
	public bool readyStatusThem; // 0x39
	public bool isConfirming; // 0x3A
	public bool? isAcceptedByMe; // 0x3B
	public bool? isAcceptedByThem; // 0x3D
	public string chatConversationId; // 0x40

	// Constructors
	public Trade(); // 0x000000018050D7F0-0x000000018050D880
}


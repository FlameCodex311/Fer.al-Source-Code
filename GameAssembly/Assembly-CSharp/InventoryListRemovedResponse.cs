/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InventoryListRemovedResponse : ServerMessage // TypeDefIndex: 11194
{
	// Fields
	public readonly string[] RemovedItemIds; // 0x30

	// Constructors
	public InventoryListRemovedResponse(INetMessageReader data); // 0x0000000180F629B0-0x0000000180F62A70
	public InventoryListRemovedResponse(List<Item> inItems); // 0x0000000180F62860-0x0000000180F629B0
}


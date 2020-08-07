/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InventoryListRemovedResponse : ServerMessage // TypeDefIndex: 12720
{
	// Fields
	public readonly string[] RemovedItemIds; // 0x30

	// Constructors
	public InventoryListRemovedResponse(INetMessageReader data); // 0x000000018062BD50-0x000000018062BE10
	public InventoryListRemovedResponse(List<Item> inItems); // 0x000000018062BC00-0x000000018062BD50
}


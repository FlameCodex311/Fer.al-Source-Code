/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InventoryListResponse : ServerMessage // TypeDefIndex: 11192
{
	// Fields
	public readonly List<Item> Items; // 0x30
	public readonly List<JsonData> ItemsJson; // 0x38

	// Constructors
	public InventoryListResponse(INetMessageReader data); // 0x0000000180F62B10-0x0000000180F62EE0
	public InventoryListResponse(List<Item> inItems); // 0x0000000180F62A70-0x0000000180F62B10
}


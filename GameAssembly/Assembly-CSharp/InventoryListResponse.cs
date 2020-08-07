/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InventoryListResponse : ServerMessage // TypeDefIndex: 12718
{
	// Fields
	public readonly List<Item> Items; // 0x30
	public readonly List<JsonData> ItemsJson; // 0x38

	// Constructors
	public InventoryListResponse(INetMessageReader data); // 0x000000018086ECF0-0x000000018086F0B0
	public InventoryListResponse(List<Item> inItems); // 0x000000018086EC50-0x000000018086ECF0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ItemAddedToTradeMessage : TradeMessage // TypeDefIndex: 11389
{
	// Fields
	public readonly Item Item; // 0x20
	public readonly string ItemOwnerUUID; // 0x28

	// Properties
	public bool ItemOwnerIsMe { get; } // 0x00000001812BE6D0-0x00000001812BE710 

	// Constructors
	public ItemAddedToTradeMessage(Trade inTrade, Item inItem, string inItemOwnerUUID); // 0x00000001812BE690-0x00000001812BE6D0
}


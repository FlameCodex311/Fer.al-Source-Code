/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ItemRemovedFromTradeMessage : TradeMessage // TypeDefIndex: 12922
{
	// Fields
	public readonly Item Item; // 0x20
	public readonly string ItemOwnerUUID; // 0x28

	// Properties
	public bool ItemOwnerIsMe { get; } // 0x0000000180878160-0x00000001808781A0 

	// Constructors
	public ItemRemovedFromTradeMessage(Trade inTrade, Item inItem, string inItemOwnerUUID); // 0x0000000180878120-0x0000000180878160
}


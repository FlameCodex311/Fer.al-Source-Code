/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TradeAddRemoveItemResponse : ServerMessage // TypeDefIndex: 11402
{
	// Fields
	public bool Success; // 0x30
	public string UserId; // 0x38
	public bool IsAdding; // 0x40
	public Item UpdatedItem; // 0x48
	public int Quantity; // 0x50

	// Constructors
	public TradeAddRemoveItemResponse(INetMessageReader data); // 0x0000000180FA45E0-0x0000000180FA4780
}


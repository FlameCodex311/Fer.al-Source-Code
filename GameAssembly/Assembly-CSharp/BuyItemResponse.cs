/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x000000018024F4A0-0x000000018024F4C0
public class BuyItemResponse : ServerMessage // TypeDefIndex: 12907
{
	// Fields
	public readonly PurchaseResult Result; // 0x30
	public readonly string[] ItemIds; // 0x38
	public readonly string[] RareItemIds; // 0x40
	public readonly int PurchaseCount; // 0x48
	public readonly int RareItemCount; // 0x4C

	// Properties
	public bool Success { get; } // 0x0000000180498F00-0x0000000180498F10 

	// Constructors
	public BuyItemResponse(INetMessageReader data); // 0x0000000180498DC0-0x0000000180498F00
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018016C1D0-0x000000018016C1F0
public class BuyItemResponse : ServerMessage // TypeDefIndex: 11375
{
	// Fields
	public readonly PurchaseResult Result; // 0x30
	public readonly string[] ItemIds; // 0x38
	public readonly string[] RareItemIds; // 0x40
	public readonly int PurchaseCount; // 0x48
	public readonly int RareItemCount; // 0x4C

	// Properties
	public bool Success { get; } // 0x00000001804785C0-0x00000001804785D0 

	// Constructors
	public BuyItemResponse(INetMessageReader data); // 0x00000001810205E0-0x00000001810206C0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TradeRequestEndedMessage : TradeMessage // TypeDefIndex: 11385
{
	// Fields
	public readonly Reason reason; // 0x20

	// Nested types
	public enum Reason // TypeDefIndex: 11386
	{
		Cancelled = 0,
		Rejected = 1,
		Timeout = 2,
		UserNotAvailable = 3
	}

	// Constructors
	public TradeRequestEndedMessage(Trade inTrade, Reason inReason); // 0x0000000180F62670-0x0000000180F626B0
}


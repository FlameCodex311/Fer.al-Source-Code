/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TradeRequestEndedMessage : TradeMessage // TypeDefIndex: 12917
{
	// Fields
	public readonly Reason reason; // 0x20

	// Nested types
	public enum Reason // TypeDefIndex: 12918
	{
		Cancelled = 0,
		Rejected = 1,
		Timeout = 2,
		UserNotAvailable = 3
	}

	// Constructors
	public TradeRequestEndedMessage(Trade inTrade, Reason inReason); // 0x000000018050C7F0-0x000000018050C830
}


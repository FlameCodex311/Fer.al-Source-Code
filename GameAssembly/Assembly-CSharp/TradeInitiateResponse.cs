/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TradeInitiateResponse : ServerMessage // TypeDefIndex: 12929
{
	// Fields
	public readonly TradeValidationType tradeValidationType; // 0x30
	public string userId; // 0x38

	// Properties
	public bool Success { get; } // 0x0000000180509E50-0x0000000180509E60 

	// Constructors
	public TradeInitiateResponse(INetMessageReader data); // 0x0000000180509D00-0x0000000180509E50
}


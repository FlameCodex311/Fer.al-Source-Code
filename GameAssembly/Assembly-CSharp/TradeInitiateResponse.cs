/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TradeInitiateResponse : ServerMessage // TypeDefIndex: 11397
{
	// Fields
	public readonly TradeValidationType tradeValidationType; // 0x30
	public string userId; // 0x38

	// Properties
	public bool Success { get; } // 0x0000000180892B50-0x0000000180892B60 

	// Constructors
	public TradeInitiateResponse(INetMessageReader data); // 0x0000000180FA4910-0x0000000180FA4A70
}


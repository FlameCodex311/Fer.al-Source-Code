/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TradeReadyAcceptResponse : ServerMessage // TypeDefIndex: 11404
{
	// Fields
	public bool Success; // 0x30
	public bool WaitingOnOtherPlayer; // 0x31
	public Dictionary<string, string> AddedItems; // 0x38

	// Constructors
	public TradeReadyAcceptResponse(INetMessageReader data); // 0x0000000180FA7170-0x0000000180FA7270
}


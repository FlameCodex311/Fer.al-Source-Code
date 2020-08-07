/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TradeReadyAcceptResponse : ServerMessage // TypeDefIndex: 12936
{
	// Fields
	public bool Success; // 0x30
	public bool WaitingOnOtherPlayer; // 0x31
	public Dictionary<string, string> AddedItems; // 0x38

	// Constructors
	public TradeReadyAcceptResponse(INetMessageReader data); // 0x000000018050C650-0x000000018050C750
}


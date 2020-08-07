/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UserReadyStateChangedMessage : TradeMessage // TypeDefIndex: 12923
{
	// Fields
	public readonly bool IsReady; // 0x20
	public readonly string UserUUID; // 0x28

	// Properties
	public bool UserIsMe { get; } // 0x000000018066BB50-0x000000018066BBC0 

	// Constructors
	public UserReadyStateChangedMessage(Trade inTrade, bool inIsReady, string inUserUUID); // 0x000000018066BB10-0x000000018066BB50
}


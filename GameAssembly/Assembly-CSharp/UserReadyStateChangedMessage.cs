/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UserReadyStateChangedMessage : TradeMessage // TypeDefIndex: 11391
{
	// Fields
	public readonly bool IsReady; // 0x20
	public readonly string UserUUID; // 0x28

	// Properties
	public bool UserIsMe { get; } // 0x000000018121FD00-0x000000018121FD70 

	// Constructors
	public UserReadyStateChangedMessage(Trade inTrade, bool inIsReady, string inUserUUID); // 0x000000018121FCC0-0x000000018121FD00
}


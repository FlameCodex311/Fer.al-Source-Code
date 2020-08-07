/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x000000018020DF80-0x000000018020DFA0
public class InspirationCombineResponse : ServerMessage // TypeDefIndex: 12727
{
	// Fields
	public readonly Status CombineStatus; // 0x30
	public readonly string EnigmaDefId; // 0x38

	// Nested types
	public enum Status // TypeDefIndex: 12728
	{
		SUCCESS = 0,
		ALREADY_OWNED = 1,
		INVALID_COMBO = 2
	}

	// Constructors
	public InspirationCombineResponse(INetMessageReader data); // 0x00000001806262B0-0x0000000180626360
}


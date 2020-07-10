/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180129B80-0x0000000180129BA0
public class InspirationCombineResponse : ServerMessage // TypeDefIndex: 11201
{
	// Fields
	public readonly Status CombineStatus; // 0x30
	public readonly string EnigmaDefId; // 0x38

	// Nested types
	public enum Status // TypeDefIndex: 11202
	{
		SUCCESS = 0,
		ALREADY_OWNED = 1,
		INVALID_COMBO = 2
	}

	// Constructors
	public InspirationCombineResponse(INetMessageReader data); // 0x0000000180F5CE30-0x0000000180F5CEE0
}


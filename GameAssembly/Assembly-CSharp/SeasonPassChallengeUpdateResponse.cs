/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018016BD80-0x000000018016BDA0
public class SeasonPassChallengeUpdateResponse : ServerMessage // TypeDefIndex: 11370
{
	// Fields
	public readonly int progressCount; // 0x30
	public readonly string challengeUUID; // 0x38
	public readonly string defId; // 0x40
	public readonly int requiredCount; // 0x48

	// Constructors
	public SeasonPassChallengeUpdateResponse(INetMessageReader data); // 0x0000000180EBCCD0-0x0000000180EBCD80
}


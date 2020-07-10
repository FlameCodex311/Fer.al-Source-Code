/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018016BFC0-0x000000018016BFE0
public class SeasonPassChallengeCompleteResponse : ServerMessage // TypeDefIndex: 11371
{
	// Fields
	public readonly int auraPointsAwarded; // 0x30
	public readonly string challengeUUID; // 0x38
	public readonly string defId; // 0x40
	public readonly bool hasNewChallenge; // 0x48
	public readonly string newChallengeUUID; // 0x50
	public readonly string newChallengeDefId; // 0x58

	// Constructors
	public SeasonPassChallengeCompleteResponse(INetMessageReader data); // 0x0000000180EBCA70-0x0000000180EBCB60
}


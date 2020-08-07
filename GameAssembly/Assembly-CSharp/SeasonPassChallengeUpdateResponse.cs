/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x000000018024EE70-0x000000018024EE90
public class SeasonPassChallengeUpdateResponse : ServerMessage // TypeDefIndex: 12900
{
	// Fields
	public readonly int progressCount; // 0x30
	public readonly string challengeUUID; // 0x38
	public readonly string defId; // 0x40
	public readonly int requiredCount; // 0x48

	// Constructors
	public SeasonPassChallengeUpdateResponse(INetMessageReader data); // 0x00000001803FB460-0x00000001803FB510
}


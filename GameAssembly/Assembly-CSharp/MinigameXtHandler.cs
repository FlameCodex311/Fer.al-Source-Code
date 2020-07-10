/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class MinigameXtHandler // TypeDefIndex: 11224
{
	// Nested types
	public enum MinigamePrizeOperation // TypeDefIndex: 11225
	{
		SelectAndRedeem = 0,
		Select = 1,
		Redeem = 2
	}

	// Methods
	[DebugButton] // 0x0000000180131F00-0x0000000180131F60
	public static void DebugJoinMinigame(string inDefId); // 0x00000001810AF5B0-0x00000001810AF630
	[MessageSender] // 0x00000001801320D0-0x00000001801320F0
	public static void RequestJoin(string defId); // 0x00000001810AF5B0-0x00000001810AF630
	public static void RequestMinigamePrize(string defId, int stage, MinigamePrizeOperation op, int prizeIndex1 = 0 /* Metadata: 0x00782825 */, int prizeIndex2 = 0 /* Metadata: 0x00782829 */); // 0x00000001810AF9C0-0x00000001810AFB10
	public static void RequestMinigameProgress(string inMinigameDefId, int inLevelProgress, int inScoreProgress); // 0x00000001810AFB10-0x00000001810AFBF0
	public static void SendMessage(string[] inArgs); // 0x00000001810AFBF0-0x00000001810AFCE0
	[MessageRoute] // 0x0000000180132270-0x0000000180132290
	private static void HandleMinigamePrizeMessage(MinigamePrizeMessage msg); // 0x00000001810AF830-0x00000001810AF950
	[MessageRoute] // 0x0000000180132410-0x0000000180132430
	public static void HandleMMMessage(ParlorGameMessage msg); // 0x00000001810AF630-0x00000001810AF6B0
	[MessageRoute] // 0x0000000180132640-0x0000000180132660
	public static void HandleMinigameJoinMessage(MinigameJoinResponseMessage msg); // 0x00000001810AF6B0-0x00000001810AF830
	[MessageRoute] // 0x0000000180132770-0x0000000180132790
	public static void HandleMinigameStartMessage(MinigameStartResponseMessage msg); // 0x00000001810AF950-0x00000001810AF9C0
	[MessageRoute] // 0x00000001801329E0-0x0000000180132A00
	public static void HandleMinigameCurrenceyMessage(MinigameCurrencyResponseMessage msg); // 0x00000001803581E0-0x00000001803581F0
}


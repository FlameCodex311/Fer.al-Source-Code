/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class MinigameXtHandler // TypeDefIndex: 12750
{
	// Nested types
	public enum MinigamePrizeOperation // TypeDefIndex: 12751
	{
		SelectAndRedeem = 0,
		Select = 1,
		Redeem = 2
	}

	// Methods
	[DebugButton] // 0x0000000180218430-0x0000000180218490
	public static void DebugJoinMinigame(string inDefId); // 0x0000000180BFE950-0x0000000180BFE9D0
	[MessageSender] // 0x00000001802185F0-0x0000000180218610
	public static void RequestJoin(string defId); // 0x0000000180BFE950-0x0000000180BFE9D0
	public static void RequestMinigamePrize(string defId, int stage, MinigamePrizeOperation op, int prizeIndex1 = 0 /* Metadata: 0x007B9FAB */, int prizeIndex2 = 0 /* Metadata: 0x007B9FAF */); // 0x0000000180BFEDC0-0x0000000180BFEF00
	public static void RequestMinigameProgress(string inMinigameDefId, int inLevelProgress, int inTotalScore, int inDeltaScore); // 0x0000000180BFEF00-0x0000000180BFF010
	public static void SendMessage(string[] inArgs); // 0x0000000180BFF010-0x0000000180BFF100
	[MessageRoute] // 0x0000000180218780-0x00000001802187A0
	private static void HandleMinigamePrizeMessage(MinigamePrizeMessage msg); // 0x0000000180BFEC30-0x0000000180BFED50
	[MessageRoute] // 0x00000001802188B0-0x00000001802188D0
	public static void HandleMMMessage(MinigameMessageResponseMessage msg); // 0x0000000180BFE9D0-0x0000000180BFEAB0
	[MessageRoute] // 0x0000000180218A70-0x0000000180218A90
	public static void HandleMinigameJoinMessage(MinigameJoinResponseMessage msg); // 0x0000000180BFEAB0-0x0000000180BFEC30
	[MessageRoute] // 0x0000000180218CF0-0x0000000180218D10
	public static void HandleMinigameStartMessage(MinigameStartResponseMessage msg); // 0x0000000180BFED50-0x0000000180BFEDC0
	[MessageRoute] // 0x0000000180218E90-0x0000000180218EB0
	public static void HandleMinigameCurrenceyMessage(MinigameCurrencyResponseMessage msg); // 0x00000001803774A0-0x00000001803774B0
}


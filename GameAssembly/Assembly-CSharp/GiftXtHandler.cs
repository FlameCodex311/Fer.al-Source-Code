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
public static class GiftXtHandler // TypeDefIndex: 12698
{
	// Methods
	[DebugButton] // 0x0000000180200FC0-0x0000000180201020
	public static void DebugButtonGiftEric1(string defId); // 0x0000000180682110-0x0000000180682150
	[DebugButton] // 0x0000000180202470-0x00000001802024D0
	public static void DebugButtonGiftEric2(string defId); // 0x0000000180682150-0x0000000180682190
	[MessageSender] // 0x0000000180202640-0x0000000180202660
	public static void RequestGiveGiftDEBUG(string userId, string defId, ItemType itemType); // 0x00000001806821F0-0x0000000180682380
	[MessageSender] // 0x00000001802027E0-0x0000000180202800
	public static void RequestRedeemGift(string itemId, bool accepted); // 0x0000000180682380-0x0000000180682430
	[MessageRoute] // 0x0000000180202A60-0x0000000180202A80
	private static void HandleGiftPush(GiftPushMessage message); // 0x0000000180682190-0x00000001806821F0
}


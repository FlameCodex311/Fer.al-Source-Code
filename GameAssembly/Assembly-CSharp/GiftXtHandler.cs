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
public static class GiftXtHandler // TypeDefIndex: 11172
{
	// Methods
	[DebugButton] // 0x000000018011E2B0-0x000000018011E310
	public static void DebugButtonGiftEric1(string defId); // 0x0000000181056A10-0x0000000181056A50
	[DebugButton] // 0x000000018011E430-0x000000018011E490
	public static void DebugButtonGiftEric2(string defId); // 0x0000000181056A50-0x0000000181056A90
	[MessageSender] // 0x000000018011E670-0x000000018011E690
	public static void RequestGiveGiftDEBUG(string userId, string defId, ItemType itemType); // 0x0000000181056AF0-0x0000000181056C90
	[MessageSender] // 0x000000018011E770-0x000000018011E790
	public static void RequestRedeemGift(string itemId, bool accepted); // 0x0000000181056C90-0x0000000181056D40
	[MessageRoute] // 0x000000018011EA00-0x000000018011EA20
	private static void HandleGiftPush(GiftPushMessage message); // 0x0000000181056A90-0x0000000181056AF0
}


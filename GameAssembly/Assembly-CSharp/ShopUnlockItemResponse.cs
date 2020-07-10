/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018016E140-0x000000018016E160
public class ShopUnlockItemResponse : ServerMessage, ISuccessMessage // TypeDefIndex: 11378
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <Success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <ShopId>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string[] <ItemsUnlocked>k__BackingField; // 0x40

	// Properties
	public bool Success { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048B840-0x000000018048B850 0x000000018048B850-0x000000018048B860
	public string ShopId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	public string[] ItemsUnlocked { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820

	// Constructors
	public ShopUnlockItemResponse(INetMessageReader data); // 0x0000000180EC2340-0x0000000180EC23E0

	// Methods
	[MessageRoute] // 0x000000018016E140-0x000000018016E160
	public static void HandleShopUnlockItemResponse(ShopUnlockItemResponse response); // 0x00000001803581E0-0x00000001803581F0
}


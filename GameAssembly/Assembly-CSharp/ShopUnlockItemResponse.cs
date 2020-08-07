/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x00000001802519D0-0x00000001802519F0
public class ShopUnlockItemResponse : ServerMessage, ISuccessMessage // TypeDefIndex: 12910
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <Success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <ShopId>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string[] <ItemsUnlocked>k__BackingField; // 0x40

	// Properties
	public bool Success { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180455C10-0x0000000180455C20
	public string ShopId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	public string[] ItemsUnlocked { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0

	// Constructors
	public ShopUnlockItemResponse(INetMessageReader data); // 0x000000018076BE50-0x000000018076BEF0

	// Methods
	[MessageRoute] // 0x00000001802519D0-0x00000001802519F0
	public static void HandleShopUnlockItemResponse(ShopUnlockItemResponse response); // 0x00000001803774A0-0x00000001803774B0
}


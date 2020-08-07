/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x000000018024F6C0-0x000000018024F6E0
public class ShopListResponse : ServerMessage // TypeDefIndex: 12908
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <ShopDefId>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string[] <ShopItemIds>k__BackingField; // 0x38

	// Properties
	public int ShopDefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
	public string[] ShopItemIds { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70

	// Constructors
	public ShopListResponse(INetMessageReader data); // 0x000000018076B580-0x000000018076B660
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018016C380-0x000000018016C3A0
public class ShopListResponse : ServerMessage // TypeDefIndex: 11376
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <ShopDefId>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string[] <ShopItemIds>k__BackingField; // 0x38

	// Properties
	public int ShopDefId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018043DDC0-0x000000018043DDD0 0x000000018036B7A0-0x000000018036B7F0
	public string[] ShopItemIds { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830

	// Constructors
	public ShopListResponse(INetMessageReader data); // 0x0000000180EC1AD0-0x0000000180EC1B50
}


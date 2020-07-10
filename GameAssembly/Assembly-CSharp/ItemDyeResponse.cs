/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180129640-0x0000000180129660
public class ItemDyeResponse : ServerMessage, ITaggedMessage, ISuccessMessage // TypeDefIndex: 11200
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly bool <Success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private readonly string <ItemId>k__BackingField; // 0x38

	// Properties
	public bool Success { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018048B840-0x000000018048B850 
	public string ItemId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180369BB0-0x0000000180369BC0 

	// Constructors
	public ItemDyeResponse(INetMessageReader data); // 0x00000001812BEB70-0x00000001812BEBF0

	// Methods
	public string GetTag(); // 0x0000000180369BB0-0x0000000180369BC0
}


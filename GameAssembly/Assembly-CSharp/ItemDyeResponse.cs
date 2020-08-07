/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x000000018020C2A0-0x000000018020C2C0
public class ItemDyeResponse : ServerMessage, ITaggedMessage, ISuccessMessage // TypeDefIndex: 12726
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly bool <Success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private readonly string <ItemId>k__BackingField; // 0x38

	// Properties
	public bool Success { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180455B90-0x0000000180455BA0 
	public string ItemId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803743D0-0x00000001803743E0 

	// Constructors
	public ItemDyeResponse(INetMessageReader data); // 0x0000000180878600-0x0000000180878680

	// Methods
	public string GetTag(); // 0x00000001803743D0-0x00000001803743E0
}


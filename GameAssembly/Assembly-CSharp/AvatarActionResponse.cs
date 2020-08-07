/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x0000000180231D20-0x0000000180231D40
public class AvatarActionResponse : ServerMessage // TypeDefIndex: 12816
{
	// Fields
	public readonly string actionDefId; // 0x30

	// Properties
	public bool Success { get; } // 0x00000001803F73F0-0x00000001803F7410 

	// Constructors
	public AvatarActionResponse(INetMessageReader data); // 0x0000000182157B90-0x0000000182157C00
}


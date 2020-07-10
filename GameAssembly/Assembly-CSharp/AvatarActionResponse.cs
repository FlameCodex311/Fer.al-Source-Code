/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180148D30-0x0000000180148D50
public class AvatarActionResponse : ServerMessage // TypeDefIndex: 11288
{
	// Fields
	public readonly string actionDefId; // 0x30

	// Properties
	public bool Success { get; } // 0x000000018103EBA0-0x000000018103EBC0 

	// Constructors
	public AvatarActionResponse(INetMessageReader data); // 0x000000018103EB30-0x000000018103EBA0
}


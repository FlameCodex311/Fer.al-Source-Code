/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180173AA0-0x0000000180173AC0
public class WorldObjectDeleteMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 11418
{
	// Fields
	public readonly string ObjectId; // 0x30

	// Constructors
	public WorldObjectDeleteMessage(INetMessageReader data); // 0x0000000181000650-0x00000001810006C0

	// Methods
	public string GetTag(); // 0x00000001810001A0-0x00000001810001D0
}


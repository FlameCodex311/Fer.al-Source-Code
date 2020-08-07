/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x0000000180255920-0x0000000180255940
public class WorldObjectDeleteMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 12951
{
	// Fields
	public readonly string ObjectId; // 0x30

	// Constructors
	public WorldObjectDeleteMessage(INetMessageReader data); // 0x00000001805E7950-0x00000001805E79C0

	// Methods
	public string GetTag(); // 0x00000001805E74D0-0x00000001805E7500
}


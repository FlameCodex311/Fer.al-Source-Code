/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180173C40-0x0000000180173C60
public class WorldObjectBroadcastMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 11419
{
	// Fields
	public readonly string SubCmd; // 0x30
	public readonly string ObjectId; // 0x38
	public readonly string QuestDefId; // 0x40

	// Constructors
	public WorldObjectBroadcastMessage(INetMessageReader data); // 0x0000000181000530-0x00000001810005F0

	// Methods
	public string GetTag(); // 0x0000000181000500-0x0000000181000530
}


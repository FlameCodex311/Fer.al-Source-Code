/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x0000000180255A90-0x0000000180255AB0
public class WorldObjectBroadcastMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 12952
{
	// Fields
	public readonly string SubCmd; // 0x30
	public readonly string ObjectId; // 0x38
	public readonly string QuestDefId; // 0x40

	// Constructors
	public WorldObjectBroadcastMessage(INetMessageReader data); // 0x00000001805E7840-0x00000001805E78F0

	// Methods
	public string GetTag(); // 0x00000001805E7810-0x00000001805E7840
}


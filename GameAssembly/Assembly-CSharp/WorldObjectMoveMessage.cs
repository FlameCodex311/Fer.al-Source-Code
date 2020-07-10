/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldObjectMoveMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 11412
{
	// Fields
	public readonly string ObjectId; // 0x30
	public readonly WorldObjectMoveNodeData Node; // 0x38

	// Constructors
	public WorldObjectMoveMessage(WorldObjectMoveNodeData inNode, INetMessageReader data); // 0x00000001810024B0-0x0000000181002500
	public WorldObjectMoveMessage(INetMessageReader data); // 0x0000000181002500-0x00000001810025A0

	// Methods
	public string GetTag(); // 0x00000001810001A0-0x00000001810001D0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldObjectActionStartMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 12947
{
	// Fields
	public readonly string ObjectId; // 0x30
	public readonly string userUUID; // 0x38

	// Constructors
	public WorldObjectActionStartMessage(INetMessageReader data); // 0x00000001805E7790-0x00000001805E7810

	// Methods
	public string GetTag(); // 0x00000001805E74D0-0x00000001805E7500
}


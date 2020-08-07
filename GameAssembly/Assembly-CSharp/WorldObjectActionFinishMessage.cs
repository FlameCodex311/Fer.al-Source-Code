/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldObjectActionFinishMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 12950
{
	// Fields
	public readonly string ObjectId; // 0x30
	public readonly InteractableState interactableState; // 0x38

	// Constructors
	public WorldObjectActionFinishMessage(INetMessageReader data); // 0x00000001805E7570-0x00000001805E7710

	// Methods
	public string GetTag(); // 0x00000001805E74D0-0x00000001805E7500
}


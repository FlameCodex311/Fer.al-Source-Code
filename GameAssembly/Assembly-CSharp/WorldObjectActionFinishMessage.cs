/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldObjectActionFinishMessage : ServerMessage, ITaggedMessage // TypeDefIndex: 11417
{
	// Fields
	public readonly string ObjectId; // 0x30
	public readonly InteractableState interactableState; // 0x38

	// Constructors
	public WorldObjectActionFinishMessage(INetMessageReader data); // 0x0000000181000240-0x00000001810003E0

	// Methods
	public string GetTag(); // 0x00000001810001A0-0x00000001810001D0
}


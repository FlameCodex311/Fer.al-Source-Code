/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x0000000180173DE0-0x0000000180173E00
public class WorldObjectInfoMessage : ServerMessage // TypeDefIndex: 11421
{
	// Fields
	public readonly string Id; // 0x30
	public readonly string DefId; // 0x38
	public readonly string OwnerId; // 0x40
	public readonly WorldObjectMoveNodeData LastMove; // 0x48

	// Constructors
	public WorldObjectInfoMessage(INetMessageReader data); // 0x00000001810006C0-0x0000000181000790
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x0000000180255BA0-0x0000000180255BC0
public class WorldObjectInfoMessage : ServerMessage // TypeDefIndex: 12954
{
	// Fields
	public readonly string Id; // 0x30
	public readonly string DefId; // 0x38
	public readonly string OwnerId; // 0x40
	public readonly WorldObjectMoveNodeData LastMove; // 0x48

	// Constructors
	public WorldObjectInfoMessage(INetMessageReader data); // 0x00000001805E79C0-0x00000001805E7A90
}


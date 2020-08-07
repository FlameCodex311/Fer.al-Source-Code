/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public struct WorldObjectMoveNodeData // TypeDefIndex: 12944
{
	// Fields
	public WorldObjectMoverNodeType nodeType; // 0x00
	public long serverTime; // 0x08
	public Vector3 position; // 0x10
	public Vector3 direction; // 0x1C
	public Quaternion rotation; // 0x28
	public float speed; // 0x38
	public ActorActionType actionType; // 0x3C

	// Methods
	public static WorldObjectMoveNodeData Read(INetMessageReader data); // 0x00000001805E9830-0x00000001805E9C50
}


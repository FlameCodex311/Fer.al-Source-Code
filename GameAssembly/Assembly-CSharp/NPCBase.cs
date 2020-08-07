/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NPCBase : ActorBase // TypeDefIndex: 12383
{
	// Fields
	private BaseDef _npcDef; // 0x3F0
	private string _cachedActorName; // 0x3F8

	// Properties
	public BaseDef NPCDef { get; set; } // 0x00000001807C9B20-0x00000001807C9B30 0x00000001807C9B30-0x00000001807C9B40
	public override string ActorName { get; } // 0x00000001807C99F0-0x00000001807C9B20 

	// Constructors
	public NPCBase(); // 0x00000001807C9990-0x00000001807C99F0

	// Methods
	public static NPCBase CreateNPC(string inWorldObjectDefID, BaseDef inNPCDef, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback, bool inUseBubble = true /* Metadata: 0x007B97B9 */); // 0x00000001807C9810-0x00000001807C9990
}


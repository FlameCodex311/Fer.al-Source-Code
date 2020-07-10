/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NPCBase : ActorBase // TypeDefIndex: 11446
{
	// Fields
	private BaseDef _npcDef; // 0x3E8
	private string _cachedActorName; // 0x3F0

	// Properties
	public BaseDef NPCDef { get; set; } // 0x00000001812E4000-0x00000001812E4010 0x00000001812E4010-0x00000001812E4020
	public override string ActorName { get; } // 0x00000001812E3EC0-0x00000001812E4000 

	// Constructors
	public NPCBase(); // 0x00000001812E3E60-0x00000001812E3EC0

	// Methods
	public static NPCBase CreateNPC(string inWorldObjectDefID, BaseDef inNPCDef, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback, bool inUseBubble = true /* Metadata: 0x00782A1C */); // 0x00000001812E3CE0-0x00000001812E3E60
}


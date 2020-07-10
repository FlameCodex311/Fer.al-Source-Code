/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class CachedInstanceGroup // TypeDefIndex: 10660
{
	// Fields
	public string editorGroupName; // 0x10
	[NonSerialized]
	public ActorCacheGroup cacheGroup; // 0x18
	public Transform transform; // 0x20
	public bool useReferences; // 0x28
	public int maxCount; // 0x2C
	public float timeout; // 0x30
	public List<string> pendingHashes; // 0x38
	public List<ActorCachedInstance> instances; // 0x40

	// Properties
	public ActorCacheGroup ActorCacheGroup { get; set; } // 0x0000000180367710-0x0000000180367720 0x0000000181023190-0x0000000181023220

	// Constructors
	public CachedInstanceGroup(); // 0x00000001810230F0-0x0000000181023190
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class CachedInstanceGroup // TypeDefIndex: 12163
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
	public ActorCacheGroup ActorCacheGroup { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x000000018049BA60-0x000000018049BAF0

	// Constructors
	public CachedInstanceGroup(); // 0x000000018049B9C0-0x000000018049BA60
}


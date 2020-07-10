/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActorCacheManager : SingletonManagerBase<ActorCacheManager> // TypeDefIndex: 10662
{
	// Fields
	public List<CachedInstanceGroup> _cachedInstanceGroups; // 0x60
	[NonSerialized]
	private static GameObject _cacheGroupGameObject; // 0x00

	// Properties
	public static GameObject CacheGroupGameObject { get; } // 0x0000000181403630-0x00000001814036B0 

	// Constructors
	public ActorCacheManager(); // 0x00000001814035C0-0x0000000181403630

	// Methods
	private static void CreateCacheGroupGameObject(); // 0x0000000181402310-0x00000001814025C0
	public void ClearCache(); // 0x0000000181402150-0x0000000181402310
	public override void Init(); // 0x0000000181402A10-0x0000000181402E00
	private CachedInstanceGroup GetCachedInstanceGroup(ActorCacheGroup inGroup); // 0x0000000181402670-0x0000000181402760
	public ActorCachedInstance GetCachedInstanceWithHash(ActorCacheGroup inGroup, string inHash); // 0x0000000181402760-0x0000000181402860
	public void SetInstanceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inInstance, bool inClone); // 0x00000001814032E0-0x0000000181403520
	public GameObject GetNewInstanceWithHash(ActorCacheGroup inGroup, string inHash); // 0x0000000181402860-0x0000000181402940
	public GameObject GetReferenceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inReference); // 0x0000000181402940-0x0000000181402A10
	public void DereferenceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inReference); // 0x00000001814025C0-0x0000000181402670
	public void SetPendingWithHash(ActorCacheGroup inGroup, string inHash); // 0x0000000181403520-0x00000001814035C0
	public void RemovePendingWithHash(ActorCacheGroup inGroup, string inHash); // 0x0000000181403240-0x00000001814032E0
	public bool IsPendingWithHash(ActorCacheGroup inGroup, string inHash); // 0x0000000181402E00-0x0000000181402E80
	public override void MUpdate(); // 0x0000000181402E80-0x0000000181403240
}


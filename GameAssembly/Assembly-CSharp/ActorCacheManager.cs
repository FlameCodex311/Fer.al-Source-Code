/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActorCacheManager : SingletonManagerBase<ActorCacheManager> // TypeDefIndex: 12165
{
	// Fields
	public List<CachedInstanceGroup> _cachedInstanceGroups; // 0x60
	[NonSerialized]
	private static GameObject _cacheGroupGameObject; // 0x00

	// Properties
	public static GameObject CacheGroupGameObject { get; } // 0x00000001821D5410-0x00000001821D5490 

	// Constructors
	public ActorCacheManager(); // 0x00000001821D53A0-0x00000001821D5410

	// Methods
	private static void CreateCacheGroupGameObject(); // 0x00000001821D4150-0x00000001821D43F0
	public void ClearCache(); // 0x00000001821D3F90-0x00000001821D4150
	public override void Init(); // 0x00000001821D4830-0x00000001821D4C00
	private CachedInstanceGroup GetCachedInstanceGroup(ActorCacheGroup inGroup); // 0x00000001821D44A0-0x00000001821D4580
	public ActorCachedInstance GetCachedInstanceWithHash(ActorCacheGroup inGroup, string inHash); // 0x00000001821D4580-0x00000001821D4680
	public void SetInstanceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inInstance, bool inClone); // 0x00000001821D50D0-0x00000001821D5300
	public GameObject GetNewInstanceWithHash(ActorCacheGroup inGroup, string inHash); // 0x00000001821D4680-0x00000001821D4760
	public GameObject GetReferenceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inReference); // 0x00000001821D4760-0x00000001821D4830
	public void DereferenceWithHash(ActorCacheGroup inGroup, string inHash, GameObject inReference); // 0x00000001821D43F0-0x00000001821D44A0
	public void SetPendingWithHash(ActorCacheGroup inGroup, string inHash); // 0x00000001821D5300-0x00000001821D53A0
	public void RemovePendingWithHash(ActorCacheGroup inGroup, string inHash); // 0x00000001821D5030-0x00000001821D50D0
	public bool IsPendingWithHash(ActorCacheGroup inGroup, string inHash); // 0x00000001821D4C00-0x00000001821D4C80
	public override void MUpdate(); // 0x00000001821D4C80-0x00000001821D5030
}


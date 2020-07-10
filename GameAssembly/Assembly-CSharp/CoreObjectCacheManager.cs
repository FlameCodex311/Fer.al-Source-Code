/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreObjectCacheManager : CoreManagerBase<CoreObjectCacheManager> // TypeDefIndex: 13486
{
	// Fields
	public List<CachedObject> _cachedObjects; // 0x60
	private string _forcedCachedPrefix; // 0x68
	private int _fixDuplicateCache; // 0x70

	// Nested types
	[Serializable]
	public class CachedObject // TypeDefIndex: 13487
	{
		// Fields
		public string bundleID; // 0x10
		public bool forceCachedTexture; // 0x18
		public UnityEngine.Object objectReference; // 0x20
		public List<GameObject> gameObjectReferences; // 0x28
		public bool manualUnload; // 0x30
		public BundleLoadType bundleLoadType; // 0x34
		public string bundlePath; // 0x38
		public AssetQualityLevel qualityLevel; // 0x40

		// Constructors
		public CachedObject(); // 0x000000018130C970-0x000000018130C9D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetAndSetCachedTexture>d__6<T> : IEnumerator<object> // TypeDefIndex: 13488
		where T : UnityEngine.Object
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public GameObject inGameObjectReference;
		public UnityEngine.Object inObject;
		public CoreObjectCacheManager <>4__this;
		public Action<T> inObjectCallback;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetAndSetCachedTexture>d__6(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0<T> // TypeDefIndex: 13489
		where T : UnityEngine.Object
	{
		// Fields
		public T cachedObject;

		// Constructors
		public <>c__DisplayClass8_0();

		// Methods
		internal void <GetCachedObject>b__0(T loadedObject);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetCachedObject>d__8<T> : IEnumerator<object> // TypeDefIndex: 13490
		where T : UnityEngine.Object
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public GameObject inGameObjectReference;
		public string inPriorBundleID;
		public AssetQualityLevel inQuality;
		public CoreObjectCacheManager <>4__this;
		public string inBundleID;
		public Action<T> inObjectCallback;
		public BundleLoadType inBundleLoadType;
		public BundleQueue inBundleQueue;
		public bool inManualBundleUnload;
		private <>c__DisplayClass8_0<T> <>8__1;
		private string <storedBundleID>5__2;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetCachedObject>d__8(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CacheRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 13491
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreObjectCacheManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CacheRoutine>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181324740-0x0000000181324A10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181324A10-0x0000000181324A60
	}

	// Constructors
	public CoreObjectCacheManager(); // 0x0000000181319760-0x00000001813197D0

	// Methods
	public override void MStart(); // 0x00000001813196F0-0x0000000181319760
	public override void MOnDestroy(); // 0x0000000181319580-0x00000001813196F0
	private string GetStoredBundleID(string inBundleID, AssetQualityLevel inQuality, Type inType); // 0x00000001813193C0-0x0000000181319580
	[IteratorStateMachine] // 0x000000018016BA20-0x000000018016BA70
	public IEnumerator GetAndSetCachedTexture<T>(UnityEngine.Object inObject, GameObject inGameObjectReference, Action<T> inObjectCallback = null)
		where T : UnityEngine.Object;
	private void DestroyForcedCachedObject(CachedObject inCachedObject); // 0x00000001813190B0-0x0000000181319120
	[IteratorStateMachine] // 0x000000018016BCD0-0x000000018016BD20
	public IEnumerator GetCachedObject<T>(string inBundleID, GameObject inGameObjectReference, BundleLoadType inBundleLoadType, BundleQueue inBundleQueue, Action<T> inObjectCallback = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783D93 */, string inPriorBundleID = "" /* Metadata: 0x00783D97 */, bool inManualBundleUnload = false /* Metadata: 0x00783D9B */)
		where T : UnityEngine.Object;
	public void ClearCachedObject(string inBundleID, AssetQualityLevel inQuality, Type inType, GameObject inGameObjectReference); // 0x0000000181318DD0-0x0000000181318F10
	public void ClearCachedObject(GameObject inGameObjectReference); // 0x0000000181318F10-0x00000001813190B0
	[IteratorStateMachine] // 0x000000018016C080-0x000000018016C0D0
	private IEnumerator CacheRoutine(); // 0x0000000181318D70-0x0000000181318DD0
	private void FixDuplicateCache(int inIdx); // 0x0000000181319120-0x00000001813193C0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreObjectCacheManager : CoreManagerBase<CoreObjectCacheManager> // TypeDefIndex: 11157
{
	// Fields
	public List<CachedObject> _cachedObjects; // 0x60
	private string _forcedCachedPrefix; // 0x68
	private int _fixDuplicateCache; // 0x70

	// Nested types
	[Serializable]
	public class CachedObject // TypeDefIndex: 11158
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
		public CachedObject(); // 0x0000000180A96680-0x0000000180A966E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetAndSetCachedTexture>d__6<T> : IEnumerator<object> // TypeDefIndex: 11159
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetAndSetCachedTexture>d__6(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0<T> // TypeDefIndex: 11160
		where T : UnityEngine.Object
	{
		// Fields
		public T cachedObject;

		// Constructors
		public <>c__DisplayClass8_0();

		// Methods
		internal void <GetCachedObject>b__0(T loadedObject);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetCachedObject>d__8<T> : IEnumerator<object> // TypeDefIndex: 11161
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetCachedObject>d__8(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CacheRoutine>d__12 : IEnumerator<object> // TypeDefIndex: 11162
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreObjectCacheManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CacheRoutine>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AABE90-0x0000000180AAC150
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAC150-0x0000000180AAC1A0
	}

	// Constructors
	public CoreObjectCacheManager(); // 0x0000000180A97CF0-0x0000000180A97D60

	// Methods
	public override void MStart(); // 0x0000000180A97C80-0x0000000180A97CF0
	public override void MOnDestroy(); // 0x0000000180A97B20-0x0000000180A97C80
	private string GetStoredBundleID(string inBundleID, AssetQualityLevel inQuality, Type inType); // 0x0000000180A97970-0x0000000180A97B20
	[IteratorStateMachine] // 0x000000018024AA50-0x000000018024AAA0
	public IEnumerator GetAndSetCachedTexture<T>(UnityEngine.Object inObject, GameObject inGameObjectReference, Action<T> inObjectCallback = null)
		where T : UnityEngine.Object;
	private void DestroyForcedCachedObject(CachedObject inCachedObject); // 0x0000000180A97680-0x0000000180A976F0
	[IteratorStateMachine] // 0x000000018024AC00-0x000000018024AC50
	public IEnumerator GetCachedObject<T>(string inBundleID, GameObject inGameObjectReference, BundleLoadType inBundleLoadType, BundleQueue inBundleQueue, Action<T> inObjectCallback = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C852 */, string inPriorBundleID = "" /* Metadata: 0x0077C856 */, bool inManualBundleUnload = false /* Metadata: 0x0077C85A */)
		where T : UnityEngine.Object;
	public void ClearCachedObject(string inBundleID, AssetQualityLevel inQuality, Type inType, GameObject inGameObjectReference); // 0x0000000180A973A0-0x0000000180A974E0
	public void ClearCachedObject(GameObject inGameObjectReference); // 0x0000000180A974E0-0x0000000180A97680
	[IteratorStateMachine] // 0x000000018024AD50-0x000000018024ADA0
	private IEnumerator CacheRoutine(); // 0x0000000180A97340-0x0000000180A973A0
	private void FixDuplicateCache(int inIdx); // 0x0000000180A976F0-0x0000000180A97970
}


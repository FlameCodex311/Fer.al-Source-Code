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

public static class CoreBundleManager2Extensions // TypeDefIndex: 10965
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadBundledAssetAndWait>d__2<T> : IEnumerator<object> // TypeDefIndex: 10966
		where T : UnityEngine.Object
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public string inBundleID;
		public GameObject inGameObject;
		public Action<T> inResult;
		public AssetQualityLevel inQuality;
		public BundlePriority inPriority;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadBundledAssetAndWait>d__2(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InstantiateBundledAssetAndWait>d__4<T> : IEnumerator<object> // TypeDefIndex: 10967
		where T : UnityEngine.Object
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public string inBundleID;
		public GameObject inGameObject;
		public Transform inParentTransform;
		public bool inActive;
		public Action<T> inResult;
		public AssetQualityLevel inQuality;
		public BundlePriority inPriority;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InstantiateBundledAssetAndWait>d__4(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	// Extension methods
	public static QRoutine LoadGlobalBundledAsset<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C5C1 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C5C5 */)
		where T : UnityEngine.Object;
	public static QRoutine LoadBundledAsset<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C5C9 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C5CD */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x00000001801FB4B0-0x00000001801FB520
	public static IEnumerator LoadBundledAssetAndWait<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C5D1 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C5D5 */)
		where T : UnityEngine.Object;
	public static QRoutine InstantiateBundledAsset<T>(this GameObject inGameObject, string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C5D9 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C5DD */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x00000001801FCD80-0x00000001801FCDF0
	public static IEnumerator InstantiateBundledAssetAndWait<T>(this GameObject inGameObject, string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C5E1 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C5E5 */)
		where T : UnityEngine.Object;
}


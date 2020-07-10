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

public static class CoreBundleManager2Extensions // TypeDefIndex: 13299
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadBundledAssetAndWait>d__2<T> : IEnumerator<object> // TypeDefIndex: 13300
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadBundledAssetAndWait>d__2(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InstantiateBundledAssetAndWait>d__4<T> : IEnumerator<object> // TypeDefIndex: 13301
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InstantiateBundledAssetAndWait>d__4(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	// Extension methods
	public static QRoutine LoadGlobalBundledAsset<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783B06 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783B0A */)
		where T : UnityEngine.Object;
	public static QRoutine LoadBundledAsset<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783B0E */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783B12 */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x00000001801202D0-0x0000000180120340
	public static IEnumerator LoadBundledAssetAndWait<T>(this GameObject inGameObject, string inBundleID, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783B16 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783B1A */)
		where T : UnityEngine.Object;
	public static QRoutine InstantiateBundledAsset<T>(this GameObject inGameObject, string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783B1E */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783B22 */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x0000000180120830-0x00000001801208A0
	public static IEnumerator InstantiateBundledAssetAndWait<T>(this GameObject inGameObject, string inBundleID, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783B26 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783B2A */)
		where T : UnityEngine.Object;
}


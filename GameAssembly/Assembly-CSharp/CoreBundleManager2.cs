/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreBundleManager2 : CoreManagerBase<CoreBundleManager2> // TypeDefIndex: 10953
{
	// Fields
	public Dictionary<string, Sprite> spriteCache; // 0x60
	private static string _bundleTarCacheFolderPath; // 0x00
	private static string _bundleCacheFolderPath; // 0x08
	private static string _bundleIncludedFolderPath; // 0x10
	private const int _maxDownloadAttempts = 3; // Metadata: 0x0077C591
	private static float? _downloadTimeout; // 0x18
	private List<string> _removeLoadedAssetBundles; // 0x68
	private static Dictionary<string, LoadedAssetBundleEntry> _loadedGlobalAssetBundles; // 0x20
	private static Dictionary<string, LoadedAssetBundleEntry> _loadedStandardAssetBundles; // 0x28
	private static Dictionary<string, LoadedAssetBundleEntry> _loadedLevelAssetBundles; // 0x30
	public static Dictionary<BundleLoadType, Dictionary<string, LoadedAssetBundleEntry>> LoadedAssetBundles; // 0x38
	private QRoutineGroup _bundleManagerQRoutineGroup; // 0x70
	public Dictionary<BundlePriority, QRoutineGroup> qroutineGroupsByPriority; // 0x78
	private Vector3 _instantiateLocation; // 0x80

	// Properties
	public static string BundleTarCacheFolderPath { get; } // 0x0000000180A64030-0x0000000180A64190 
	public static string BundleCacheFolderPath { get; } // 0x0000000180A63CC0-0x0000000180A63E30 
	public static string BundleIncludedFolderPath { get; } // 0x0000000180A63E30-0x0000000180A64030 
	private static float DownloadTimeout { get; } // 0x0000000180A64190-0x0000000180A64290 

	// Nested types
	public enum LoadedAssetBundleState // TypeDefIndex: 10954
	{
		Init = 0,
		Downloading = 1,
		Downloaded = 2,
		FailedToDownload = 3,
		Loading = 4,
		Loaded = 5,
		FailedToLoad = 6,
		Ready = 7
	}

	public class LoadedAssetBundleEntry // TypeDefIndex: 10955
	{
		// Fields
		public LoadedAssetBundleState state; // 0x10
		public ManifestDef bundleDef; // 0x18
		public string bundleID; // 0x20
		public AssetBundle assetBundle; // 0x28
		public BundleLoadType loadType; // 0x30
		private float _lastRefTime; // 0x34
		private List<GameObject> _references; // 0x38

		// Properties
		public bool CanTimeout { get; } // 0x0000000180A740A0-0x0000000180A740C0 
		public float LastRefTime { get; } // 0x00000001806CEAE0-0x00000001806CEAF0 
		public float TimeLeft { get; } // 0x0000000180A74100-0x0000000180A741D0 
		public List<GameObject> References { get; } // 0x00000001803743D0-0x00000001803743E0 
		public int RefCount { get; } // 0x0000000180A740C0-0x0000000180A74100 

		// Constructors
		public LoadedAssetBundleEntry(); // 0x0000000180A74040-0x0000000180A740A0

		// Methods
		public bool AddReference(GameObject inReferenceObject); // 0x0000000180A73E10-0x0000000180A73EA0
		public void UpdateReferences(); // 0x0000000180A73F30-0x0000000180A74040
		public void Unload(bool inFullUnload); // 0x0000000180A73EA0-0x0000000180A73F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InternalDownloadBundleRoutine>d__19 : IEnumerator<object> // TypeDefIndex: 10956
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManifestDef inDef; // 0x20
		public CoreBundleManager2 <>4__this; // 0x28
		private int <downloadAttemptCount>5__2; // 0x30
		private UnityWebRequest <webRequest>5__3; // 0x38
		private float <downloadTimer>5__4; // 0x40
		private float <priorProgress>5__5; // 0x44
		private float <priorLoggedProgress>5__6; // 0x48
		private bool <timedOut>5__7; // 0x4C
		private byte[] <wrBytes>5__8; // 0x50
		private bool <fileWriteSucceeded>5__9; // 0x58
		private int <tryAttempts>5__10; // 0x5C
		private FileStream <SourceStream>5__11; // 0x60
		private FileStream <DestinationStream>5__12; // 0x68
		private Task <copyToAsync>5__13; // 0x70

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InternalDownloadBundleRoutine>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180A7A090-0x0000000180A7A190
		private bool MoveNext(); // 0x0000000180A791C0-0x0000000180A7A040
		private void <>m__Finally1(); // 0x0000000180A7A190-0x0000000180A7A1E0
		private void <>m__Finally2(); // 0x0000000180A7A1E0-0x0000000180A7A230
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7A040-0x0000000180A7A090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 10957
	{
		// Fields
		public AssetBundleCreateRequest request; // 0x10

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <LoadAssetBundleAsync>b__0(); // 0x0000000180786ED0-0x0000000180786EF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadAssetBundleAsync>d__29 : IEnumerator<object> // TypeDefIndex: 10958
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManifestDef inDef; // 0x20
		public CoreBundleManager2 <>4__this; // 0x28
		public Action<AssetBundle> returnAssetBundle; // 0x30
		private <>c__DisplayClass29_0 <>8__1; // 0x38
		private string <bundlePath>5__2; // 0x40
		private AssetBundle <retBundle>5__3; // 0x48
		private int <retries>5__4; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadAssetBundleAsync>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7A230-0x0000000180A7A700
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7A700-0x0000000180A7A750
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__44 : IEnumerator<object> // TypeDefIndex: 10959
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager2 <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A78D50-0x0000000180A78D80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A78D80-0x0000000180A78DD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass53_0<T> // TypeDefIndex: 10960
		where T : UnityEngine.Object
	{
		// Fields
		public Transform inParentTransform;
		public bool inActive;
		public Action<T> inResult;

		// Constructors
		public <>c__DisplayClass53_0();

		// Methods
		internal void <InstantiateBundledAsset>b__0(T loadedAsset);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass56_0<T> // TypeDefIndex: 10961
		where T : UnityEngine.Object
	{
		// Fields
		public T loadedObject;

		// Constructors
		public <>c__DisplayClass56_0();

		// Methods
		internal void <ActuallyLoadBundledAsset>b__0(T result);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass56_1<T> // TypeDefIndex: 10962
		where T : UnityEngine.Object
	{
		// Fields
		public AssetBundle assetBundle;

		// Constructors
		public <>c__DisplayClass56_1();

		// Methods
		internal void <ActuallyLoadBundledAsset>b__1(AssetBundle inAssetBundle);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ActuallyLoadBundledAsset>d__56<T> : IEnumerator<object> // TypeDefIndex: 10963
		where T : UnityEngine.Object
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public CoreBundleManager2 <>4__this;
		public AssetQualityLevel inQuality;
		public string inBundleID;
		public BundleLoadType inType;
		public GameObject inReferenceObject;
		public Action<T> inResult;
		private <>c__DisplayClass56_1<T> <>8__1;
		private ManifestDef <cDef>5__2;
		private LoadedAssetBundleEntry <loadedAssetBundle>5__3;
		private T <loadedAsset>5__4;
		private List<string> <assetNames>5__5;
		private AssetBundleRequest <loadingRequest>5__6;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ActuallyLoadBundledAsset>d__56(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	// Constructors
	public CoreBundleManager2(); // 0x0000000180A63BD0-0x0000000180A63CC0
	static CoreBundleManager2(); // 0x0000000180A639E0-0x0000000180A63BD0

	// Methods
	public void SetCachedSprite(string inBundleID, Sprite inSprite); // 0x0000000180A636F0-0x0000000180A637D0
	public Sprite GetCachedSpriteInstance(string inBundleID); // 0x0000000180A62170-0x0000000180A62230
	public bool PruneBundleCache(int inPruneAgeInHours, long inRequiredBytes = -1 /* Metadata: 0x0077C54E */, bool inResetOnRequiredMBFailure = false /* Metadata: 0x0077C556 */); // 0x0000000180A632C0-0x0000000180A636F0
	public void ClearTarBundleCache(); // 0x0000000180A61DF0-0x0000000180A61ED0
	public void ClearBundleCache(); // 0x0000000180A61D10-0x0000000180A61DF0
	[IteratorStateMachine] // 0x00000001801F4E70-0x00000001801F4EC0
	private IEnumerator InternalDownloadBundleRoutine(ManifestDef inDef); // 0x0000000180A62B10-0x0000000180A62B80
	private void MUpdateUnloadAssetBundlesWithNoRefs(); // 0x0000000180A62ED0-0x0000000180A632B0
	public static void CoreReset(); // 0x0000000180A61ED0-0x0000000180A61F90
	[IteratorStateMachine] // 0x00000001801F5140-0x00000001801F5190
	private IEnumerator LoadAssetBundleAsync(ManifestDef inDef, BundleLoadType inType, Action<AssetBundle> returnAssetBundle); // 0x0000000180A62B80-0x0000000180A62C00
	public static void UnloadAllAssetBundlesOfType(BundleLoadType inType, bool inFullUnload = true /* Metadata: 0x0077C557 */); // 0x0000000180A637D0-0x0000000180A63990
	public static void UnloadAllLevelAssetBundles(); // 0x0000000180A63990-0x0000000180A639E0
	public static void ForceUnloadAllAssetBundles(); // 0x0000000180A61F90-0x0000000180A62170
	private void LoadLocalBundledAsset<T>(string inBundleID, BundleLoadType inType, Action<T> inResult, AssetQualityLevel inQuality)
		where T : UnityEngine.Object;
	public static bool HasLocalAssetAtPath(string inPath, AssetQualityLevel inQualityLevel); // 0x0000000180A62460-0x0000000180A625E0
	private static bool HasLocalAssetsAtPath(string inPath); // 0x0000000180A625E0-0x0000000180A62720
	public static T[] GetLocalAssetsAtPath<T>(string path)
		where T : class;
	public static T LoadLocalAssetAtPath<T>(string inPath, AssetQualityLevel inQualityLevel, bool inShowWarning = true /* Metadata: 0x0077C558 */)
		where T : UnityEngine.Object;
	private void InitQRoutine(); // 0x0000000180A62780-0x0000000180A62B10
	public QRoutineGroup GetQRoutineGroupForGameObject(GameObject inGameObject, BundlePriority inPriority); // 0x0000000180A62230-0x0000000180A622B0
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x00000001801F5540-0x00000001801F5590
	public override IEnumerator InitCoroutine(); // 0x0000000180A62720-0x0000000180A62780
	public override void MUpdate(); // 0x0000000180A632B0-0x0000000180A632C0
	public static bool BundleExists(string inBundleID); // 0x0000000180A61C80-0x0000000180A61D10
	public static QRoutine LoadGlobalAsset<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C559 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C55D */)
		where T : UnityEngine.Object;
	public static IEnumerator LoadGlobalAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C561 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C565 */)
		where T : UnityEngine.Object;
	public static QRoutine LoadBundledLevel(string inBundleID, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C569 */); // 0x0000000180A62D90-0x0000000180A62ED0
	public static IEnumerator LoadBundledLevelAndWait(string inBundleID, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C56D */); // 0x0000000180A62C00-0x0000000180A62D90
	public static QRoutine LoadBundledAsset<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C571 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C575 */)
		where T : UnityEngine.Object;
	public static IEnumerator LoadBundledAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C579 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C57D */)
		where T : UnityEngine.Object;
	public static QRoutine InstantiateBundledAsset<T>(string inBundleID, GameObject inReferenceObject, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C581 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C585 */)
		where T : UnityEngine.Object;
	public static IEnumerator InstantiateBundledAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x0077C589 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x0077C58D */)
		where T : UnityEngine.Object;
	public static bool HasLoadedBundledAsset(string inBundleID, BundleLoadType inType, AssetQualityLevel inQuality); // 0x0000000180A622B0-0x0000000180A62460
	[IteratorStateMachine] // 0x00000001801F58C0-0x00000001801F5910
	private IEnumerator ActuallyLoadBundledAsset<T>(string inBundleID, BundleLoadType inType, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality)
		where T : UnityEngine.Object;
}


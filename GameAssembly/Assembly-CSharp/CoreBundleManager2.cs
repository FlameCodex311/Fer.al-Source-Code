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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreBundleManager2 : CoreManagerBase<CoreBundleManager2> // TypeDefIndex: 13287
{
	// Fields
	public Dictionary<string, Sprite> spriteCache; // 0x60
	private static string _bundleTarCacheFolderPath; // 0x00
	private static string _bundleCacheFolderPath; // 0x08
	private static string _bundleIncludedFolderPath; // 0x10
	private Vector3 _instantiateLocation; // 0x68
	private const int _maxDownloadAttempts = 3; // Metadata: 0x00783AD6
	private static float? _downloadTimeout; // 0x18
	private List<string> _removeLoadedAssetBundles; // 0x78
	private static Dictionary<string, LoadedAssetBundleEntry> _loadedGlobalAssetBundles; // 0x20
	private static Dictionary<string, LoadedAssetBundleEntry> _loadedStandardAssetBundles; // 0x28
	private static Dictionary<string, LoadedAssetBundleEntry> _loadedLevelAssetBundles; // 0x30
	public static Dictionary<BundleLoadType, Dictionary<string, LoadedAssetBundleEntry>> LoadedAssetBundles; // 0x38
	private QRoutineGroup _bundleManagerQRoutineGroup; // 0x80
	public Dictionary<BundlePriority, QRoutineGroup> qroutineGroupsByPriority; // 0x88

	// Properties
	public static string BundleTarCacheFolderPath { get; } // 0x0000000181477630-0x0000000181477790 
	public static string BundleCacheFolderPath { get; } // 0x00000001814772C0-0x0000000181477430 
	public static string BundleIncludedFolderPath { get; } // 0x0000000181477430-0x0000000181477630 
	private static float DownloadTimeout { get; } // 0x0000000181477790-0x0000000181477890 

	// Nested types
	public enum LoadedAssetBundleState // TypeDefIndex: 13288
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

	public class LoadedAssetBundleEntry // TypeDefIndex: 13289
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
		public bool CanTimeout { get; } // 0x000000018147F7E0-0x000000018147F800 
		public float LastRefTime { get; } // 0x00000001804C16A0-0x00000001804C16B0 
		public float TimeLeft { get; } // 0x000000018147F840-0x000000018147F910 
		public List<GameObject> References { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		public int RefCount { get; } // 0x000000018147F800-0x000000018147F840 

		// Constructors
		public LoadedAssetBundleEntry(); // 0x000000018147F780-0x000000018147F7E0

		// Methods
		public bool AddReference(GameObject inReferenceObject); // 0x000000018147F550-0x000000018147F5E0
		public void UpdateReferences(); // 0x000000018147F670-0x000000018147F780
		public void Unload(bool inFullUnload); // 0x000000018147F5E0-0x000000018147F670
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__17 : IEnumerator<object> // TypeDefIndex: 13290
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager2 <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814812C0-0x00000001814812F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814812F0-0x0000000181481340
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass26_0<T> // TypeDefIndex: 13291
		where T : UnityEngine.Object
	{
		// Fields
		public Transform inParentTransform;
		public bool inActive;
		public Action<T> inResult;

		// Constructors
		public <>c__DisplayClass26_0();

		// Methods
		internal void <InstantiateBundledAsset>b__0(T loadedAsset);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0<T> // TypeDefIndex: 13292
		where T : UnityEngine.Object
	{
		// Fields
		public T loadedObject;

		// Constructors
		public <>c__DisplayClass29_0();

		// Methods
		internal void <ActuallyLoadBundledAsset>b__0(T result);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_1<T> // TypeDefIndex: 13293
		where T : UnityEngine.Object
	{
		// Fields
		public AssetBundle assetBundle;

		// Constructors
		public <>c__DisplayClass29_1();

		// Methods
		internal void <ActuallyLoadBundledAsset>b__1(AssetBundle inAssetBundle);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ActuallyLoadBundledAsset>d__29<T> : IEnumerator<object> // TypeDefIndex: 13294
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
		private <>c__DisplayClass29_1<T> <>8__1;
		private ManifestDef <cDef>5__2;
		private LoadedAssetBundleEntry <loadedAssetBundle>5__3;
		private T <loadedAsset>5__4;
		private List<string> <assetNames>5__5;
		private AssetBundleRequest <loadingRequest>5__6;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ActuallyLoadBundledAsset>d__29(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InternalDownloadBundleRoutine>d__34 : IEnumerator<object> // TypeDefIndex: 13295
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
		private FileStream <SourceStream>5__8; // 0x50
		private FileStream <DestinationStream>5__9; // 0x58
		private Task <copyToAsync>5__10; // 0x60

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InternalDownloadBundleRoutine>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000181482F50-0x0000000181483060
		private bool MoveNext(); // 0x0000000181482360-0x0000000181482F00
		private void <>m__Finally1(); // 0x0000000181483060-0x00000001814830B0
		private void <>m__Finally2(); // 0x00000001814830B0-0x0000000181483100
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181482F00-0x0000000181482F50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass44_0 // TypeDefIndex: 13296
	{
		// Fields
		public AssetBundleCreateRequest request; // 0x10

		// Constructors
		public <>c__DisplayClass44_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <LoadAssetBundleAsync>b__0(); // 0x0000000181484100-0x0000000181484120
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadAssetBundleAsync>d__44 : IEnumerator<object> // TypeDefIndex: 13297
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManifestDef inDef; // 0x20
		public CoreBundleManager2 <>4__this; // 0x28
		public Action<AssetBundle> returnAssetBundle; // 0x30
		private <>c__DisplayClass44_0 <>8__1; // 0x38
		private string <bundlePath>5__2; // 0x40
		private AssetBundle <retBundle>5__3; // 0x48
		private int <retries>5__4; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadAssetBundleAsync>d__44(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814834B0-0x00000001814839B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814839B0-0x0000000181483A00
	}

	// Constructors
	public CoreBundleManager2(); // 0x00000001814771D0-0x00000001814772C0
	static CoreBundleManager2(); // 0x0000000181476FE0-0x00000001814771D0

	// Methods
	public void SetCachedSprite(string inBundleID, Sprite inSprite); // 0x0000000181476CE0-0x0000000181476DC0
	public Sprite GetCachedSpriteInstance(string inBundleID); // 0x0000000181475700-0x00000001814757C0
	public bool PruneBundleCache(int inPruneAgeInHours, long inRequiredBytes = -1 /* Metadata: 0x00783A93 */, bool inResetOnRequiredMBFailure = false /* Metadata: 0x00783A9B */); // 0x00000001814768A0-0x0000000181476CE0
	public void ClearTarBundleCache(); // 0x0000000181475360-0x0000000181475450
	public void ClearBundleCache(); // 0x0000000181475270-0x0000000181475360
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x000000018011B9E0-0x000000018011BA30
	public override IEnumerator InitCoroutine(); // 0x0000000181475CC0-0x0000000181475D20
	public override void MUpdate(); // 0x0000000181476890-0x00000001814768A0
	public static bool BundleExists(string inBundleID); // 0x00000001814751E0-0x0000000181475270
	public static QRoutine LoadGlobalAsset<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783A9C */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783AA0 */)
		where T : UnityEngine.Object;
	public static IEnumerator LoadGlobalAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783AA4 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783AA8 */)
		where T : UnityEngine.Object;
	public static QRoutine LoadBundledLevel(string inBundleID, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783AAC */); // 0x0000000181476350-0x00000001814764A0
	public static IEnumerator LoadBundledLevelAndWait(string inBundleID, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783AB0 */); // 0x00000001814761B0-0x0000000181476350
	public static QRoutine LoadBundledAsset<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783AB4 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783AB8 */)
		where T : UnityEngine.Object;
	public static IEnumerator LoadBundledAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783ABC */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783AC0 */)
		where T : UnityEngine.Object;
	public static QRoutine InstantiateBundledAsset<T>(string inBundleID, GameObject inReferenceObject, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783AC4 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783AC8 */)
		where T : UnityEngine.Object;
	public static IEnumerator InstantiateBundledAssetAndWait<T>(string inBundleID, GameObject inReferenceObject, Transform inParentTransform, bool inActive, Action<T> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00783ACC */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00783AD0 */)
		where T : UnityEngine.Object;
	public static bool HasLoadedBundledAsset(string inBundleID, BundleLoadType inType, AssetQualityLevel inQuality); // 0x0000000181475840-0x00000001814759F0
	[IteratorStateMachine] // 0x000000018011CE50-0x000000018011CEA0
	private IEnumerator ActuallyLoadBundledAsset<T>(string inBundleID, BundleLoadType inType, GameObject inReferenceObject, Action<T> inResult, AssetQualityLevel inQuality)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x000000018011CF50-0x000000018011CFA0
	private IEnumerator InternalDownloadBundleRoutine(ManifestDef inDef); // 0x00000001814760C0-0x0000000181476130
	private void MUpdateUnloadAssetBundlesWithNoRefs(); // 0x00000001814764A0-0x0000000181476890
	public static void CoreReset(); // 0x0000000181475450-0x0000000181475510
	[IteratorStateMachine] // 0x000000018011D150-0x000000018011D1A0
	private IEnumerator LoadAssetBundleAsync(ManifestDef inDef, BundleLoadType inType, Action<AssetBundle> returnAssetBundle); // 0x0000000181476130-0x00000001814761B0
	public static void UnloadAllAssetBundlesOfType(BundleLoadType inType, bool inFullUnload = true /* Metadata: 0x00783AD4 */); // 0x0000000181476DC0-0x0000000181476F90
	public static void UnloadAllLevelAssetBundles(); // 0x0000000181476F90-0x0000000181476FE0
	public static void ForceUnloadAllAssetBundles(); // 0x0000000181475510-0x0000000181475700
	private void LoadLocalBundledAsset<T>(string inBundleID, BundleLoadType inType, Action<T> inResult, AssetQualityLevel inQuality)
		where T : UnityEngine.Object;
	public static bool HasLocalAssetAtPath(string inPath, AssetQualityLevel inQualityLevel); // 0x00000001814759F0-0x0000000181475B80
	private static bool HasLocalAssetsAtPath(string inPath); // 0x0000000181475B80-0x0000000181475CC0
	public static T[] GetLocalAssetsAtPath<T>(string path)
		where T : class;
	public static T LoadLocalAssetAtPath<T>(string inPath, AssetQualityLevel inQualityLevel, bool inShowWarning = true /* Metadata: 0x00783AD5 */)
		where T : UnityEngine.Object;
	private void InitQRoutine(); // 0x0000000181475D20-0x00000001814760C0
	public QRoutineGroup GetQRoutineGroupForGameObject(GameObject inGameObject, BundlePriority inPriority); // 0x00000001814757C0-0x0000000181475840
}


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

public class CoreBundleManager : CoreManagerBase<CoreBundleManager> // TypeDefIndex: 10945
{
	// Fields
	private int? _maxActiveBundles; // 0x60
	private int? _maxConcurrentDownloads; // 0x68
	public List<BundleDownloadQueue> downloadingBundleQueueList; // 0x70
	public static Dictionary<string, string> streamingAssetsFileList; // 0x00
	private Dictionary<BundleQueue, List<DownloadingBundle>> _downloadBundleQueueByID; // 0x78
	public List<DownloadingBundle> currentDownloadingBundles; // 0x80
	public int? overrideConcurrentDownloads; // 0x88
	private static string[] _nonePostfixes; // 0x08
	private static string[] _lqPostfixes; // 0x10
	private static string[] _mqPostfixes; // 0x18
	private static string[] _hqPostfixes; // 0x20
	private static Dictionary<string, AssetBundle> _loadedGlobalAssetBundles; // 0x28
	private static Dictionary<string, AssetBundle> _loadedStandardAssetBundles; // 0x30
	private static Dictionary<string, AssetBundle> _loadedLevelAssetBundles; // 0x38
	private HashSet<string> _currentAsyncAssetsLoading; // 0x90
	private static string[] _platformNames; // 0x40
	private static Dictionary<string, string> _getBundleFileNameCache; // 0x48

	// Properties
	private int MaxActiveBundles { get; } // 0x00000001807838A0-0x0000000180783950 
	private int MaxConcurrentDownloads { get; } // 0x0000000180783950-0x0000000180783A20 
	public Dictionary<BundleQueue, List<DownloadingBundle>> DownloadBundleQueueByID { get; } // 0x0000000180783740-0x00000001807838A0 
	public List<DownloadingBundle> CurrentDownloadingBundleQueue { get; } // 0x0000000180783610-0x0000000180783740 
	public static string[] PlatformNames { get; } // 0x0000000180783A20-0x0000000180783C80 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__18 : IEnumerator<object> // TypeDefIndex: 10946
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A78090-0x0000000180A78450
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A78450-0x0000000180A784A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadStreamingAssetsManifest>d__19 : IEnumerator<object> // TypeDefIndex: 10947
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private string <fileText>5__2; // 0x20
		private WWW <www>5__3; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadStreamingAssetsManifest>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7BA00-0x0000000180A7BF00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7BF00-0x0000000180A7BF50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadBundles>d__21 : IEnumerator<object> // TypeDefIndex: 10948
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager <>4__this; // 0x20
		private float <downloadTimeout>5__2; // 0x28
		private WaitForEndOfFrame <waitForEndOfFrame>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadBundles>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180785580-0x0000000180786100
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180786100-0x0000000180786150
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass35_0 // TypeDefIndex: 10949
	{
		// Fields
		public AssetBundleCreateRequest request; // 0x10

		// Constructors
		public <>c__DisplayClass35_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <LoadAssetBundleAsync>b__0(); // 0x0000000180786ED0-0x0000000180786EF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadAssetBundleAsync>d__35 : IEnumerator<object> // TypeDefIndex: 10950
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BundleLoadType inType; // 0x20
		public ManifestDef inDef; // 0x28
		public Action<AssetBundle> returnBundle; // 0x30
		private <>c__DisplayClass35_0 <>8__1; // 0x38
		public CoreBundleManager <>4__this; // 0x40
		private Dictionary<string, AssetBundle> <bundleList>5__2; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadAssetBundleAsync>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7A750-0x0000000180A7AAA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7AAA0-0x0000000180A7AAF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadBundledAsset>d__43<T> : IEnumerator<object> // TypeDefIndex: 10951
		where T : UnityEngine.Object
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public BundleLoadType inType;
		public Action<T> inResult;
		public CoreBundleManager <>4__this;
		public string inPath;
		public AssetQualityLevel inQuality;
		public BundleQueue inQueue;
		public bool inManualBundleUnload;
		private ManifestDef <cDef>5__2;
		private AssetBundle <cBundle>5__3;
		private T <loadedLocalAsset>5__4;
		private DownloadingBundle <cDownloadingBundle>5__5;
		private int <retries>5__6;
		private Dictionary<string, AssetBundle> <bundleList>5__7;
		private AssetBundleRequest <loadingRequest>5__8;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadBundledAsset>d__43(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UnloadAssetBundleAtEndOfFrame>d__44 : IEnumerator<object> // TypeDefIndex: 10952
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager <>4__this; // 0x20
		public string inPath; // 0x28
		public ManifestDef inDef; // 0x30
		public BundleLoadType inType; // 0x38
		public bool inFullUnload; // 0x3C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UnloadAssetBundleAtEndOfFrame>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7C190-0x0000000180A7C290
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7C290-0x0000000180A7C2E0
	}

	// Constructors
	public CoreBundleManager(); // 0x0000000180783560-0x0000000180783610
	static CoreBundleManager(); // 0x0000000180782DE0-0x0000000180783560

	// Methods
	public DownloadingBundle GetDownloadingBundleFromQueue(BundleQueue inQueueID, ManifestDef inManifestDef); // 0x0000000180781830-0x0000000180781AE0
	public DownloadingBundle AddDownloadToQueue(BundleQueue inQueueID, ManifestDef inManifestDef); // 0x0000000180780890-0x0000000180780970
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x00000001801EE960-0x00000001801EE9B0
	public override IEnumerator InitCoroutine(); // 0x0000000180782170-0x00000001807821E0
	[IteratorStateMachine] // 0x00000001801EEBB0-0x00000001801EEC00
	private IEnumerator LoadStreamingAssetsManifest(); // 0x00000001807827C0-0x0000000180782810
	public float? GetDownloadProgressForDownloadingBundle(BundleQueue inQueueID, ManifestDef inManifestDef); // 0x0000000180781790-0x0000000180781830
	[IteratorStateMachine] // 0x00000001801EEDA0-0x00000001801EEDF0
	private IEnumerator DownloadBundles(); // 0x0000000180780C10-0x0000000180780C70
	private static void HandleDownloadFailure(DownloadingBundle downloadingBundle); // 0x0000000180782070-0x0000000180782170
	public static T[] GetLocalAssetsAtPath<T>(string path)
		where T : class;
	public static string RepairBundleIDString(string inString); // 0x0000000180782810-0x0000000180782940
	public ManifestDef GetManifestDefForPathWithQualityLevel(string inPath, AssetQualityLevel inQualityLevel); // 0x0000000180781AE0-0x0000000180781DF0
	public static Dictionary<string, AssetBundle> GetAssetBundleListForType(BundleLoadType inType); // 0x0000000180780E50-0x0000000180780F20
	private AssetBundle LoadAssetBundle(ManifestDef inDef, BundleLoadType inType); // 0x0000000180782280-0x00000001807827C0
	[IteratorStateMachine] // 0x00000001801EEF80-0x00000001801EEFD0
	private IEnumerator LoadAssetBundleAsync(ManifestDef inDef, BundleLoadType inType, Action<AssetBundle> returnBundle); // 0x00000001807821E0-0x0000000180782280
	public bool CheckIfAssetBundleMatchesDefID(ManifestDef inDef, ref AssetBundle inBundle); // 0x0000000180780970-0x0000000180780C10
	public void UnloadAssetBundle(ManifestDef inDef, BundleLoadType inType, bool inFullUnload); // 0x0000000180782BD0-0x0000000180782CB0
	public void UnloadAssetBundle(string inPath, AssetQualityLevel inQuality, BundleLoadType inType, bool inFullUnload); // 0x0000000180782CB0-0x0000000180782DE0
	public static void UnloadAllAssetBundles(BundleLoadType inType, bool inFullUnload); // 0x0000000180782940-0x0000000180782B30
	public static void ForceUnloadAllAssetBundles(); // 0x0000000180780C70-0x0000000180780E50
	public T LoadBundledAssetNow<T>(string inPath, BundleLoadType inType = BundleLoadType.LoadAsset /* Metadata: 0x0077C536 */, AssetQualityLevel inQuality = AssetQualityLevel.Low /* Metadata: 0x0077C53A */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x00000001801EF160-0x00000001801EF1B0
	public IEnumerator LoadBundledAsset<T>(string inPath, Action<T> inResult, BundleLoadType inType = BundleLoadType.LoadAsset /* Metadata: 0x0077C53E */, BundleQueue inQueue = BundleQueue.Default /* Metadata: 0x0077C542 */, AssetQualityLevel inQuality = AssetQualityLevel.Low /* Metadata: 0x0077C546 */, bool inAttemptNonasync = false /* Metadata: 0x0077C54A */, bool inManualBundleUnload = false /* Metadata: 0x0077C54B */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x00000001801EF440-0x00000001801EF490
	private IEnumerator UnloadAssetBundleAtEndOfFrame(string inPath, ManifestDef inDef, BundleLoadType inType, bool inFullUnload = false /* Metadata: 0x0077C54C */); // 0x0000000180782B30-0x0000000180782BD0
	private static string[] GetPostFixes(AssetQualityLevel inAssetQualityLevel); // 0x0000000180781DF0-0x0000000180781F20
	private T LoadLocalAsset<T>(string inPath, AssetQualityLevel inQualityLevel)
		where T : UnityEngine.Object;
	public static SimplePlatform GetSimplePlatformFromBuildTarget(); // 0x0000000180781F20-0x0000000180781F30
	public static SimplePlatform GetSimplePlatformFromRunTime(); // 0x0000000180781F30-0x0000000180782070
	public static string GetBundleIDFromFileName(string inBundleFileName); // 0x00000001807812E0-0x0000000180781610
	public static string GetBundleName(string inBundlePath); // 0x0000000180781610-0x0000000180781790
	public static string GetBundleFileName(string inBundlePath, bool inEditorMode = false /* Metadata: 0x0077C54D */); // 0x0000000180780F20-0x00000001807812E0
}


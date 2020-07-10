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

public class CoreBundleManager : CoreManagerBase<CoreBundleManager> // TypeDefIndex: 13279
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
	private int MaxActiveBundles { get; } // 0x000000018147A9D0-0x000000018147AA80 
	private int MaxConcurrentDownloads { get; } // 0x000000018147AA80-0x000000018147AB50 
	public Dictionary<BundleQueue, List<DownloadingBundle>> DownloadBundleQueueByID { get; } // 0x000000018147A860-0x000000018147A9D0 
	public List<DownloadingBundle> CurrentDownloadingBundleQueue { get; } // 0x000000018147A720-0x000000018147A860 
	public static string[] PlatformNames { get; } // 0x000000018147AB50-0x000000018147ADC0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__18 : IEnumerator<object> // TypeDefIndex: 13280
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181481340-0x0000000181481780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181481780-0x00000001814817D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadStreamingAssetsManifest>d__19 : IEnumerator<object> // TypeDefIndex: 13281
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private string <fileText>5__2; // 0x20
		private WWW <www>5__3; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadStreamingAssetsManifest>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181483A00-0x0000000181483F20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181483F20-0x0000000181483F70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadBundles>d__21 : IEnumerator<object> // TypeDefIndex: 13282
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreBundleManager <>4__this; // 0x20
		private float <downloadTimeout>5__2; // 0x28
		private WaitForEndOfFrame <waitForEndOfFrame>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadBundles>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018147F910-0x00000001814804F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814804F0-0x0000000181480540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass35_0 // TypeDefIndex: 13283
	{
		// Fields
		public AssetBundleCreateRequest request; // 0x10

		// Constructors
		public <>c__DisplayClass35_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <LoadAssetBundleAsync>b__0(); // 0x0000000181484100-0x0000000181484120
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadAssetBundleAsync>d__35 : IEnumerator<object> // TypeDefIndex: 13284
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadAssetBundleAsync>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181483100-0x0000000181483460
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181483460-0x00000001814834B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadBundledAsset>d__43<T> : IEnumerator<object> // TypeDefIndex: 13285
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadBundledAsset>d__43(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UnloadAssetBundleAtEndOfFrame>d__44 : IEnumerator<object> // TypeDefIndex: 13286
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UnloadAssetBundleAtEndOfFrame>d__44(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814841E0-0x00000001814843C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814843C0-0x0000000181484410
	}

	// Constructors
	public CoreBundleManager(); // 0x000000018147A670-0x000000018147A720
	static CoreBundleManager(); // 0x0000000181479E80-0x000000018147A670

	// Methods
	public DownloadingBundle GetDownloadingBundleFromQueue(BundleQueue inQueueID, ManifestDef inManifestDef); // 0x0000000181478890-0x0000000181478B60
	public DownloadingBundle AddDownloadToQueue(BundleQueue inQueueID, ManifestDef inManifestDef); // 0x0000000181477890-0x0000000181477970
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x0000000180115670-0x00000001801156C0
	public override IEnumerator InitCoroutine(); // 0x00000001814791F0-0x0000000181479250
	[IteratorStateMachine] // 0x0000000180115950-0x00000001801159A0
	private IEnumerator LoadStreamingAssetsManifest(); // 0x0000000181479830-0x0000000181479880
	public float? GetDownloadProgressForDownloadingBundle(BundleQueue inQueueID, ManifestDef inManifestDef); // 0x00000001814787F0-0x0000000181478890
	[IteratorStateMachine] // 0x0000000180115AE0-0x0000000180115B30
	private IEnumerator DownloadBundles(); // 0x0000000181477C20-0x0000000181477C80
	private static void HandleDownloadFailure(DownloadingBundle downloadingBundle); // 0x00000001814790E0-0x00000001814791F0
	public static T[] GetLocalAssetsAtPath<T>(string path)
		where T : class;
	public static string RepairBundleIDString(string inString); // 0x0000000181479880-0x00000001814799C0
	public ManifestDef GetManifestDefForPathWithQualityLevel(string inPath, AssetQualityLevel inQualityLevel); // 0x0000000181478B60-0x0000000181478E70
	public static Dictionary<string, AssetBundle> GetAssetBundleListForType(BundleLoadType inType); // 0x0000000181477E70-0x0000000181477F40
	private AssetBundle LoadAssetBundle(ManifestDef inDef, BundleLoadType inType); // 0x00000001814792E0-0x0000000181479830
	[IteratorStateMachine] // 0x0000000180116F30-0x0000000180116F80
	private IEnumerator LoadAssetBundleAsync(ManifestDef inDef, BundleLoadType inType, Action<AssetBundle> returnBundle); // 0x0000000181479250-0x00000001814792E0
	public bool CheckIfAssetBundleMatchesDefID(ManifestDef inDef, ref AssetBundle inBundle); // 0x0000000181477970-0x0000000181477C20
	public void UnloadAssetBundle(ManifestDef inDef, BundleLoadType inType, bool inFullUnload); // 0x0000000181479C60-0x0000000181479D50
	public void UnloadAssetBundle(string inPath, AssetQualityLevel inQuality, BundleLoadType inType, bool inFullUnload); // 0x0000000181479D50-0x0000000181479E80
	public static void UnloadAllAssetBundles(BundleLoadType inType, bool inFullUnload); // 0x00000001814799C0-0x0000000181479BC0
	public static void ForceUnloadAllAssetBundles(); // 0x0000000181477C80-0x0000000181477E70
	public T LoadBundledAssetNow<T>(string inPath, BundleLoadType inType = BundleLoadType.LoadAsset /* Metadata: 0x00783A7B */, AssetQualityLevel inQuality = AssetQualityLevel.Low /* Metadata: 0x00783A7F */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x00000001801172F0-0x0000000180117340
	public IEnumerator LoadBundledAsset<T>(string inPath, Action<T> inResult, BundleLoadType inType = BundleLoadType.LoadAsset /* Metadata: 0x00783A83 */, BundleQueue inQueue = BundleQueue.Default /* Metadata: 0x00783A87 */, AssetQualityLevel inQuality = AssetQualityLevel.Low /* Metadata: 0x00783A8B */, bool inAttemptNonasync = false /* Metadata: 0x00783A8F */, bool inManualBundleUnload = false /* Metadata: 0x00783A90 */)
		where T : UnityEngine.Object;
	[IteratorStateMachine] // 0x0000000180117510-0x0000000180117560
	private IEnumerator UnloadAssetBundleAtEndOfFrame(string inPath, ManifestDef inDef, BundleLoadType inType, bool inFullUnload = false /* Metadata: 0x00783A91 */); // 0x0000000181479BC0-0x0000000181479C60
	private static string[] GetPostFixes(AssetQualityLevel inAssetQualityLevel); // 0x0000000181478E70-0x0000000181478FA0
	private T LoadLocalAsset<T>(string inPath, AssetQualityLevel inQualityLevel)
		where T : UnityEngine.Object;
	public static SimplePlatform GetSimplePlatformFromBuildTarget(); // 0x00000001806FD3C0-0x00000001806FD3D0
	public static SimplePlatform GetSimplePlatformFromRunTime(); // 0x0000000181478FA0-0x00000001814790E0
	public static string GetBundleIDFromFileName(string inBundleFileName); // 0x0000000181478310-0x0000000181478660
	public static string GetBundleName(string inBundlePath); // 0x0000000181478660-0x00000001814787F0
	public static string GetBundleFileName(string inBundlePath, bool inEditorMode = false /* Metadata: 0x00783A92 */); // 0x0000000181477F40-0x0000000181478310
}


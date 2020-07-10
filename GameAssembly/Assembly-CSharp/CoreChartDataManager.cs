/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SQLite4Unity3d;
using UnityEngine;
using UnityEngine.Networking;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreChartDataManager : CoreManagerBase<CoreChartDataManager> // TypeDefIndex: 13433
{
	// Fields
	public ManifestChartData manifestChartData; // 0x60
	public GlobalChartData globalChartData; // 0x68
	public DebugChartData debugChartData; // 0x70
	public URLChartData urlChartData; // 0x78
	public AnalyticsChartData analyticsChartData; // 0x80
	public SystemLocalizationChartData systemLocalizationChartData; // 0x88
	public LocalizationChartData localizationChartData; // 0x90
	public ListChartData listChartData; // 0x98
	public LevelOverrideChartData levelOverrideChartData; // 0xA0
	public LevelChartData levelChartData; // 0xA8
	public ImageChartData imageChartData; // 0xB0
	private FieldInfo[] _fields; // 0xB8
	private static bool _isDownloading; // 0x00
	private Dictionary<string, DBEntry> _dbEntries; // 0xC0
	private static string _chartCacheFolderPath; // 0x08
	private static bool _offlineMode; // 0x10
	private static Dictionary<Type, MethodInfo> _cachedGetDefsMethods; // 0x18
	private static Dictionary<Type, MethodInfo> _cachedGetDefMethods; // 0x20

	// Properties
	public FieldInfo[] Fields { get; } // 0x000000018147DA90-0x000000018147DAF0 
	public IEnumerable<ChartDataObject> ChartDataObjects { [IteratorStateMachine] /* 0x0000000180157920-0x0000000180157970 */ get; } // 0x000000018147D670-0x000000018147D6D0 
	public static bool IsDownloading { get; } // 0x000000018147DAF0-0x000000018147DB50 
	public Dictionary<string, DBEntry> DBEntries { get; } // 0x000000018147D6D0-0x000000018147DA90 
	public static string ChartCacheFolderPath { get; } // 0x000000018147D500-0x000000018147D670 
	public static bool OfflineMode { get; } // 0x000000018147DB50-0x000000018147DBB0 

	// Nested types
	public class DBSqlTableEntry // TypeDefIndex: 13434
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <defId>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <template>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <data>k__BackingField; // 0x20

		// Properties
		public string defId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public string template { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string data { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0

		// Constructors
		public DBSqlTableEntry(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public class DBEntry // TypeDefIndex: 13435
	{
		// Fields
		private SQLiteConnection _connection; // 0x10
		private bool? _isDBFileEncrypted; // 0x18
		public string currentHash; // 0x20
		public string previousHash; // 0x28
		private double editorLastHashTime; // 0x30
		public ChartDataObject parentChartDataObject; // 0x38

		// Properties
		public SQLiteConnection Connection { get; } // 0x000000018147E750-0x000000018147EA20 
		public bool IsDBFileEncrypted { get; } // 0x000000018147F310-0x000000018147F4D0 
		public bool HashChanged { get; } // 0x0000000180EB4200-0x0000000180EB4210 
		public bool HashIsValid { get; } // 0x0000000181354B10-0x0000000181354B30 
		public bool HashIsReset { get; } // 0x000000018147F140-0x000000018147F1A0 
		public string DBFileCachedTempPath { get; } // 0x000000018147EC70-0x000000018147EDD0 
		public string DBFileCachedPath { get; } // 0x000000018147EAF0-0x000000018147EBA0 
		public string DBFileCachedFilename { get; } // 0x000000018147EA20-0x000000018147EAF0 
		public string DBFileCachedTempFilename { get; } // 0x000000018147EBA0-0x000000018147EC70 
		public bool IsDBFileCached { get; } // 0x000000018147F1A0-0x000000018147F1E0 
		public string DBFileURL { get; } // 0x000000018147EDD0-0x000000018147F0C0 
		public string HashFileURL { get; } // 0x000000018147F0C0-0x000000018147F140 
		public string CachedHashKey { get; } // 0x000000018147E660-0x000000018147E6C0 
		public string CachedHash { get; set; } // 0x000000018147E6C0-0x000000018147E750 0x000000018147F4D0-0x000000018147F550
		public bool IsDBFileCorrupt { get; } // 0x000000018147F1E0-0x000000018147F310 

		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DownloadCurrentHashAndSetIt>d__37 : IEnumerator<object> // TypeDefIndex: 13436
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DBEntry <>4__this; // 0x20
			public bool inCheckForResetHash; // 0x28
			private UnityWebRequest <hashWebRequest>5__2; // 0x30
			private int <downloadManifestHashRetry>5__3; // 0x38
			private string <cHashURL>5__4; // 0x40

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DownloadCurrentHashAndSetIt>d__37(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181324DB0-0x0000000181325A50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181325A50-0x0000000181325AA0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DownloadDBFileAndCacheIt>d__41 : IEnumerator<object> // TypeDefIndex: 13437
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DBEntry <>4__this; // 0x20
			public int inRetryDBConnectCount; // 0x28
			private UnityWebRequest <downloadingDBFileWebRequest>5__2; // 0x30
			private bool <downloadingDBFileCorrupted>5__3; // 0x38
			private int <downloadDBFileRetry>5__4; // 0x3C
			private string <cChartDBURL>5__5; // 0x40
			private ulong <previousBytes>5__6; // 0x48
			private float <maxTimeBeforeReset>5__7; // 0x50
			private float <timeSinceChange>5__8; // 0x54
			private FileStream <SourceStream>5__9; // 0x58
			private FileStream <DestinationStream>5__10; // 0x60
			private Task <copyToAsync>5__11; // 0x68

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DownloadDBFileAndCacheIt>d__41(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x0000000181327040-0x0000000181327150
			private bool MoveNext(); // 0x0000000181325AA0-0x0000000181326FF0
			private void <>m__Finally1(); // 0x0000000181327150-0x00000001813271A0
			private void <>m__Finally2(); // 0x00000001813271A0-0x00000001813271F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181326FF0-0x0000000181327040
		}

		// Constructors
		public DBEntry(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void CloseConnection(); // 0x000000018147DC60-0x000000018147DC90
		public void ClearCachedDBFile(); // 0x000000018147DC10-0x000000018147DC60
		[IteratorStateMachine] // 0x0000000180158F30-0x0000000180158F80
		public IEnumerator DownloadCurrentHashAndSetIt(bool inCheckForResetHash = false /* Metadata: 0x00783CB1 */); // 0x000000018147DC90-0x000000018147DD10
		public bool EditorDownloadCurrentHashAndSetIt(); // 0x000000018147DF70-0x000000018147E300
		[IteratorStateMachine] // 0x00000001801591F0-0x0000000180159240
		public IEnumerator DownloadDBFileAndCacheIt(int inRetryDBConnectCount = 0 /* Metadata: 0x00783CB2 */); // 0x000000018147DEF0-0x000000018147DF70
		private void DownloadDBFileAndCacheItRetry(int inRetryDBConnectCount); // 0x000000018147DD10-0x000000018147DEF0
		public void EditorDownloadDBFileAndCacheIt(); // 0x000000018147E300-0x000000018147E660
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <get_ChartDataObjects>d__15 : IEnumerable<ChartDataObject>, IEnumerator<ChartDataObject> // TypeDefIndex: 13438
	{
		// Fields
		private int <>1__state; // 0x10
		private ChartDataObject <>2__current; // 0x18
		private int <>l__initialThreadId; // 0x20
		private FieldInfo[] <>7__wrap1; // 0x28
		private int <>7__wrap2; // 0x30

		// Properties
		ChartDataObject IEnumerator<ChartDataObject>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <get_ChartDataObjects>d__15(int <>1__state); // 0x000000018094DE20-0x000000018094DE50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814848C0-0x0000000181484AC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181484B50-0x0000000181484BA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator<ChartDataObject> IEnumerable<ChartDataObject>.GetEnumerator(); // 0x0000000181484AC0-0x0000000181484B50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181484AC0-0x0000000181484B50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__21 : IEnumerator<object> // TypeDefIndex: 13439
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreChartDataManager <>4__this; // 0x20
		private string <streamingPath>5__2; // 0x28
		private List<string> <>7__wrap2; // 0x30
		private string <cChartIncludedPath>5__4; // 0x48
		private string <cChartCachedPath>5__5; // 0x50
		private WWW <www>5__6; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000181482270-0x0000000181482320
		private bool MoveNext(); // 0x0000000181481A00-0x0000000181482220
		private void <>m__Finally1(); // 0x0000000181482320-0x0000000181482360
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181482220-0x0000000181482270
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13440
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__36_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181484180-0x00000001814841E0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetCurrentHashesAndDownloadDBsIfNeeded>b__36_0(bool connected); // 0x0000000181483F70-0x0000000181483FE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetCurrentHashesAndDownloadDBsIfNeeded>d__36 : IEnumerator<object> // TypeDefIndex: 13441
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreChartDataManager <>4__this; // 0x20
		public bool inCheckForResetHash; // 0x28
		public bool inInitialCall; // 0x29
		private bool <forcedOfflineMode>5__2; // 0x2A
		private Dictionary<string, DBEntry> <>7__wrap2; // 0x30
		private DBEntry <cDBEntry>5__4; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetCurrentHashesAndDownloadDBsIfNeeded>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001814811D0-0x0000000181481280
		private bool MoveNext(); // 0x0000000181480540-0x0000000181481180
		private void <>m__Finally1(); // 0x0000000181481280-0x00000001814812C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181481180-0x00000001814811D0
	}

	// Constructors
	public CoreChartDataManager(); // 0x000000018147D4C0-0x000000018147D500
	static CoreChartDataManager(); // 0x000000018147D410-0x000000018147D4C0

	// Methods
	public void ClearAllCharts(); // 0x000000018147B110-0x000000018147B410
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x0000000180157C90-0x0000000180157CE0
	public override IEnumerator InitCoroutine(); // 0x000000018147CB40-0x000000018147CBA0
	public override void Deinit(); // 0x000000018147B4F0-0x000000018147B7A0
	public static void ClearCachedCharts(); // 0x000000018147B410-0x000000018147B4F0
	private string GetDatabaseHashURLForDatabaseName(string inDBName); // 0x000000018147CAD0-0x000000018147CB40
	[IteratorStateMachine] // 0x0000000180157EE0-0x0000000180157F30
	public IEnumerator GetCurrentHashesAndDownloadDBsIfNeeded(bool inInitialCall, bool inCheckForResetHash = false /* Metadata: 0x00783CB0 */); // 0x000000018147CA50-0x000000018147CAD0
	public static bool EditorGetCurrentHashesAndDownloadDBsIfNeeded(); // 0x000000018147B7A0-0x000000018147B9E0
	public void SetChartObjectInstances(); // 0x000000018147CE80-0x000000018147D410
	public static bool ExtractZipFile(string inPath, string inPassword, string inOutPath); // 0x000000018147BE30-0x000000018147C600
	public static bool ExtractTarFile(string inPath, string inOutPath); // 0x000000018147B9E0-0x000000018147BE30
	public BundledDef GenericGetBundledDefWithDefID(string inChartName, string inDefID); // 0x000000018147C600-0x000000018147CA50
	public static T GenericGetDefWithDefID<T>(string inChartName, string inDefID)
		where T : BaseDef;
	public static List<T> GenericGetDefsWithDefIDs<T>(string inChartName, List<string> inDefIDs)
		where T : BaseDef;
	public static List<T> GenericGetDefsWithDefIDs<T>(Type inChartType, List<string> inDefIDs)
		where T : BaseDef;
	public static T GenericGetDefWithDefID<T>(Type inChartType, string inDefID)
		where T : BaseDef;
	private new void OnDestroy(); // 0x000000018147CBA0-0x000000018147CE80
}


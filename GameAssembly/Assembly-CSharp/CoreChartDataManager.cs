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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreChartDataManager : CoreManagerBase<CoreChartDataManager> // TypeDefIndex: 11104
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
	public FieldInfo[] Fields { get; } // 0x0000000180A66EB0-0x0000000180A66F10 
	public IEnumerable<ChartDataObject> ChartDataObjects { [IteratorStateMachine] /* 0x0000000180238D80-0x0000000180238DD0 */ get; } // 0x0000000180A66AB0-0x0000000180A66B10 
	public static bool IsDownloading { get; } // 0x0000000180A66F10-0x0000000180A66F70 
	public Dictionary<string, DBEntry> DBEntries { get; } // 0x0000000180A66B10-0x0000000180A66EB0 
	public static string ChartCacheFolderPath { get; } // 0x0000000180A66940-0x0000000180A66AB0 
	public static bool OfflineMode { get; } // 0x0000000180A66F70-0x0000000180A67030 

	// Nested types
	public class DBSqlTableEntry // TypeDefIndex: 11105
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <defId>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <template>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <data>k__BackingField; // 0x20

		// Properties
		public string defId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public string template { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string data { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0

		// Constructors
		public DBSqlTableEntry(); // 0x0000000180373240-0x0000000180373250
	}

	public class DBEntry // TypeDefIndex: 11106
	{
		// Fields
		private SQLiteConnection _connection; // 0x10
		private bool? _isDBFileEncrypted; // 0x18
		public string currentHash; // 0x20
		public string previousHash; // 0x28
		private double editorLastHashTime; // 0x30
		public ChartDataObject parentChartDataObject; // 0x38

		// Properties
		public SQLiteConnection Connection { get; } // 0x0000000180A72F40-0x0000000180A73210 
		public bool IsDBFileEncrypted { get; } // 0x0000000180A73BD0-0x0000000180A73D90 
		public bool HashChanged { get; } // 0x00000001807642C0-0x00000001807642D0 
		public bool HashIsValid { get; } // 0x0000000180A73A40-0x0000000180A73A60 
		public bool HashIsReset { get; } // 0x0000000180A739E0-0x0000000180A73A40 
		public string DBFileCachedTempPath { get; } // 0x0000000180A73460-0x0000000180A735C0 
		public string DBFileCachedPath { get; } // 0x0000000180A732E0-0x0000000180A73390 
		public string DBFileCachedFilename { get; } // 0x0000000180A73210-0x0000000180A732E0 
		public string DBFileCachedTempFilename { get; } // 0x0000000180A73390-0x0000000180A73460 
		public bool IsDBFileCached { get; } // 0x0000000180A73A60-0x0000000180A73AA0 
		public string DBFileURL { get; } // 0x0000000180A735C0-0x0000000180A73910 
		public string HashFileURL { get; } // 0x0000000180A73910-0x0000000180A739E0 
		public string CachedHashKey { get; } // 0x0000000180A72E50-0x0000000180A72EB0 
		public string CachedHash { get; set; } // 0x0000000180A72EB0-0x0000000180A72F40 0x0000000180A73D90-0x0000000180A73E10
		public bool IsDBFileCorrupt { get; } // 0x0000000180A73AA0-0x0000000180A73BD0 

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DownloadCurrentHashAndSetIt>d__37 : IEnumerator<object> // TypeDefIndex: 11107
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DownloadCurrentHashAndSetIt>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A74BF0-0x0000000180A75810
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A75810-0x0000000180A75860
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DownloadDBFileAndCacheIt>d__41 : IEnumerator<object> // TypeDefIndex: 11108
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DownloadDBFileAndCacheIt>d__41(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180A76D40-0x0000000180A76E40
			private bool MoveNext(); // 0x0000000180A75860-0x0000000180A76CF0
			private void <>m__Finally1(); // 0x0000000180A76E40-0x0000000180A76E90
			private void <>m__Finally2(); // 0x0000000180A76E90-0x0000000180A76EE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A76CF0-0x0000000180A76D40
		}

		// Constructors
		public DBEntry(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void CloseConnection(); // 0x0000000180A72570-0x0000000180A725A0
		public void ClearCachedDBFile(); // 0x0000000180A72520-0x0000000180A72570
		[IteratorStateMachine] // 0x000000018023A700-0x000000018023A750
		public IEnumerator DownloadCurrentHashAndSetIt(bool inCheckForResetHash = false /* Metadata: 0x0077C76C */); // 0x0000000180A725A0-0x0000000180A72610
		public bool EditorDownloadCurrentHashAndSetIt(); // 0x0000000180A727A0-0x0000000180A72B10
		[IteratorStateMachine] // 0x000000018023A8F0-0x000000018023A940
		public IEnumerator DownloadDBFileAndCacheIt(int inRetryDBConnectCount = 0 /* Metadata: 0x0077C76D */); // 0x0000000180A72730-0x0000000180A727A0
		private void DownloadDBFileAndCacheItRetry(int inRetryDBConnectCount); // 0x0000000180A72610-0x0000000180A72730
		public void EditorDownloadDBFileAndCacheIt(); // 0x0000000180A72B10-0x0000000180A72E50
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <get_ChartDataObjects>d__16 : IEnumerable<ChartDataObject>, IEnumerator<ChartDataObject> // TypeDefIndex: 11109
	{
		// Fields
		private int <>1__state; // 0x10
		private ChartDataObject <>2__current; // 0x18
		private int <>l__initialThreadId; // 0x20
		private FieldInfo[] <>7__wrap1; // 0x28
		private int <>7__wrap2; // 0x30

		// Properties
		ChartDataObject IEnumerator<ChartDataObject>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <get_ChartDataObjects>d__16(int <>1__state); // 0x00000001806301B0-0x00000001806301E0

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7C330-0x0000000180A7C520
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7C5B0-0x0000000180A7C600
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator<ChartDataObject> IEnumerable<ChartDataObject>.GetEnumerator(); // 0x0000000180A7C520-0x0000000180A7C5B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180A7C520-0x0000000180A7C5B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__22 : IEnumerator<object> // TypeDefIndex: 11110
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180A78C70-0x0000000180A78D10
		private bool MoveNext(); // 0x0000000180A784A0-0x0000000180A78C20
		private void <>m__Finally1(); // 0x0000000180A78D10-0x0000000180A78D50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A78C20-0x0000000180A78C70
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11111
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__37_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180A7C130-0x0000000180A7C190
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetCurrentHashesAndDownloadDBsIfNeeded>b__37_0(bool connected); // 0x0000000180A7BF50-0x0000000180A7BFC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetCurrentHashesAndDownloadDBsIfNeeded>d__37 : IEnumerator<object> // TypeDefIndex: 11112
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetCurrentHashesAndDownloadDBsIfNeeded>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x0000000180A77FA0-0x0000000180A78050
		private bool MoveNext(); // 0x0000000180A77370-0x0000000180A77F50
		private void <>m__Finally1(); // 0x0000000180A78050-0x0000000180A78090
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A77F50-0x0000000180A77FA0
	}

	// Constructors
	public CoreChartDataManager(); // 0x0000000180A66900-0x0000000180A66940
	static CoreChartDataManager(); // 0x0000000180A66850-0x0000000180A66900

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x0000000180238AA0-0x0000000180238AC0
	public static void FastPlayModeReset(); // 0x0000000180A65A20-0x0000000180A65A80
	public void ClearAllCharts(); // 0x0000000180A645E0-0x0000000180A648C0
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x0000000180239220-0x0000000180239270
	public override IEnumerator InitCoroutine(); // 0x0000000180A65FD0-0x0000000180A66030
	public override void Deinit(); // 0x0000000180A64990-0x0000000180A64C30
	public static void ClearCachedCharts(); // 0x0000000180A648C0-0x0000000180A64990
	private string GetDatabaseHashURLForDatabaseName(string inDBName); // 0x0000000180A65F20-0x0000000180A65FD0
	[IteratorStateMachine] // 0x0000000180239500-0x0000000180239550
	public IEnumerator GetCurrentHashesAndDownloadDBsIfNeeded(bool inInitialCall, bool inCheckForResetHash = false /* Metadata: 0x0077C76B */); // 0x0000000180A65EA0-0x0000000180A65F20
	public static bool EditorGetCurrentHashesAndDownloadDBsIfNeeded(); // 0x0000000180A64C30-0x0000000180A64E60
	public void SetChartObjectInstances(); // 0x0000000180A662F0-0x0000000180A66850
	public static bool ExtractZipFile(string inPath, string inPassword, string inOutPath); // 0x0000000180A65280-0x0000000180A65A20
	public static bool ExtractTarFile(string inPath, string inOutPath); // 0x0000000180A64E60-0x0000000180A65280
	public BundledDef GenericGetBundledDefWithDefID(string inChartName, string inDefID); // 0x0000000180A65A80-0x0000000180A65EA0
	public static T GenericGetDefWithDefID<T>(string inChartName, string inDefID)
		where T : BaseDef;
	public static List<T> GenericGetDefsWithDefIDs<T>(string inChartName, List<string> inDefIDs)
		where T : BaseDef;
	public static List<T> GenericGetDefsWithDefIDs<T>(Type inChartType, List<string> inDefIDs)
		where T : BaseDef;
	public static T GenericGetDefWithDefID<T>(Type inChartType, string inDefID)
		where T : BaseDef;
	private new void OnDestroy(); // 0x0000000180A66030-0x0000000180A662F0
}


﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SQLite4Unity3d;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChartDataObject<T, U> : ChartDataObject // TypeDefIndex: 10995
	where T : BaseDef, new()
	where U : ChartDataObject<T, U>
{
	// Fields
	[ReloadCSV] // 0x00000001801CEA70-0x00000001801CEA80
	public bool editorStubReloadButtons;
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public string editorSearchString;
	[SearchCSV] // 0x00000001801CEA70-0x00000001801CEA80
	public bool editorStubSearchableDefList;
	private List<string> _defHeaderNames;
	private Dictionary<string, T> _parsedDefsByID;
	private HashSet<string> _notFoundDefIDs;
	private List<T> _defList;
	[SetInstance] // 0x00000001801CEA70-0x00000001801CEA80
	protected static U _instance;
	private bool? _isManifest;
	[NonSerialized]
	private bool _isForcedReloaded;
	[NonSerialized]
	public bool _isReloaded;
	[NonSerialized]
	public bool isDownloading;
	[NonSerialized]
	public bool isSuccess;
	[NonSerialized]
	private string _thisChartName;
	private List<string> _tokens;
	private Coroutine _cleanupRoutine;

	// Properties
	public List<T> defList { get; }
	public static U instance { get; }
	public bool IsManifest { get; }
	public bool isReloaded { get; set; }
	public virtual string BundleRoot { get; }
	public override string ChartName { get; }
	private string DebugVerboseName { get; }
	public CoreChartDataManager.DBEntry DBEntry { get; }
	public SQLiteConnection DBConnection { get; }

	// Nested types
	public class DefListSort : IComparer<T> // TypeDefIndex: 10996
	{
		// Constructors
		public DefListSort();

		// Methods
		public int Compare(T x, T y);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CleanupOldDefIDs>d__57 : IEnumerator<object> // TypeDefIndex: 10997
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public ChartDataObject<T, U> <>4__this;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CleanupOldDefIDs>d__57(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	// Constructors
	public ChartDataObject();
	static ChartDataObject();

	// Methods
	private void ForceLoadAllDefs();
	public void SetInstance();
	public void UnsetInstance();
	public void LazyReload();
	public override BaseDef GetDef(string inDefID, bool inShowErrors = false /* Metadata: 0x0077C5FC */);
	public static void EditorDownloadAndReloadCSVChart();
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public void Log(string inLog);
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public void LogError(string inLog);
	public void ClearParsedDefs();
	public void ReloadChart();
	public virtual void WriteCSVChart();
	public void WriteDefines();
	public static T GetRandomDef();
	public static bool HasDefWithDefID(string inDefID);
	public static T GetDefWithDefID(string inDefID, bool inShowErrors = true /* Metadata: 0x0077C5FD */);
	private static string XorEncryptOrDecrypt(string inText, string inKey);
	private static string XorDecrypt(bool inUseEncryption, string inBase64Text, string inKey);
	private static string XorEncrypt(bool inUseEncryption, string inText, string inKey);
	public string QueryDataWithDefID(string inDefID);
	private void ParseData(string inData);
	public override List<ValueTuple<string, string>> GetAllDefIDs();
	[IteratorStateMachine] // 0x0000000180200C80-0x0000000180200CD0
	private IEnumerator CleanupOldDefIDs();
	public List<T> InstanceGetDefsWithDefIDs(List<string> inDefIDs, bool inShowErrors = true /* Metadata: 0x0077C5FE */);
	public static List<T> GetDefsWithDefIDs(List<string> inDefIDs, bool inShowErrors = true /* Metadata: 0x0077C5FF */);
	public static T GetDefWithDefName(string inDefName, bool inShowErrors = true /* Metadata: 0x0077C600 */);
	public static T EditorGetDefWithDefID(string inDefID, bool inShowErrors = true /* Metadata: 0x0077C601 */);
	public static T EditorGetDefWithDefName(string inDefName, bool inShowErrors = true /* Metadata: 0x0077C602 */);
	public void AddDef(T inDef);
	public List<string> EditorGetDefNames();
	public List<string> EditorGetDefIDs();
	public static List<CoreChartDataManager.DBSqlTableEntry> GetAllDefEntries();
	public static List<string> GetDefIDs();
	public static List<string> GetDefNames();
	public virtual void EditorDrawDef(string inDefID, Rect inRect);
	public string GetRootBundlePath();
	protected virtual T CreateDef(Dictionary<string, string> inHeaderNameToDataDict);
	public static TC GetDefComponentWithDefName<TC>(string inDefID)
		where TC : DefComponent;
	public static TC GetDefComponentWithDefID<TC>(string inDefID, bool inShowErrors = true /* Metadata: 0x0077C603 */)
		where TC : DefComponent;
	public static List<TC> GetDefComponentsWithDefIDs<TC>(List<string> inDefIDs, bool inShowErrors = true /* Metadata: 0x0077C604 */)
		where TC : DefComponent;
}


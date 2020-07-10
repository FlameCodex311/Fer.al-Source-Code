/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using LitJson;
using Microsoft.Extensions.ObjectPool;
using UnityEngine;
using UnityEngine.Networking;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PropertyEditor // TypeDefIndex: 11588
{
	// Fields
	public static bool requestRepaint; // 0x00
	private static string _currentProjectName; // 0x08
	private static string _currentChartName; // 0x10
	private static Project _currentProject; // 0x18
	private static Chart _currentChart; // 0x20
	private static List<ChartDefComponent> _chartDefComponents; // 0x28
	[TupleElementNames] // 0x00000001800DE580-0x00000001800DE600
	private static Dictionary<string, ValueTuple<Type, MethodInfo>> _chartDefComponentSearchMethods; // 0x30
	private static string _propertyChartCacheFolderPath; // 0x38
	private static List<Project> _projects; // 0x40
	private static State _currentState; // 0x48
	private static DateTime _currentStateSetTime; // 0x50
	private static NoTemplate _cachedNoTemplate; // 0x58
	private static string _cachedNoTemplateHash; // 0x60
	private static MissingTemplate _cachedMissingTemplate; // 0x68
	private static string _cachedMissingTemplateHash; // 0x70
	private static List<ChartTemplate> _chartTemplates; // 0x78
	private static Dictionary<Type, Dictionary<string, List<Attribute>>> _cachedCustomAttributes; // 0x80
	private static Dictionary<Type, string> _cachedTypeName; // 0x88
	public static string focusNextOnGUIName; // 0x90
	public static int focusNextOnGUIDoubleTap; // 0x98

	// Properties
	public static string CurrentProjectName { get; set; } // 0x0000000181162250-0x0000000181162310 0x00000001811627D0-0x0000000181162890
	public static string CurrentChartName { get; set; } // 0x0000000181161FA0-0x0000000181162030 0x00000001811626B0-0x0000000181162710
	public static Project CurrentProject { get; set; } // 0x0000000181162310-0x0000000181162390 0x0000000181162890-0x0000000181162950
	public static Chart CurrentChart { get; set; } // 0x0000000181162030-0x0000000181162250 0x0000000181162710-0x00000001811627D0
	public static string DataServerURL { get; } // 0x0000000181162560-0x0000000181162590 
	public static List<ChartDefComponent> ChartDefComponents { get; } // 0x0000000181161710-0x0000000181161B30 
	[TupleElementNames] // 0x00000001800DFD60-0x00000001800DFDE0
	public static Dictionary<string, ValueTuple<Type, MethodInfo>> ChartDefComponentSearchMethods { get; } // 0x0000000181160FF0-0x0000000181161710 
	public static bool ShowPreviews { get; set; } // 0x00000001803C28F0-0x00000001803C2900 0x00000001803581E0-0x00000001803581F0
	public static bool AdvancedMode { get; set; } // 0x00000001803C28F0-0x00000001803C2900 0x00000001803581E0-0x00000001803581F0
	public static bool FormatMode { get; set; } // 0x00000001803C28F0-0x00000001803C2900 0x00000001803581E0-0x00000001803581F0
	public static string LoginUserName { get; set; } // 0x00000001811625C0-0x00000001811625F0 0x00000001803581E0-0x00000001803581F0
	public static string LoginPassword { get; set; } // 0x0000000181162590-0x00000001811625C0 0x00000001803581E0-0x00000001803581F0
	public static string PropertyChartCacheFolderPath { get; } // 0x0000000181162650-0x00000001811626B0 
	public static List<Project> Projects { get; } // 0x00000001811625F0-0x0000000181162650 
	public static State CurrentState { get; set; } // 0x0000000181162390-0x0000000181162560 0x0000000181162950-0x0000000181162A20
	public static NoTemplate CachedNoTemplate { get; } // 0x0000000181160ED0-0x0000000181160FF0 
	public static string CachedNoTemplateHash { get; } // 0x0000000181160CF0-0x0000000181160ED0 
	public static MissingTemplate CachedMissingTemplate { get; } // 0x0000000181160BD0-0x0000000181160CF0 
	public static string CachedMissingTemplateHash { get; } // 0x00000001811609F0-0x0000000181160BD0 
	public static List<ChartTemplate> ChartTemplates { get; } // 0x0000000181161B30-0x0000000181161FA0 

	// Nested types
	public class Chart // TypeDefIndex: 11589
	{
		// Fields
		public Project parentProject; // 0x10
		public long dtStamp; // 0x18
		public string name; // 0x20
		public string label; // 0x28
		public bool commitable; // 0x30
		private List<DefEntry> _defEntries; // 0x38
		public Dictionary<string, DefEntry> defEntryDict; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsRefreshing>k__BackingField; // 0x48
		private bool _lastIsDirty; // 0x49
		private double _lastIsDirtyCheckFrame; // 0x50

		// Properties
		public List<DefEntry> defEntries { get; set; } // 0x0000000181150AB0-0x0000000181150C70 0x00000001803A2820-0x00000001803A2830
		public bool IsRefreshing { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
		public bool IsDirty { get; } // 0x00000001805E3A70-0x00000001805E3A80 
		public bool IsDirtyAndAllowCommit { get; } // 0x0000000181150920-0x0000000181150AB0 

		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 11590
		{
			// Fields
			[TupleElementNames] // 0x00000001800E0CE0-0x00000001800E0D60
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass25_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <CommitRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CommitRoutine>d__25 : IEnumerator<object> // TypeDefIndex: 11591
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Chart <>4__this; // 0x20
			public string inComment; // 0x28
			public List<DefEntry> inOverrideEntries; // 0x30
			public bool inCommitFormatChanges; // 0x38
			private <>c__DisplayClass25_0 <>8__1; // 0x40
			private List<DefEntry> <modifyEntries>5__2; // 0x48
			private List<DefEntry> <deleteEntries>5__3; // 0x50

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CommitRoutine>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181162A20-0x0000000181163730
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181163730-0x0000000181163780
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 11592
		{
			// Fields
			[TupleElementNames] // 0x00000001800E1E10-0x00000001800E1E90
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass27_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <CreateNewRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
			internal void <CreateNewRoutine>b__1(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CreateNewRoutine>d__27 : IEnumerator<object> // TypeDefIndex: 11593
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Chart <>4__this; // 0x20
			private <>c__DisplayClass27_0 <>8__1; // 0x28
			public string inDefName; // 0x30
			public string inTemplateClass; // 0x38
			public string inDataJSON; // 0x40
			public Dictionary<string, JsonData> inColumnData; // 0x48
			public Action<DefEntry> inNewDefEntryCallback; // 0x50
			private DefEntry <nDefEntry>5__2; // 0x58

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CreateNewRoutine>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181163780-0x00000001811641E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001811641E0-0x0000000181164230
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 11594
		{
			// Fields
			[TupleElementNames] // 0x00000001800E2A40-0x00000001800E2AC0
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <DeleteRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DeleteRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 11595
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Chart <>4__this; // 0x20
			public List<DefEntry> inDelete; // 0x28
			private <>c__DisplayClass29_0 <>8__1; // 0x30

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DeleteRoutine>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181165060-0x0000000181165600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181165600-0x0000000181165650
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 11596
		{
			// Fields
			public ExportDefEntry cImportDefEntry; // 0x10

			// Constructors
			public <>c__DisplayClass32_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal bool <ImportAsJSON>b__1(DefEntry inDefEntry); // 0x0000000181166DD0-0x0000000181166E10
		}

		// Constructors
		public Chart(Project inParentProject); // 0x0000000181150870-0x0000000181150920

		// Methods
		public DefEntry GetDefEntryWithDefName(string inName); // 0x000000018114F340-0x000000018114F4E0
		public DefEntry GetDefEntry(string inID); // 0x000000018114F4E0-0x000000018114F550
		public void RevertAll(); // 0x0000000181150700-0x0000000181150840
		public void Commit(string inComment, bool inCommitFormatChanges, List<DefEntry> inOverrideEntries = null); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E03C0-0x00000001800E0410
		public IEnumerator CommitRoutine(string inComment, bool inCommitFormatChanges = false /* Metadata: 0x00782A97 */, List<DefEntry> inOverrideEntries = null); // 0x000000018114F030-0x000000018114F0C0
		public void CreateNew(string inDefName, string inTemplateClass = null, string inDataJSON = null, Dictionary<string, JsonData> inColumnData = null, Action<DefEntry> inNewDefEntryCallback = null); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E05B0-0x00000001800E0600
		public IEnumerator CreateNewRoutine(string inDefName, string inTemplateClass = null, string inDataJSON = null, Dictionary<string, JsonData> inColumnData = null, Action<DefEntry> inNewDefEntryCallback = null); // 0x000000018114F0C0-0x000000018114F170
		public void Delete(List<DefEntry> inDelete); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E0890-0x00000001800E08E0
		public IEnumerator DeleteRoutine(List<DefEntry> inDelete); // 0x000000018114F170-0x000000018114F1E0
		public string ExportAsJSON(); // 0x000000018114F280-0x000000018114F340
		public string ExportAsCSV(); // 0x000000018114F1E0-0x000000018114F280
		public void ImportAsJSON(string inJSON); // 0x000000018114FD00-0x0000000181150000
		public void ImportAsCSV(string inCSV); // 0x000000018114F550-0x000000018114FD00
		private ValueTuple<List<string>, List<string>> ParseCSVHeadersAndLines(string inCSV); // 0x0000000181150000-0x00000001811503B0
		private Dictionary<string, string> ParseCSVLine(List<string> inHeaders, string inCSV); // 0x00000001811503B0-0x0000000181150700
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <ImportAsJSON>b__32_0(ExportChartEntry inChart); // 0x0000000181150840-0x0000000181150870
	}

	public static class DataServerCommands // TypeDefIndex: 11597
	{
		// Fields
		public const string GetProjects = "GTS"; // Metadata: 0x00782A98
		public const string GetCharts = "GAX"; // Metadata: 0x00782A9F
		public const string GetNewID = "GID"; // Metadata: 0x00782AA6
		public const string ChangeProps = "CCG"; // Metadata: 0x00782AAD
		public const string PostToGame = "PTG"; // Metadata: 0x00782AB4
		public const string History = "GLH"; // Metadata: 0x00782ABB
		public const string Poll = "PLL"; // Metadata: 0x00782AC2
		public const string BuildManifest = "BMF"; // Metadata: 0x00782AC9
	}

	[Serializable]
	public class DataJSONGAXResponse // TypeDefIndex: 11598
	{
		// Fields
		public string cmd; // 0x10
		public DataJSONGAXResponseReply reply; // 0x18

		// Constructors
		public DataJSONGAXResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class DataJSONGAXResponseReply // TypeDefIndex: 11599
	{
		// Fields
		public int projId; // 0x10
		public List<DataJSONGAXResponseReplyRecord> records; // 0x18

		// Constructors
		public DataJSONGAXResponseReply(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class DataJSONGAXResponseReplyRecord // TypeDefIndex: 11600
	{
		// Fields
		public string defName; // 0x10
		public List<DataJSONGAXResponseReplyDefRecord> defRecords; // 0x18

		// Constructors
		public DataJSONGAXResponseReplyRecord(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class DataJSONGAXResponseReplyDefRecord // TypeDefIndex: 11601
	{
		// Fields
		public uint _id; // 0x10
		public string DefName; // 0x18
		public string DataJSON; // 0x20

		// Constructors
		public DataJSONGAXResponseReplyDefRecord(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class DataServerResponseReplyStatus // TypeDefIndex: 11602
	{
		// Fields
		public bool status; // 0x10
		public List<DataServerResponseReplyStatusReason> reason; // 0x18

		// Constructors
		public DataServerResponseReplyStatus(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class DataServerResponseReplyStatusReason // TypeDefIndex: 11603
	{
		// Fields
		public string message; // 0x10

		// Constructors
		public DataServerResponseReplyStatusReason(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class DataServerResponseBase<T> // TypeDefIndex: 11604
	{
		// Fields
		public T reply;

		// Constructors
		public DataServerResponseBase();
	}

	[Serializable]
	public class GTSResponseReply // TypeDefIndex: 11605
	{
		// Fields
		public List<GTSResponseReplyProject> projects; // 0x10

		// Constructors
		public GTSResponseReply(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class GTSResponseReplyProject // TypeDefIndex: 11606
	{
		// Fields
		public int id; // 0x10
		public string name; // 0x18
		public string label; // 0x20
		public List<GTSResponseReplyProjectDef> defs; // 0x28

		// Constructors
		public GTSResponseReplyProject(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class GTSResponseReplyProjectDef // TypeDefIndex: 11607
	{
		// Fields
		public string name; // 0x10
		public string label; // 0x18

		// Constructors
		public GTSResponseReplyProjectDef(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public class ChartDefComponent // TypeDefIndex: 11608
	{
		// Fields
		public ChartComponentAttribute attribute; // 0x10
		public Type type; // 0x18

		// Constructors
		public ChartDefComponent(ChartComponentAttribute inAttribute, Type inType); // 0x00000001803DA900-0x00000001803DA940
	}

	public class DefEntryComponent // TypeDefIndex: 11609
	{
		// Fields
		private DefEntry _parentDefEntry; // 0x10
		private string _componentClass; // 0x18
		private bool _componentIsCustom; // 0x20
		private string _componentJSON; // 0x28
		private string _originalComponentJSON; // 0x30
		private string _cachedDiffText; // 0x38
		private bool _defComponentInstanceNeedsRefresh; // 0x40
		private DefComponent _defComponentInstance; // 0x48

		// Properties
		public string ComponentClass { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000181151930-0x0000000181151970
		public bool ComponentIsCustom { get; set; } // 0x00000001803C19E0-0x00000001803C19F0 0x0000000181151970-0x0000000181151980
		public string ComponentJSON { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000181151980-0x00000001811519E0
		public string OriginalComponentJSON { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001811519E0-0x0000000181151A40
		public string CachedDiffText { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
		public DefComponent DefComponentInstance { get; } // 0x00000001811515F0-0x0000000181151930 

		// Constructors
		public DefEntryComponent(DefEntry inParentDefEntry); // 0x0000000181151530-0x0000000181151560
		public DefEntryComponent(DefEntry inParentDefEntry, string inComponentClass); // 0x0000000181151560-0x00000001811515A0
		public DefEntryComponent(DefEntry inParentDefEntry, string inComponentClass, string inComponentJSON); // 0x00000001811515A0-0x00000001811515F0

		// Methods
		public void AddDiffLine(string inLine, string inColorCode, bool inBold = false /* Metadata: 0x00782AD0 */); // 0x0000000181150CD0-0x0000000181151220
		public void InternalRepair(); // 0x0000000181151230-0x00000001811514F0
		public void ClearDefComponentInstance(); // 0x0000000181151220-0x0000000181151230
		public void RebuildComponentJSON(); // 0x00000001811514F0-0x0000000181151530
	}

	public class DefEntry // TypeDefIndex: 11610
	{
		// Fields
		public Chart parentChart; // 0x10
		public Vector2 editorCommitDiffScrollPos; // 0x18
		public int treeViewID; // 0x20
		private bool _allowCommit; // 0x24
		private bool _markForDelete; // 0x25
		private bool _isDirty; // 0x26
		public string defID; // 0x28
		private string _defName; // 0x30
		private string _fullCategoryName; // 0x38
		private List<HistoryEntry> _historyEntries; // 0x40
		private bool _cachedDiffTextWasSet; // 0x48
		private string _cachedDiffText; // 0x50
		private string _originalDefName; // 0x58
		private string _serverDataJSON; // 0x60
		private string _originalDataJSON; // 0x68
		private string _originalTemplateFormatHash; // 0x70
		private Dictionary<string, JsonData> _originalColumnData; // 0x78
		private Dictionary<string, JsonData> _columnData; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <DataJSONEditMode>k__BackingField; // 0x88
		private string _dataJSON; // 0x90
		private bool _userSetNewTemplateClass; // 0x98
		private string _templateClass; // 0xA0
		private ChartTemplate _template; // 0xA8
		private string _lastTemplateClass; // 0xB0
		private string _templateFormatHash; // 0xB8
		private List<DefEntryComponent> _components; // 0xC0
		private static ObjectPool<StringBuilder> _stringBuilderPool; // 0x00
		private List<StringBuilder> _componentJSONsTemp; // 0xC8
		private StringBuilder _rebuildDataJSONSB; // 0xD0

		// Properties
		public bool AllowCommit { get; set; } // 0x0000000181154210-0x0000000181154220 0x00000001804884F0-0x0000000180488500
		public bool ValidForCommit { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public bool MarkForDelete { get; set; } // 0x0000000180487D90-0x0000000180487DA0 0x0000000181156E20-0x0000000181156E40
		public bool FormatIsDifferentFromServer { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool FormatIsDifferentFromCode { get; } // 0x00000001811561A0-0x00000001811561F0 
		public bool IsWrongFormat { get; } // 0x00000001811563A0-0x00000001811564F0 
		public bool IsDirty { get; set; } // 0x0000000180487D60-0x0000000180487D70 0x0000000181156D30-0x0000000181156E20
		public string DefName { get; set; } // 0x0000000180397720-0x0000000180397730 0x0000000181156C50-0x0000000181156D30
		public string FullDefName { get; } // 0x0000000181156300-0x0000000181156360 
		public string TemplateCategoryName { get; } // 0x00000001811567F0-0x0000000181156870 
		public string FullCategoryName { get; } // 0x00000001811561F0-0x0000000181156300 
		public bool HasHistory { get; } // 0x0000000181156360-0x00000001811563A0 
		public List<HistoryEntry> HistoryEntries { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public string CachedDiffText { get; } // 0x0000000181154220-0x0000000181155FF0 
		public string SearchLabel { get; } // 0x00000001811564F0-0x0000000181156760 
		public string OriginalDefName { get; set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public string OriginalDataJSON { get; set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
		public string OriginalTemplateFormatHash { get; set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
		public Dictionary<string, JsonData> OriginalColumnData { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public Dictionary<string, JsonData> ColumnData { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
		public bool ColumnDataDirty { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool DataJSONEditMode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E88A0-0x00000001804E88B0 0x0000000180386220-0x0000000180386230
		public string DataJSON { get; set; } // 0x0000000180382A80-0x0000000180382A90 0x0000000181156C10-0x0000000181156C50
		public string TemplateClass { get; set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0
		public ChartTemplate Template { get; set; } // 0x0000000181156B60-0x0000000181156C10 0x0000000181156E40-0x0000000181156F90
		public string TemplateFormatHash { get; set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x00000001803D8F00-0x00000001803D8F10
		public List<DefEntryComponent> Components { get; } // 0x00000001804A1050-0x00000001804A1060 
		public List<DefEntryComponent> TemplateComponents { get; } // 0x0000000181156870-0x0000000181156B60 
		public List<DefEntryComponent> CustomComponents { get; } // 0x0000000181155FF0-0x00000001811561A0 
		private static ObjectPool<StringBuilder> StringBuilderPool { get; } // 0x0000000181156760-0x00000001811567F0 

		// Nested types
		[Serializable]
		public class DataJSONObject // TypeDefIndex: 11611
		{
			// Fields
			public string templateClass; // 0x10
			public List<Component> components; // 0x18

			// Nested types
			[Serializable]
			public class Component // TypeDefIndex: 11612
			{
				// Fields
				public string componentClass; // 0x10
				public string componentJSON; // 0x18

				// Constructors
				public Component(); // 0x000000018036B6C0-0x000000018036B6D0
			}

			// Constructors
			public DataJSONObject(); // 0x0000000181150C70-0x0000000181150CD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 11613
		{
			// Fields
			public DefEntryComponent cComponent; // 0x10

			// Constructors
			public <>c__DisplayClass49_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal bool <get_CachedDiffText>b__1(DefEntryComponent x); // 0x0000000180FB2340-0x0000000180FB2380
		}

		// Constructors
		public DefEntry(Chart inParentChart, string inDefID, string inName); // 0x0000000181153EF0-0x0000000181154060
		public DefEntry(Chart inParentChart, DataJSONGAXResponseReplyDefRecord inRecordDef); // 0x0000000181154060-0x0000000181154210
		public DefEntry(Chart inParentChart, JsonData inRecordDef); // 0x0000000181153A80-0x0000000181153EF0

		// Methods
		public void Revert(); // 0x0000000181153590-0x0000000181153770
		private void AddDiffLine(string inLine, string inColorCode, bool inBold = false /* Metadata: 0x00782AD1 */); // 0x0000000181151AB0-0x0000000181151E80
		public void AddComponent(DefEntryComponent inComponent); // 0x0000000181151A40-0x0000000181151AB0
		public void RemoveComponent(DefEntryComponent inComponent); // 0x0000000181153520-0x0000000181153590
		public DefEntryComponent GetDefEntryComponent(string inComponentClass); // 0x0000000181151E80-0x0000000181152020
		public T GetComponent<T>()
			where T : DefComponent;
		public bool RebuildFromDataJSON(); // 0x0000000181152DF0-0x0000000181153520
		private void RebuildDataJSONAddLine(string inText, int inIndentation); // 0x00000001811528A0-0x0000000181152960
		public void RebuildDataJSON(); // 0x0000000181152960-0x0000000181152DF0
		public bool MapComponentsToTemplate(); // 0x0000000181152020-0x00000001811528A0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		internal static string <get_CachedDiffText>g__StrikeThrough|49_2(string s); // 0x00000001811539E0-0x0000000181153A80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <get_CachedDiffText>b__49_0(KeyValuePair<string, JsonData> inKVP); // 0x0000000181153770-0x00000001811539E0
	}

	[Serializable]
	private class ExportDefEntry // TypeDefIndex: 11614
	{
		// Fields
		[NonSerialized]
		public DefEntry defEntry; // 0x10
		public string defID; // 0x18
		public string defName; // 0x20
		public string dataJSON; // 0x28

		// Constructors
		public ExportDefEntry(DefEntry inDefEntry); // 0x0000000181157180-0x00000001811571D0
	}

	[Serializable]
	private class ExportChartEntry // TypeDefIndex: 11615
	{
		// Fields
		public string name; // 0x10
		public string label; // 0x18
		public List<ExportDefEntry> defs; // 0x20

		// Constructors
		public ExportChartEntry(Chart inChart); // 0x0000000181156F90-0x0000000181157180
	}

	[Serializable]
	private class ExportProject // TypeDefIndex: 11616
	{
		// Fields
		public int ID; // 0x10
		public string name; // 0x18
		public List<ExportChartEntry> charts; // 0x20

		// Constructors
		public ExportProject(Project inProject, Chart inChart); // 0x00000001811588A0-0x0000000181158980
		public ExportProject(Project inProject); // 0x00000001811586D0-0x00000001811588A0
		public ExportProject(string inJSON); // 0x0000000181158980-0x0000000181158A00

		// Methods
		public string ToJSON(bool inPretty = true /* Metadata: 0x00782AD2 */); // 0x0000000181158610-0x00000001811586D0
		public string ToCSV(); // 0x00000001811571D0-0x0000000181158610
	}

	public class HistoryEntry // TypeDefIndex: 11617
	{
		// Fields
		public string user; // 0x10
		public long dtStamp; // 0x18
		public string command; // 0x20
		public string dataJSON; // 0x28
		private string _prettyDate; // 0x30

		// Properties
		public string PrettyDate { get; } // 0x0000000181158A00-0x0000000181158B20 

		// Constructors
		public HistoryEntry(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public class Project // TypeDefIndex: 11618
	{
		// Fields
		public string name; // 0x10
		public string label; // 0x18
		public int projID; // 0x20
		public List<Chart> charts; // 0x28
		private Chart _lockChart; // 0x30
		private Chart _formatChart; // 0x38

		// Properties
		public List<Chart> Charts { get; } // 0x0000000180369B60-0x0000000180369B70 
		public Chart LockChart { get; } // 0x000000018115FA10-0x000000018115FA60 
		public Chart FormatChart { get; } // 0x000000018115F9C0-0x000000018115FA10 
		public bool IsDirty { get; } // 0x00000001803C28F0-0x00000001803C2900 

		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 11619
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<DefEntry> <>9__12_0; // 0x08
			public static Action<DefEntry> <>9__18_0; // 0x10

			// Constructors
			static <>c(); // 0x00000001813B0F50-0x00000001813B0FB0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <SetLockForID>b__12_0(DefEntry inDefEntry); // 0x00000001803581E0-0x00000001803581F0
			internal void <SetFormatForTemplateClass>b__18_0(DefEntry inDefEntry); // 0x00000001803581E0-0x00000001803581F0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CommitAllChartsRoutine>d__24 : IEnumerator<object> // TypeDefIndex: 11620
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Project <>4__this; // 0x20
			public string inComment; // 0x28
			public bool inPost; // 0x30
			private bool <foundDirty>5__2; // 0x31
			private List<Chart> <>7__wrap2; // 0x38

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CommitAllChartsRoutine>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001813A7DD0-0x00000001813A7E80
			private bool MoveNext(); // 0x00000001813A7AF0-0x00000001813A7D80
			private void <>m__Finally1(); // 0x00000001813A7E80-0x00000001813A7EC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A7D80-0x00000001813A7DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 11621
		{
			// Fields
			[TupleElementNames] // 0x00000001800E6560-0x00000001800E65E0
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass26_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <PostRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PostRoutine>d__26 : IEnumerator<object> // TypeDefIndex: 11622
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			private <>c__DisplayClass26_0 <>8__1; // 0x20

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PostRoutine>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AA160-0x00000001813AA350
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AA350-0x00000001813AA3A0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 11623
		{
			// Fields
			[TupleElementNames] // 0x00000001800E81B0-0x00000001800E8230
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass28_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <BuildManifestRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <BuildManifestRoutine>d__28 : IEnumerator<object> // TypeDefIndex: 11624
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			private <>c__DisplayClass28_0 <>8__1; // 0x20

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <BuildManifestRoutine>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A78B0-0x00000001813A7AA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A7AA0-0x00000001813A7AF0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 11625
		{
			// Fields
			[TupleElementNames] // 0x00000001800E90D0-0x00000001800E9150
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <RefreshHistoryRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RefreshHistoryRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 11626
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DefEntry inDef; // 0x20
			private <>c__DisplayClass29_0 <>8__1; // 0x28
			public Action inOnFinishedCallback; // 0x30

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RefreshHistoryRoutine>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813ABD50-0x00000001813AC410
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AC410-0x00000001813AC460
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 11627
		{
			// Fields
			public Dictionary<string, long> chartTimeStamps; // 0x10
			public Project <>4__this; // 0x18

			// Constructors
			public <>c__DisplayClass31_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <RefreshChartsRoutine>b__0(Dictionary<string, long> results); // 0x000000018036B1E0-0x000000018036B1F0
			internal void <RefreshChartsRoutine>g__ProcessChart|1(KeyValuePair<string, DataJSONGAXResponseReplyRecord> inChartKVP); // 0x00000001813B0B80-0x00000001813B0E90
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass31_1 // TypeDefIndex: 11628
		{
			// Fields
			[TupleElementNames] // 0x00000001800E9DB0-0x00000001800E9E30
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass31_1(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <RefreshChartsRoutine>b__2(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RefreshChartsRoutine>d__31 : IEnumerator<object> // TypeDefIndex: 11629
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Project <>4__this; // 0x20
			public List<Chart> inCharts; // 0x28
			private <>c__DisplayClass31_0 <>8__1; // 0x30
			private <>c__DisplayClass31_1 <>8__2; // 0x38
			public Action inOnFinishedCallback; // 0x40
			private Dictionary<string, DataJSONGAXResponseReplyRecord> <CachedChartGAXObjects>5__2; // 0x48

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RefreshChartsRoutine>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AAF50-0x00000001813ABD00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813ABD00-0x00000001813ABD50
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RebuildAllDataJSONsRoutine>d__32 : IEnumerator<object> // TypeDefIndex: 11630
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Project <>4__this; // 0x20
			private int <iBlock>5__2; // 0x28
			private List<Chart> <>7__wrap2; // 0x30
			private Chart <cChart>5__4; // 0x48
			private int <i>5__5; // 0x50

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RebuildAllDataJSONsRoutine>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001813AA680-0x00000001813AA730
			private bool MoveNext(); // 0x00000001813AA3A0-0x00000001813AA630
			private void <>m__Finally1(); // 0x00000001813AA730-0x00000001813AA770
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AA630-0x00000001813AA680
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 11631
		{
			// Fields
			[TupleElementNames] // 0x00000001800EBDB0-0x00000001800EBE30
			public ValueTuple<bool, DataJSONGAXResponse> response; // 0x10

			// Constructors
			public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			internal void <RefreshChartsRoutineFast>b__0(ValueTuple<bool, DataJSONGAXResponse> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
		}

		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RefreshChartsRoutineFast>d__33 : IEnumerator<object> // TypeDefIndex: 11632
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public List<Chart> inCharts; // 0x20
			public Project <>4__this; // 0x28
			private <>c__DisplayClass33_0 <>8__1; // 0x30
			public Action inOnFinishedCallback; // 0x38

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RefreshChartsRoutineFast>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AA770-0x00000001813AAF00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AAF00-0x00000001813AAF50
		}

		// Constructors
		public Project(); // 0x000000018115F960-0x000000018115F9C0

		// Methods
		public Chart GetChart(string inName); // 0x000000018115E420-0x000000018115E5D0
		public DefEntry GetDefEntry(string inID); // 0x000000018115E5D0-0x000000018115E770
		public ValueTuple<DefEntry, PropertyEditorLockedDefComponent> GetLockForID(string inID); // 0x000000018115EA00-0x000000018115EC90
		public void SetLockForID(string inUserName, string inDefID); // 0x000000018115F650-0x000000018115F960
		public void RemoveLockForID(string inDefID); // 0x000000018115F020-0x000000018115F150
		public ValueTuple<DefEntry, PropertyEditorFormatDefComponent> GetFormatForTemplateClass(string inTemplateClass); // 0x000000018115E770-0x000000018115EA00
		public void SetFormatForTemplateClass(string inTemplateClass); // 0x000000018115F280-0x000000018115F650
		public void RemoveFormatForTemplateClass(string inTemplateClass); // 0x000000018115EEF0-0x000000018115F020
		public void RevertAll(); // 0x000000018115F150-0x000000018115F280
		public void CommitAllCharts(string inComment, bool inPost); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E40D0-0x00000001800E4120
		public IEnumerator CommitAllChartsRoutine(string inComment, bool inPost); // 0x000000018115E300-0x000000018115E390
		public void Post(); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E4430-0x00000001800E4480
		public IEnumerator PostRoutine(); // 0x000000018115EC90-0x000000018115ECE0
		public void BuildManifest(); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E46A0-0x00000001800E46F0
		public IEnumerator BuildManifestRoutine(); // 0x000000018115E2B0-0x000000018115E300
		[IteratorStateMachine] // 0x00000001800E4A50-0x00000001800E4AA0
		public IEnumerator RefreshHistoryRoutine(DefEntry inDef, Action inOnFinishedCallback = null); // 0x000000018115EE70-0x000000018115EEF0
		public void RefreshAllCharts(Action inOnFinishedCallback = null); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E4D10-0x00000001800E4D60
		public IEnumerator RefreshChartsRoutine(List<Chart> inCharts = null, Action inOnFinishedCallback = null); // 0x000000018115EDE0-0x000000018115EE70
		[IteratorStateMachine] // 0x00000001800E5050-0x00000001800E50A0
		public IEnumerator RebuildAllDataJSONsRoutine(); // 0x000000018115ECE0-0x000000018115ED50
		[IteratorStateMachine] // 0x00000001800E5390-0x00000001800E53E0
		public IEnumerator RefreshChartsRoutineFast(List<Chart> inCharts = null, Action inOnFinishedCallback = null); // 0x000000018115ED50-0x000000018115EDE0
		public string ExportAsJSON(); // 0x000000018115E390-0x000000018115E420
	}

	public enum State // TypeDefIndex: 11633
	{
		Idle = 0,
		NotLoggedIn = 1,
		LoggingIn = 2,
		FailedLoggingIn = 3,
		Refreshing = 4,
		FailedRefreshing = 5,
		RefreshingHistory = 6,
		FailedRefreshingHistory = 7,
		Committing = 8,
		FailedCommitting = 9,
		Posting = 10,
		FailedPosting = 11
	}

	public abstract class ChartTemplateBase // TypeDefIndex: 11634
	{
		// Fields
		private static Dictionary<string, Func<ChartTemplateBase>> _templateConstructorDict; // 0x00
		private static Dictionary<Type, string> _builtTypeFormats; // 0x08
		private string _localFormatHash; // 0x10

		// Properties
		public string LocalFormatHash { get; } // 0x000000018114E7E0-0x000000018114E960 

		// Constructors
		protected ChartTemplateBase(); // 0x000000018036B6C0-0x000000018036B6D0
		static ChartTemplateBase(); // 0x000000018114E750-0x000000018114E7E0

		// Methods
		public static ChartTemplateBase ConstructTemplate(string inTypeName); // 0x000000018114E4B0-0x000000018114E720
		private StringBuilder BuildFormat(); // 0x000000018114E390-0x000000018114E4B0
		private void BuildFormatRecursively(FieldInfo inField, StringBuilder inStringBuilder, List<Type> inBuiltTypes); // 0x000000018114E0B0-0x000000018114E390
		public virtual void OnCreateGUI(); // 0x00000001803581E0-0x00000001803581F0
		public virtual List<ValueTuple<string, string>> GetSuggestions(); // 0x000000018035FCC0-0x000000018035FCD0
		public virtual void OnCreated(DefEntry inDefEntry); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnChangeTemplate(DefEntry inDefEntry); // 0x00000001803581E0-0x00000001803581F0
		public virtual string DefNamePrefix(DefEntry inDefEntry); // 0x000000018114E720-0x000000018114E750
	}

	public class ChartTemplate // TypeDefIndex: 11635
	{
		// Fields
		public ChartTemplateAttribute attribute; // 0x10
		public ChartTemplateBase templateInstance; // 0x18
		public Type templateType; // 0x20
		public Type defType; // 0x28
		public List<Type> defComponentTypes; // 0x30

		// Constructors
		public ChartTemplate(ChartTemplateAttribute inAttribute, Type inType); // 0x000000018114E960-0x000000018114F030
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DataServerRequest>d__21 : IEnumerator<object> // TypeDefIndex: 11636
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inCommand; // 0x20
		public JsonData inJsonData; // 0x28
		public Action<ValueTuple<bool, JsonData>> inResultCallback; // 0x30
		private UnityWebRequest <webRequest>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DataServerRequest>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811647D0-0x0000000181165010
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181165010-0x0000000181165060
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DataServerFastRequest>d__22<T> : IEnumerator<object> // TypeDefIndex: 11637
		where T : class, new()
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public string inCommand;
		public JsonData inJsonData;
		public Action<ValueTuple<bool, DataServerResponseBase<T>>> inResultCallback;
		private UnityWebRequest <webRequest>5__2;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DataServerFastRequest>d__22(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DataServerRequestDataJSONGetCharts>d__33 : IEnumerator<object> // TypeDefIndex: 11638
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public JsonData inJsonData; // 0x20
		public Action<ValueTuple<bool, DataJSONGAXResponse>> inResultCallback; // 0x28
		private UnityWebRequest <webRequest>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DataServerRequestDataJSONGetCharts>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181164230-0x0000000181164780
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181164780-0x00000001811647D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11639
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<ChartDefComponent> <>9__37_0; // 0x08
		public static Comparison<Chart> <>9__73_2; // 0x10
		public static Comparison<Project> <>9__73_1; // 0x18
		public static Comparison<ChartTemplate> <>9__98_0; // 0x20

		// Constructors
		static <>c(); // 0x0000000181166ED0-0x0000000181166F30
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <get_ChartDefComponents>b__37_0(ChartDefComponent a, ChartDefComponent b); // 0x0000000181166D60-0x0000000181166DC0
		internal int <RefreshProjectsRoutine>b__73_2(Chart a, Chart b); // 0x0000000181166D20-0x0000000181166D60
		internal int <RefreshProjectsRoutine>b__73_1(Project a, Project b); // 0x0000000180E721B0-0x0000000180E721F0
		internal int <get_ChartTemplates>b__98_0(ChartTemplate a, ChartTemplate b); // 0x0000000181166D60-0x0000000181166DC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass63_0 // TypeDefIndex: 11640
	{
		// Fields
		[TupleElementNames] // 0x00000001800EE0F0-0x00000001800EE170
		public ValueTuple<bool, JsonData> response; // 0x10

		// Constructors
		public <>c__DisplayClass63_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <PollRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PollRoutine>d__63 : IEnumerator<object> // TypeDefIndex: 11641
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public List<string> inChartNames; // 0x20
		private <>c__DisplayClass63_0 <>8__1; // 0x28
		public Action<Dictionary<string, long>> inModifiedChartsResult; // 0x30
		public Action inOnFinishedCallback; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PollRoutine>d__63(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181165870-0x0000000181165E40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181165E40-0x0000000181165E90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass73_0 // TypeDefIndex: 11642
	{
		// Fields
		[TupleElementNames] // 0x00000001800EEED0-0x00000001800EEF50
		public ValueTuple<bool, DataServerResponseBase<GTSResponseReply>> response; // 0x10

		// Constructors
		public <>c__DisplayClass73_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RefreshProjectsRoutine>b__0(ValueTuple<bool, DataServerResponseBase<GTSResponseReply>> inResponse); // 0x0000000181166DC0-0x0000000181166DD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshProjectsRoutine>d__73 : IEnumerator<object> // TypeDefIndex: 11643
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private <>c__DisplayClass73_0 <>8__1; // 0x20
		public Action inOnFinishedCallback; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshProjectsRoutine>d__73(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181166160-0x0000000181166950
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181166950-0x00000001811669A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshProjectsAndChartsRoutine>d__75 : IEnumerator<object> // TypeDefIndex: 11644
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action inOnFinishedCallback; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshProjectsAndChartsRoutine>d__75(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181165E90-0x0000000181166110
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181166110-0x0000000181166160
	}

	// Constructors
	public PropertyEditor(); // 0x000000018036B6C0-0x000000018036B6D0
	static PropertyEditor(); // 0x00000001811608D0-0x00000001811609F0

	// Methods
	[IteratorStateMachine] // 0x00000001800DEB40-0x00000001800DEB90
	public static IEnumerator DataServerRequest(string inCommand, JsonData inJsonData, Action<ValueTuple<bool, JsonData>> inResultCallback); // 0x000000018115FAD0-0x000000018115FB50
	[IteratorStateMachine] // 0x00000001800DEDF0-0x00000001800DEE40
	public static IEnumerator DataServerFastRequest<T>(string inCommand, JsonData inJsonData, Action<ValueTuple<bool, DataServerResponseBase<T>>> inResultCallback)
		where T : class, new();
	[IteratorStateMachine] // 0x00000001800DF110-0x00000001800DF160
	public static IEnumerator DataServerRequestDataJSONGetCharts(JsonData inJsonData, Action<ValueTuple<bool, DataJSONGAXResponse>> inResultCallback); // 0x000000018115FA60-0x000000018115FAD0
	public static ChartDefComponent GetChartDefComponent(string inName); // 0x000000018115FEE0-0x00000001811600E0
	[IteratorStateMachine] // 0x00000001800DF490-0x00000001800DF4E0
	public static IEnumerator PollRoutine(List<string> inChartNames, Action<Dictionary<string, long>> inModifiedChartsResult, Action inOnFinishedCallback = null); // 0x0000000181160710-0x0000000181160790
	public static Project GetProject(string inName); // 0x00000001811604C0-0x00000001811606A0
	public static void RefreshProjects(Action inOnFinishedCallback = null); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x00000001800DF790-0x00000001800DF7E0
	public static IEnumerator RefreshProjectsRoutine(Action inOnFinishedCallback = null); // 0x0000000181160870-0x00000001811608D0
	public static void RefreshProjectsAndCharts(Action inOnFinishedCallback = null); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x00000001800DFB60-0x00000001800DFBB0
	public static IEnumerator RefreshProjectsAndChartsRoutine(Action inOnFinishedCallback = null); // 0x0000000181160810-0x0000000181160870
	public static ChartTemplate GetChartTemplate(string inName); // 0x00000001811600E0-0x00000001811604C0
	public static void Log(string inLog); // 0x00000001803581E0-0x00000001803581F0
	public static void LogError(string inLog); // 0x00000001811606A0-0x0000000181160710
	public static List<Attribute> FastCustomAttributes(Type inType, MemberInfo inInfo); // 0x000000018115FB50-0x000000018115FD80
	public static string FastTypeName(Type inType); // 0x000000018115FD80-0x000000018115FEE0
	public static void QueueFocus(string inFocusName); // 0x0000000181160790-0x0000000181160810
}


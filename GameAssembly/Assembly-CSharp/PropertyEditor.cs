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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PropertyEditor // TypeDefIndex: 13112
{
	// Fields
	private static List<ChartDefComponent> _chartDefComponents; // 0x00
	[TupleElementNames] // 0x000000018027FC10-0x000000018027FC90
	private static Dictionary<string, ValueTuple<Type, MethodInfo>> _chartDefComponentSearchMethods; // 0x08
	private static string _propertyChartCacheFolderPath; // 0x10
	private static List<Project> _projects; // 0x18
	private static State _currentState; // 0x20
	private static DateTime _currentStateSetTime; // 0x28
	private static NoTemplate _cachedNoTemplate; // 0x30
	private static string _cachedNoTemplateHash; // 0x38
	private static MissingTemplate _cachedMissingTemplate; // 0x40
	private static string _cachedMissingTemplateHash; // 0x48
	private static List<ChartTemplate> _chartTemplates; // 0x50
	public static bool requestRepaint; // 0x58
	private static string _currentProjectName; // 0x60
	private static string _currentChartName; // 0x68
	private static Project _currentProject; // 0x70
	private static Chart _currentChart; // 0x78
	private static Dictionary<Type, Dictionary<string, List<Attribute>>> _cachedCustomAttributes; // 0x80
	private static Dictionary<Type, string> _cachedTypeName; // 0x88
	public static string focusNextOnGUIName; // 0x90
	public static int focusNextOnGUIDoubleTap; // 0x98

	// Properties
	public static string DataServerURL { get; } // 0x0000000180DA1420-0x0000000180DA1450 
	public static List<ChartDefComponent> ChartDefComponents { get; } // 0x0000000180DA05F0-0x0000000180DA0A00 
	[TupleElementNames] // 0x0000000180280A60-0x0000000180280AE0
	public static Dictionary<string, ValueTuple<Type, MethodInfo>> ChartDefComponentSearchMethods { get; } // 0x0000000180D9FEF0-0x0000000180DA05F0 
	public static bool ShowPreviews { get; set; } // 0x0000000180380950-0x0000000180380960 0x00000001803774A0-0x00000001803774B0
	public static bool AdvancedMode { get; set; } // 0x0000000180380950-0x0000000180380960 0x00000001803774A0-0x00000001803774B0
	public static bool FormatMode { get; set; } // 0x0000000180380950-0x0000000180380960 0x00000001803774A0-0x00000001803774B0
	public static string LoginUserName { get; set; } // 0x0000000180DA1480-0x0000000180DA14B0 0x00000001803774A0-0x00000001803774B0
	public static string LoginPassword { get; set; } // 0x0000000180DA1450-0x0000000180DA1480 0x00000001803774A0-0x00000001803774B0
	public static string PropertyChartCacheFolderPath { get; } // 0x0000000180DA1510-0x0000000180DA15D0 
	public static List<Project> Projects { get; } // 0x0000000180DA14B0-0x0000000180DA1510 
	public static State CurrentState { get; set; } // 0x0000000180DA1250-0x0000000180DA1420 0x0000000180DA1870-0x0000000180DA1940
	public static NoTemplate CachedNoTemplate { get; } // 0x0000000180D9FDD0-0x0000000180D9FEF0 
	public static string CachedNoTemplateHash { get; } // 0x0000000180D9FBF0-0x0000000180D9FDD0 
	public static MissingTemplate CachedMissingTemplate { get; } // 0x0000000180D9FAD0-0x0000000180D9FBF0 
	public static string CachedMissingTemplateHash { get; } // 0x0000000180D9F8F0-0x0000000180D9FAD0 
	public static List<ChartTemplate> ChartTemplates { get; } // 0x0000000180DA0A00-0x0000000180DA0E60 
	public static string CurrentProjectName { get; set; } // 0x0000000180DA1110-0x0000000180DA11D0 0x0000000180DA16F0-0x0000000180DA17B0
	public static string CurrentChartName { get; set; } // 0x0000000180DA0E60-0x0000000180DA0EF0 0x0000000180DA15D0-0x0000000180DA1630
	public static Project CurrentProject { get; set; } // 0x0000000180DA11D0-0x0000000180DA1250 0x0000000180DA17B0-0x0000000180DA1870
	public static Chart CurrentChart { get; set; } // 0x0000000180DA0EF0-0x0000000180DA1110 0x0000000180DA1630-0x0000000180DA16F0

	// Nested types
	public class Chart // TypeDefIndex: 13113
	{
		// Fields
		public Project parentProject; // 0x10
		public long dtStamp; // 0x18
		public string name; // 0x20
		public string label; // 0x28
		public bool commitable; // 0x30
		private List<DefEntry> _defEntries; // 0x38
		public Dictionary<string, DefEntry> defEntryDict; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsRefreshing>k__BackingField; // 0x48
		private bool _lastIsDirty; // 0x49
		private double _lastIsDirtyCheckFrame; // 0x50

		// Properties
		public List<DefEntry> defEntries { get; set; } // 0x0000000180D93FF0-0x0000000180D941B0 0x00000001803FEB60-0x00000001803FEB70
		public bool IsRefreshing { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
		public bool IsDirty { get; } // 0x00000001803C9D80-0x00000001803C9D90 
		public bool IsDirtyAndAllowCommit { get; } // 0x0000000180D93E50-0x0000000180D93FF0 

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 13114
		{
			// Fields
			[TupleElementNames] // 0x0000000180281990-0x0000000180281A10
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass25_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <CommitRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CommitRoutine>d__25 : IEnumerator<object> // TypeDefIndex: 13115
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CommitRoutine>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA1F70-0x0000000180DA2C50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA2C50-0x0000000180DA2CA0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass27_0 // TypeDefIndex: 13116
		{
			// Fields
			[TupleElementNames] // 0x00000001802826C0-0x0000000180282740
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass27_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <CreateNewRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
			internal void <CreateNewRoutine>b__1(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CreateNewRoutine>d__27 : IEnumerator<object> // TypeDefIndex: 13117
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CreateNewRoutine>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA2CA0-0x0000000180DA36C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA36C0-0x0000000180DA3710
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 13118
		{
			// Fields
			[TupleElementNames] // 0x0000000180283500-0x0000000180283580
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <DeleteRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DeleteRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 13119
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Chart <>4__this; // 0x20
			public List<DefEntry> inDelete; // 0x28
			private <>c__DisplayClass29_0 <>8__1; // 0x30

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DeleteRoutine>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA4500-0x0000000180DA4A80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA4A80-0x0000000180DA4AD0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 13120
		{
			// Fields
			public ExportDefEntry cImportDefEntry; // 0x10

			// Constructors
			public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal bool <ImportAsJSON>b__1(DefEntry inDefEntry); // 0x0000000180DA8420-0x0000000180DA8460
		}

		// Constructors
		public Chart(Project inParentProject); // 0x0000000180D93DA0-0x0000000180D93E50

		// Methods
		public DefEntry GetDefEntryWithDefName(string inName); // 0x0000000180D928F0-0x0000000180D92A80
		public DefEntry GetDefEntry(string inID); // 0x0000000180D92A80-0x0000000180D92AF0
		public void RevertAll(); // 0x0000000180D93C30-0x0000000180D93D70
		public void Commit(string inComment, bool inCommitFormatChanges, List<DefEntry> inOverrideEntries = null); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x00000001802810A0-0x00000001802810F0
		public IEnumerator CommitRoutine(string inComment, bool inCommitFormatChanges = false /* Metadata: 0x007BA1A4 */, List<DefEntry> inOverrideEntries = null); // 0x0000000180D925E0-0x0000000180D92670
		public void CreateNew(string inDefName, string inTemplateClass = null, string inDataJSON = null, Dictionary<string, JsonData> inColumnData = null, Action<DefEntry> inNewDefEntryCallback = null); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x0000000180281220-0x0000000180281270
		public IEnumerator CreateNewRoutine(string inDefName, string inTemplateClass = null, string inDataJSON = null, Dictionary<string, JsonData> inColumnData = null, Action<DefEntry> inNewDefEntryCallback = null); // 0x0000000180D92670-0x0000000180D92720
		public void Delete(List<DefEntry> inDelete); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x0000000180281520-0x0000000180281570
		public IEnumerator DeleteRoutine(List<DefEntry> inDelete); // 0x0000000180D92720-0x0000000180D92790
		public string ExportAsJSON(); // 0x0000000180D92830-0x0000000180D928F0
		public string ExportAsCSV(); // 0x0000000180D92790-0x0000000180D92830
		public void ImportAsJSON(string inJSON); // 0x0000000180D93270-0x0000000180D93560
		public void ImportAsCSV(string inCSV); // 0x0000000180D92AF0-0x0000000180D93270
		private ValueTuple<List<string>, List<string>> ParseCSVHeadersAndLines(string inCSV); // 0x0000000180D93560-0x0000000180D938F0
		private Dictionary<string, string> ParseCSVLine(List<string> inHeaders, string inCSV); // 0x0000000180D938F0-0x0000000180D93C30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <ImportAsJSON>b__32_0(ExportChartEntry inChart); // 0x0000000180D93D70-0x0000000180D93DA0
	}

	public static class DataServerCommands // TypeDefIndex: 13121
	{
		// Fields
		public const string GetProjects = "GTS"; // Metadata: 0x007BA1A5
		public const string GetCharts = "GAX"; // Metadata: 0x007BA1AC
		public const string GetNewID = "GID"; // Metadata: 0x007BA1B3
		public const string ChangeProps = "CCG"; // Metadata: 0x007BA1BA
		public const string PostToGame = "PTG"; // Metadata: 0x007BA1C1
		public const string History = "GLH"; // Metadata: 0x007BA1C8
		public const string Poll = "PLL"; // Metadata: 0x007BA1CF
		public const string BuildManifest = "BMF"; // Metadata: 0x007BA1D6
	}

	[Serializable]
	public class DataJSONGAXResponse // TypeDefIndex: 13122
	{
		// Fields
		public string cmd; // 0x10
		public DataJSONGAXResponseReply reply; // 0x18

		// Constructors
		public DataJSONGAXResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class DataJSONGAXResponseReply // TypeDefIndex: 13123
	{
		// Fields
		public int projId; // 0x10
		public List<DataJSONGAXResponseReplyRecord> records; // 0x18

		// Constructors
		public DataJSONGAXResponseReply(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class DataJSONGAXResponseReplyRecord // TypeDefIndex: 13124
	{
		// Fields
		public string defName; // 0x10
		public List<DataJSONGAXResponseReplyDefRecord> defRecords; // 0x18

		// Constructors
		public DataJSONGAXResponseReplyRecord(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class DataJSONGAXResponseReplyDefRecord // TypeDefIndex: 13125
	{
		// Fields
		public uint _id; // 0x10
		public string DefName; // 0x18
		public string DataJSON; // 0x20

		// Constructors
		public DataJSONGAXResponseReplyDefRecord(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class DataServerResponseReplyStatus // TypeDefIndex: 13126
	{
		// Fields
		public bool status; // 0x10
		public List<DataServerResponseReplyStatusReason> reason; // 0x18

		// Constructors
		public DataServerResponseReplyStatus(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class DataServerResponseReplyStatusReason // TypeDefIndex: 13127
	{
		// Fields
		public string message; // 0x10

		// Constructors
		public DataServerResponseReplyStatusReason(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class DataServerResponseBase<T> // TypeDefIndex: 13128
	{
		// Fields
		public T reply;

		// Constructors
		public DataServerResponseBase();
	}

	[Serializable]
	public class GTSResponseReply // TypeDefIndex: 13129
	{
		// Fields
		public List<GTSResponseReplyProject> projects; // 0x10

		// Constructors
		public GTSResponseReply(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class GTSResponseReplyProject // TypeDefIndex: 13130
	{
		// Fields
		public int id; // 0x10
		public string name; // 0x18
		public string label; // 0x20
		public List<GTSResponseReplyProjectDef> defs; // 0x28

		// Constructors
		public GTSResponseReplyProject(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class GTSResponseReplyProjectDef // TypeDefIndex: 13131
	{
		// Fields
		public string name; // 0x10
		public string label; // 0x18

		// Constructors
		public GTSResponseReplyProjectDef(); // 0x0000000180373240-0x0000000180373250
	}

	public class ChartDefComponent // TypeDefIndex: 13132
	{
		// Fields
		public ChartComponentAttribute attribute; // 0x10
		public Type type; // 0x18

		// Constructors
		public ChartDefComponent(ChartComponentAttribute inAttribute, Type inType); // 0x0000000180372010-0x00000001803720F0
	}

	public class DefEntryComponent // TypeDefIndex: 13133
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
		public string ComponentClass { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180D95A60-0x0000000180D95AA0
		public bool ComponentIsCustom { get; set; } // 0x00000001803FA090-0x00000001803FA0A0 0x0000000180D95AA0-0x0000000180D95AB0
		public string ComponentJSON { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x0000000180D95AB0-0x0000000180D95B10
		public string OriginalComponentJSON { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x0000000180D95B10-0x0000000180D95B70
		public string CachedDiffText { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
		public DefComponent DefComponentInstance { get; } // 0x0000000180D95730-0x0000000180D95A60 

		// Constructors
		public DefEntryComponent(DefEntry inParentDefEntry); // 0x0000000180D95670-0x0000000180D956A0
		public DefEntryComponent(DefEntry inParentDefEntry, string inComponentClass); // 0x0000000180D956A0-0x0000000180D956E0
		public DefEntryComponent(DefEntry inParentDefEntry, string inComponentClass, string inComponentJSON); // 0x0000000180D956E0-0x0000000180D95730

		// Methods
		public void AddDiffLine(string inLine, string inColorCode, bool inBold = false /* Metadata: 0x007BA1DD */); // 0x0000000180D94E70-0x0000000180D95370
		public void InternalRepair(); // 0x0000000180D95380-0x0000000180D95630
		public void ClearDefComponentInstance(); // 0x0000000180D95370-0x0000000180D95380
		public void RebuildComponentJSON(); // 0x0000000180D95630-0x0000000180D95670
	}

	public class DefEntry // TypeDefIndex: 13134
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public bool AllowCommit { get; set; } // 0x0000000180D98280-0x0000000180D982B0 0x00000001804F2EA0-0x00000001804F2EB0
		public bool ValidForCommit { get; } // 0x0000000180D9ABB0-0x0000000180D9B010 
		public bool MarkForDelete { get; set; } // 0x00000001804D2E30-0x00000001804D2E40 0x0000000180D9B220-0x0000000180D9B240
		public bool FormatIsDifferentFromServer { get; } // 0x0000000180380950-0x0000000180380960 
		public bool FormatIsDifferentFromCode { get; } // 0x0000000180D9A1C0-0x0000000180D9A210 
		public bool IsWrongFormat { get; } // 0x0000000180D9A370-0x0000000180D9A4C0 
		public bool IsDirty { get; set; } // 0x00000001804D2E20-0x00000001804D2E30 0x0000000180D9B130-0x0000000180D9B220
		public string DefName { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x0000000180D9B050-0x0000000180D9B130
		public string FullDefName { get; } // 0x0000000180D9A310-0x0000000180D9A370 
		public string TemplateCategoryName { get; } // 0x0000000180D9A7B0-0x0000000180D9A820 
		public string FullCategoryName { get; } // 0x0000000180D9A210-0x0000000180D9A310 
		public bool HasHistory { get; } // 0x0000000180681250-0x0000000180681260 
		public List<HistoryEntry> HistoryEntries { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public string CachedDiffText { get; } // 0x0000000180D982B0-0x0000000180D9A020 
		public string SearchLabel { get; } // 0x0000000180D9A4C0-0x0000000180D9A720 
		public string OriginalDefName { get; set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public string OriginalDataJSON { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		public string OriginalTemplateFormatHash { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		public Dictionary<string, JsonData> OriginalColumnData { get; set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
		public Dictionary<string, JsonData> ColumnData { get; set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
		public bool ColumnDataDirty { get; } // 0x0000000180380950-0x0000000180380960 
		public bool DataJSONEditMode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804A0200-0x00000001804A0210 0x0000000180434D60-0x0000000180434D70
		public string DataJSON { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x0000000180D9B010-0x0000000180D9B050
		public string TemplateClass { get; set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460
		public ChartTemplate Template { get; set; } // 0x0000000180D9AB00-0x0000000180D9ABB0 0x0000000180D9B240-0x0000000180D9B390
		public string TemplateFormatHash { get; set; } // 0x00000001803CFB60-0x00000001803CFB70 0x000000018049F9C0-0x000000018049F9D0
		public List<DefEntryComponent> Components { get; } // 0x0000000180529360-0x0000000180529370 
		public List<DefEntryComponent> TemplateComponents { get; } // 0x0000000180D9A820-0x0000000180D9AB00 
		public List<DefEntryComponent> CustomComponents { get; } // 0x0000000180D9A020-0x0000000180D9A1C0 
		private static ObjectPool<StringBuilder> StringBuilderPool { get; } // 0x0000000180D9A720-0x0000000180D9A7B0 

		// Nested types
		[Serializable]
		public class DataJSONObject // TypeDefIndex: 13135
		{
			// Fields
			public string templateClass; // 0x10
			public List<Component> components; // 0x18

			// Nested types
			[Serializable]
			public class Component // TypeDefIndex: 13136
			{
				// Fields
				public string componentClass; // 0x10
				public string componentJSON; // 0x18

				// Constructors
				public Component(); // 0x0000000180373240-0x0000000180373250
			}

			// Constructors
			public DataJSONObject(); // 0x0000000180D94E10-0x0000000180D94E70
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 13137
		{
			// Fields
			public DefEntryComponent cComponent; // 0x10

			// Constructors
			public <>c__DisplayClass49_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal bool <get_CachedDiffText>b__1(DefEntryComponent x); // 0x0000000180517340-0x0000000180517380
		}

		// Constructors
		public DefEntry(Chart inParentChart, string inDefID, string inName); // 0x0000000180D97F60-0x0000000180D980D0
		public DefEntry(Chart inParentChart, DataJSONGAXResponseReplyDefRecord inRecordDef); // 0x0000000180D980D0-0x0000000180D98280
		public DefEntry(Chart inParentChart, JsonData inRecordDef); // 0x0000000180D97B00-0x0000000180D97F60

		// Methods
		public void Revert(); // 0x0000000180D97620-0x0000000180D977F0
		private void AddDiffLine(string inLine, string inColorCode, bool inBold = false /* Metadata: 0x007BA1DE */); // 0x0000000180D95BE0-0x0000000180D95F70
		public void AddComponent(DefEntryComponent inComponent); // 0x0000000180D95B70-0x0000000180D95BE0
		public void RemoveComponent(DefEntryComponent inComponent); // 0x0000000180D975B0-0x0000000180D97620
		public DefEntryComponent GetDefEntryComponent(string inComponentClass); // 0x0000000180D95F70-0x0000000180D96110
		public T GetComponent<T>()
			where T : DefComponent;
		public bool RebuildFromDataJSON(); // 0x0000000180D96EA0-0x0000000180D975B0
		private void RebuildDataJSONAddLine(string inText, int inIndentation); // 0x0000000180D96960-0x0000000180D96A20
		public void RebuildDataJSON(); // 0x0000000180D96A20-0x0000000180D96EA0
		public bool MapComponentsToTemplate(); // 0x0000000180D96110-0x0000000180D96960
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal static string <get_CachedDiffText>g__StrikeThrough|49_2(string s); // 0x0000000180D97A60-0x0000000180D97B00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <get_CachedDiffText>b__49_0(KeyValuePair<string, JsonData> inKVP); // 0x0000000180D977F0-0x0000000180D97A60
	}

	[Serializable]
	private class ExportDefEntry // TypeDefIndex: 13138
	{
		// Fields
		[NonSerialized]
		public DefEntry defEntry; // 0x10
		public string defID; // 0x18
		public string defName; // 0x20
		public string dataJSON; // 0x28

		// Constructors
		public ExportDefEntry(DefEntry inDefEntry); // 0x0000000180D9B580-0x0000000180D9B5D0
	}

	[Serializable]
	private class ExportChartEntry // TypeDefIndex: 13139
	{
		// Fields
		public string name; // 0x10
		public string label; // 0x18
		public List<ExportDefEntry> defs; // 0x20

		// Constructors
		public ExportChartEntry(Chart inChart); // 0x0000000180D9B390-0x0000000180D9B580
	}

	[Serializable]
	private class ExportProject // TypeDefIndex: 13140
	{
		// Fields
		public int ID; // 0x10
		public string name; // 0x18
		public List<ExportChartEntry> charts; // 0x20

		// Constructors
		public ExportProject(Project inProject, Chart inChart); // 0x0000000180D9CC30-0x0000000180D9CD00
		public ExportProject(Project inProject); // 0x0000000180D9CA60-0x0000000180D9CC30
		public ExportProject(string inJSON); // 0x0000000180D9CD00-0x0000000180D9CD80

		// Methods
		public string ToJSON(bool inPretty = true /* Metadata: 0x007BA1DF */); // 0x0000000180D9C9A0-0x0000000180D9CA60
		public string ToCSV(); // 0x0000000180D9B5D0-0x0000000180D9C9A0
	}

	[Serializable]
	public class HistoryEntryData // TypeDefIndex: 13141
	{
		// Fields
		public long _id; // 0x10
		public string DefName; // 0x18
		public string DataJSON; // 0x20
		public long modified; // 0x28

		// Constructors
		public HistoryEntryData(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class HistoryEntry // TypeDefIndex: 13142
	{
		// Fields
		public string user; // 0x10
		public long dtStamp; // 0x18
		public string command; // 0x20
		public string comment; // 0x28
		public HistoryEntryData data; // 0x30
		public HistoryEntryData original; // 0x38
		public HistoryEntryData newData; // 0x40
		private string _prettyDate; // 0x48

		// Properties
		public string PrettyDate { get; } // 0x0000000180D9CD80-0x0000000180D9CEA0 

		// Constructors
		public HistoryEntry(); // 0x0000000180373240-0x0000000180373250
	}

	public class Project // TypeDefIndex: 13143
	{
		// Fields
		public string name; // 0x10
		public string label; // 0x18
		public int projID; // 0x20
		public List<Chart> charts; // 0x28
		private Chart _lockChart; // 0x30
		private Chart _formatChart; // 0x38

		// Properties
		public List<Chart> Charts { get; } // 0x00000001803745B0-0x00000001803745C0 
		public Chart LockChart { get; } // 0x0000000180D9E6C0-0x0000000180D9E710 
		public Chart FormatChart { get; } // 0x0000000180D9E670-0x0000000180D9E6C0 
		public bool IsDirty { get; } // 0x0000000180380950-0x0000000180380960 

		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 13144
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<DefEntry> <>9__12_0; // 0x08
			public static Action<DefEntry> <>9__18_0; // 0x10

			// Constructors
			static <>c(); // 0x0000000180DA8460-0x0000000180DA84C0
			public <>c(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <SetLockForID>b__12_0(DefEntry inDefEntry); // 0x00000001803774A0-0x00000001803774B0
			internal void <SetFormatForTemplateClass>b__18_0(DefEntry inDefEntry); // 0x00000001803774A0-0x00000001803774B0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CommitAllChartsRoutine>d__24 : IEnumerator<object> // TypeDefIndex: 13145
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CommitAllChartsRoutine>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180DA1E90-0x0000000180DA1F30
			private bool MoveNext(); // 0x0000000180DA1B80-0x0000000180DA1E40
			private void <>m__Finally1(); // 0x0000000180DA1F30-0x0000000180DA1F70
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA1E40-0x0000000180DA1E90
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 13146
		{
			// Fields
			[TupleElementNames] // 0x0000000180288700-0x0000000180288780
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass26_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <PostRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PostRoutine>d__26 : IEnumerator<object> // TypeDefIndex: 13147
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			private <>c__DisplayClass26_0 <>8__1; // 0x20

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PostRoutine>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA5350-0x0000000180DA5540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA5540-0x0000000180DA5590
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 13148
		{
			// Fields
			[TupleElementNames] // 0x00000001802892C0-0x0000000180289340
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass28_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <BuildManifestRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <BuildManifestRoutine>d__28 : IEnumerator<object> // TypeDefIndex: 13149
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			private <>c__DisplayClass28_0 <>8__1; // 0x20

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <BuildManifestRoutine>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA1940-0x0000000180DA1B30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA1B30-0x0000000180DA1B80
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 13150
		{
			// Fields
			[TupleElementNames] // 0x000000018028A000-0x000000018028A080
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <RefreshHistoryRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RefreshHistoryRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 13151
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Chart inChart; // 0x20
			public DefEntry inDef; // 0x28
			private <>c__DisplayClass29_0 <>8__1; // 0x30
			public Action<List<HistoryEntry>> inOnFinishedCallback; // 0x38

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RefreshHistoryRoutine>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA6EB0-0x0000000180DA7540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA7540-0x0000000180DA7590
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 13152
		{
			// Fields
			public Dictionary<string, long> chartTimeStamps; // 0x10
			public Project <>4__this; // 0x18

			// Constructors
			public <>c__DisplayClass31_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <RefreshChartsRoutine>b__0(Dictionary<string, long> results); // 0x0000000180379F20-0x0000000180379F30
			internal void <RefreshChartsRoutine>g__ProcessChart|1(KeyValuePair<string, DataJSONGAXResponseReplyRecord> inChartKVP); // 0x0000000180DA8120-0x0000000180DA8420
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass31_1 // TypeDefIndex: 13153
		{
			// Fields
			[TupleElementNames] // 0x000000018028AE90-0x000000018028AF10
			public ValueTuple<bool, JsonData> response; // 0x10

			// Constructors
			public <>c__DisplayClass31_1(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <RefreshChartsRoutine>b__2(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RefreshChartsRoutine>d__31 : IEnumerator<object> // TypeDefIndex: 13154
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RefreshChartsRoutine>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA60E0-0x0000000180DA6E60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA6E60-0x0000000180DA6EB0
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RebuildAllDataJSONsRoutine>d__32 : IEnumerator<object> // TypeDefIndex: 13155
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RebuildAllDataJSONsRoutine>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180DA5850-0x0000000180DA58F0
			private bool MoveNext(); // 0x0000000180DA5590-0x0000000180DA5800
			private void <>m__Finally1(); // 0x0000000180DA58F0-0x0000000180DA5930
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA5800-0x0000000180DA5850
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 13156
		{
			// Fields
			[TupleElementNames] // 0x000000018028D150-0x000000018028D1D0
			public ValueTuple<bool, DataJSONGAXResponse> response; // 0x10

			// Constructors
			public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

			// Methods
			internal void <RefreshChartsRoutineFast>b__0(ValueTuple<bool, DataJSONGAXResponse> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
		}

		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RefreshChartsRoutineFast>d__33 : IEnumerator<object> // TypeDefIndex: 13157
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public List<Chart> inCharts; // 0x20
			public Project <>4__this; // 0x28
			private <>c__DisplayClass33_0 <>8__1; // 0x30
			public Action inOnFinishedCallback; // 0x38

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RefreshChartsRoutineFast>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180DA5930-0x0000000180DA6090
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180DA6090-0x0000000180DA60E0
		}

		// Constructors
		public Project(); // 0x0000000180D9E610-0x0000000180D9E670

		// Methods
		public Chart GetChart(string inName); // 0x0000000180D9D140-0x0000000180D9D2F0
		public DefEntry GetDefEntry(string inID); // 0x0000000180D9D2F0-0x0000000180D9D490
		public ValueTuple<DefEntry, PropertyEditorLockedDefComponent> GetLockForID(string inID); // 0x0000000180D9D720-0x0000000180D9D9B0
		public void SetLockForID(string inUserName, string inDefID); // 0x0000000180D9E300-0x0000000180D9E610
		public void RemoveLockForID(string inDefID); // 0x0000000180D9DD00-0x0000000180D9DE20
		public ValueTuple<DefEntry, PropertyEditorFormatDefComponent> GetFormatForTemplateClass(string inTemplateClass); // 0x0000000180D9D490-0x0000000180D9D720
		public void SetFormatForTemplateClass(string inTemplateClass); // 0x0000000180D9DF40-0x0000000180D9E300
		public void RemoveFormatForTemplateClass(string inTemplateClass); // 0x0000000180D9DBE0-0x0000000180D9DD00
		public void RevertAll(); // 0x0000000180D9DE20-0x0000000180D9DF40
		public void CommitAllCharts(string inComment, bool inPost); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x0000000180284650-0x00000001802846A0
		public IEnumerator CommitAllChartsRoutine(string inComment, bool inPost); // 0x0000000180D9D030-0x0000000180D9D0B0
		public void Post(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x00000001802848E0-0x0000000180284930
		public IEnumerator PostRoutine(); // 0x0000000180D9D9B0-0x0000000180D9DA00
		public void BuildManifest(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x0000000180284AF0-0x0000000180284B40
		public IEnumerator BuildManifestRoutine(); // 0x0000000180D9CFE0-0x0000000180D9D030
		[IteratorStateMachine] // 0x0000000180286090-0x00000001802860E0
		public IEnumerator RefreshHistoryRoutine(Chart inChart, DefEntry inDef, Action<List<HistoryEntry>> inOnFinishedCallback = null); // 0x0000000180D9DB60-0x0000000180D9DBE0
		public void RefreshAllCharts(Action inOnFinishedCallback = null); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x0000000180286250-0x00000001802862A0
		public IEnumerator RefreshChartsRoutine(List<Chart> inCharts = null, Action inOnFinishedCallback = null); // 0x0000000180D9DAE0-0x0000000180D9DB60
		[IteratorStateMachine] // 0x00000001802864A0-0x00000001802864F0
		public IEnumerator RebuildAllDataJSONsRoutine(); // 0x0000000180D9DA00-0x0000000180D9DA60
		[IteratorStateMachine] // 0x0000000180286740-0x0000000180286790
		public IEnumerator RefreshChartsRoutineFast(List<Chart> inCharts = null, Action inOnFinishedCallback = null); // 0x0000000180D9DA60-0x0000000180D9DAE0
		public string ExportAsJSON(); // 0x0000000180D9D0B0-0x0000000180D9D140
	}

	public enum State // TypeDefIndex: 13158
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

	public abstract class ChartTemplateBase // TypeDefIndex: 13159
	{
		// Fields
		private static Dictionary<string, Func<ChartTemplateBase>> _templateConstructorDict; // 0x00
		private static Dictionary<Type, string> _builtTypeFormats; // 0x08
		private string _localFormatHash; // 0x10

		// Properties
		public string LocalFormatHash { get; } // 0x0000000180D91DD0-0x0000000180D91F50 

		// Constructors
		protected ChartTemplateBase(); // 0x0000000180373240-0x0000000180373250
		static ChartTemplateBase(); // 0x0000000180D91D40-0x0000000180D91DD0

		// Methods
		public static ChartTemplateBase ConstructTemplate(string inTypeName); // 0x0000000180D91AA0-0x0000000180D91D10
		private StringBuilder BuildFormat(); // 0x0000000180D91980-0x0000000180D91AA0
		private void BuildFormatRecursively(FieldInfo inField, StringBuilder inStringBuilder, List<Type> inBuiltTypes); // 0x0000000180D916B0-0x0000000180D91980
		public virtual void OnCreateGUI(); // 0x00000001803774A0-0x00000001803774B0
		public virtual List<ValueTuple<string, string>> GetSuggestions(); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual void OnCreated(DefEntry inDefEntry); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnChangeTemplate(DefEntry inDefEntry); // 0x00000001803774A0-0x00000001803774B0
		public virtual string DefNamePrefix(DefEntry inDefEntry); // 0x0000000180D91D10-0x0000000180D91D40
	}

	public class ChartTemplate // TypeDefIndex: 13160
	{
		// Fields
		public ChartTemplateAttribute attribute; // 0x10
		public ChartTemplateBase templateInstance; // 0x18
		public Type templateType; // 0x20
		public Type defType; // 0x28
		public List<Type> defComponentTypes; // 0x30

		// Constructors
		public ChartTemplate(ChartTemplateAttribute inAttribute, Type inType); // 0x0000000180D91F50-0x0000000180D925E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DataServerRequest>d__4 : IEnumerator<object> // TypeDefIndex: 13161
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inCommand; // 0x20
		public JsonData inJsonData; // 0x28
		public Action<ValueTuple<bool, JsonData>> inResultCallback; // 0x30
		private UnityWebRequest <webRequest>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DataServerRequest>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180DA3C90-0x0000000180DA44B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180DA44B0-0x0000000180DA4500
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DataServerFastRequest>d__5<T> : IEnumerator<object> // TypeDefIndex: 13162
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DataServerFastRequest>d__5(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DataServerRequestDataJSONGetCharts>d__16 : IEnumerator<object> // TypeDefIndex: 13163
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public JsonData inJsonData; // 0x20
		public Action<ValueTuple<bool, DataJSONGAXResponse>> inResultCallback; // 0x28
		private UnityWebRequest <webRequest>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DataServerRequestDataJSONGetCharts>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180DA3710-0x0000000180DA3C40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180DA3C40-0x0000000180DA3C90
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13164
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<ChartDefComponent> <>9__20_0; // 0x08
		public static Comparison<Chart> <>9__57_2; // 0x10
		public static Comparison<Project> <>9__57_1; // 0x18
		public static Comparison<ChartTemplate> <>9__82_0; // 0x20

		// Constructors
		static <>c(); // 0x0000000180DA84C0-0x0000000180DA8520
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <get_ChartDefComponents>b__20_0(ChartDefComponent a, ChartDefComponent b); // 0x0000000180DA80B0-0x0000000180DA8110
		internal int <RefreshProjectsRoutine>b__57_2(Chart a, Chart b); // 0x0000000180DA8070-0x0000000180DA80B0
		internal int <RefreshProjectsRoutine>b__57_1(Project a, Project b); // 0x00000001803C6400-0x00000001803C6440
		internal int <get_ChartTemplates>b__82_0(ChartTemplate a, ChartTemplate b); // 0x0000000180DA80B0-0x0000000180DA8110
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 13165
	{
		// Fields
		[TupleElementNames] // 0x000000018028F410-0x000000018028F490
		public ValueTuple<bool, JsonData> response; // 0x10

		// Constructors
		public <>c__DisplayClass47_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <PollRoutine>b__0(ValueTuple<bool, JsonData> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PollRoutine>d__47 : IEnumerator<object> // TypeDefIndex: 13166
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public List<string> inChartNames; // 0x20
		private <>c__DisplayClass47_0 <>8__1; // 0x28
		public Action<Dictionary<string, long>> inModifiedChartsResult; // 0x30
		public Action inOnFinishedCallback; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PollRoutine>d__47(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180DA4D40-0x0000000180DA5300
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180DA5300-0x0000000180DA5350
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass57_0 // TypeDefIndex: 13167
	{
		// Fields
		[TupleElementNames] // 0x0000000180290070-0x00000001802900F0
		public ValueTuple<bool, DataServerResponseBase<GTSResponseReply>> response; // 0x10

		// Constructors
		public <>c__DisplayClass57_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RefreshProjectsRoutine>b__0(ValueTuple<bool, DataServerResponseBase<GTSResponseReply>> inResponse); // 0x0000000180DA8110-0x0000000180DA8120
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshProjectsRoutine>d__57 : IEnumerator<object> // TypeDefIndex: 13168
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		private <>c__DisplayClass57_0 <>8__1; // 0x20
		public Action inOnFinishedCallback; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshProjectsRoutine>d__57(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180DA7850-0x0000000180DA8020
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180DA8020-0x0000000180DA8070
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshProjectsAndChartsRoutine>d__59 : IEnumerator<object> // TypeDefIndex: 13169
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action inOnFinishedCallback; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshProjectsAndChartsRoutine>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180DA7590-0x0000000180DA7800
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180DA7800-0x0000000180DA7850
	}

	// Constructors
	public PropertyEditor(); // 0x0000000180373240-0x0000000180373250
	static PropertyEditor(); // 0x0000000180D9F7D0-0x0000000180D9F8F0

	// Methods
	[IteratorStateMachine] // 0x000000018027FEB0-0x000000018027FF00
	public static IEnumerator DataServerRequest(string inCommand, JsonData inJsonData, Action<ValueTuple<bool, JsonData>> inResultCallback); // 0x0000000180D9E9F0-0x0000000180D9EA70
	[IteratorStateMachine] // 0x0000000180280090-0x00000001802800E0
	public static IEnumerator DataServerFastRequest<T>(string inCommand, JsonData inJsonData, Action<ValueTuple<bool, DataServerResponseBase<T>>> inResultCallback)
		where T : class, new();
	[IteratorStateMachine] // 0x00000001802801F0-0x0000000180280240
	public static IEnumerator DataServerRequestDataJSONGetCharts(JsonData inJsonData, Action<ValueTuple<bool, DataJSONGAXResponse>> inResultCallback); // 0x0000000180D9E980-0x0000000180D9E9F0
	public static ChartDefComponent GetChartDefComponent(string inName); // 0x0000000180D9EE00-0x0000000180D9EFF0
	[IteratorStateMachine] // 0x0000000180280480-0x00000001802804D0
	public static IEnumerator PollRoutine(List<string> inChartNames, Action<Dictionary<string, long>> inModifiedChartsResult, Action inOnFinishedCallback = null); // 0x0000000180D9F610-0x0000000180D9F690
	public static Project GetProject(string inName); // 0x0000000180D9F3C0-0x0000000180D9F5A0
	public static void RefreshProjects(Action inOnFinishedCallback = null); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x0000000180280670-0x00000001802806C0
	public static IEnumerator RefreshProjectsRoutine(Action inOnFinishedCallback = null); // 0x0000000180D9F770-0x0000000180D9F7D0
	public static void RefreshProjectsAndCharts(Action inOnFinishedCallback = null); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x0000000180280830-0x0000000180280880
	public static IEnumerator RefreshProjectsAndChartsRoutine(Action inOnFinishedCallback = null); // 0x0000000180D9F710-0x0000000180D9F770
	public static ChartTemplate GetChartTemplate(string inName); // 0x0000000180D9EFF0-0x0000000180D9F3C0
	public static void Log(string inLog); // 0x00000001803774A0-0x00000001803774B0
	public static void LogError(string inLog); // 0x0000000180D9F5A0-0x0000000180D9F610
	public static List<Attribute> FastCustomAttributes(Type inType, MemberInfo inInfo); // 0x0000000180D9EA70-0x0000000180D9ECA0
	public static string FastTypeName(Type inType); // 0x0000000180D9ECA0-0x0000000180D9EE00
	public static void QueueFocus(string inFocusName); // 0x0000000180D9F690-0x0000000180D9F710
}


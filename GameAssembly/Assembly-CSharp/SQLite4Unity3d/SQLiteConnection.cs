/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class SQLiteConnection : IDisposable // TypeDefIndex: 15438
	{
		// Fields
		private bool _open; // 0x10
		private TimeSpan _busyTimeout; // 0x18
		private Dictionary<string, TableMapping> _mappings; // 0x20
		private Dictionary<string, TableMapping> _tables; // 0x28
		private Stopwatch _sw; // 0x30
		private TimeSpan _elapsed; // 0x38
		private int _transactionDepth; // 0x40
		private Random _rand; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IntPtr <Handle>k__BackingField; // 0x50
		internal static readonly IntPtr NullHandle; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <DatabasePath>k__BackingField; // 0x58
		private static Dictionary<string, object> syncObjects; // 0x08
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Trace>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <TimeExecution>k__BackingField; // 0x61
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TraceHandler TraceEvent; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TimeExecutionHandler TimeExecutionEvent; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <StoreDateTimeAsTicks>k__BackingField; // 0x78
		private static bool _preserveDuringLinkMagic; // 0x10
	
		// Properties
		public IntPtr Handle { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public string DatabasePath { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public bool Trace { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804785B0-0x00000001804785C0 0x000000018062BA40-0x000000018062BA50
		public bool TimeExecution { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180478640-0x0000000180478650 0x000000018042EE00-0x000000018042EE10
		public bool StoreDateTimeAsTicks { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000180933270-0x0000000180933280
		public object SyncObject { get; } // 0x0000000180E1C080-0x0000000180E1C100 
		public TimeSpan BusyTimeout { get; set; } // 0x000000018038B150-0x000000018038B160 0x0000000180E1C430-0x0000000180E1C570
		public IEnumerable<TableMapping> TableMappings { get; } // 0x0000000180E1C100-0x0000000180E1C1E0 
		public bool IsInTransaction { get; } // 0x0000000180E1C070-0x0000000180E1C080 
	
		// Events
		public event TraceHandler TraceEvent {
			add; // 0x0000000180E1BFD0-0x0000000180E1C070
			remove; // 0x0000000180E1C390-0x0000000180E1C430
		}
		public event TimeExecutionHandler TimeExecutionEvent {
			add; // 0x0000000180E1BF30-0x0000000180E1BFD0
			remove; // 0x0000000180E1C2F0-0x0000000180E1C390
		}
	
		// Nested types
		public delegate void TraceHandler(string message); // TypeDefIndex: 15439; 0x000000018082AC80-0x000000018082B070
	
		public delegate void TimeExecutionHandler(TimeSpan executionTime, TimeSpan totalExecutionTime); // TypeDefIndex: 15440; 0x0000000180E3AFB0-0x0000000180E3B280
	
		private struct IndexedColumn // TypeDefIndex: 15441
		{
			// Fields
			public int Order; // 0x00
			public string ColumnName; // 0x08
		}
	
		private struct IndexInfo // TypeDefIndex: 15442
		{
			// Fields
			public string IndexName; // 0x00
			public string TableName; // 0x08
			public bool Unique; // 0x10
			public List<IndexedColumn> Columns; // 0x18
		}
	
		public class ColumnInfo // TypeDefIndex: 15443
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private string <Name>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <notnull>k__BackingField; // 0x18
	
			// Properties
			[Column] // 0x00000001800B39A0-0x00000001800B39D0
			public string Name { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public int notnull { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
	
			// Constructors
			public ColumnInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public override string ToString(); // 0x000000018036AC80-0x000000018036AC90
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15444
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<IndexedColumn> <>9__60_1; // 0x08
			public static Func<TableMapping.Column, string> <>9__105_2; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000180E3CDE0-0x0000000180E3CE40
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <CreateTable>b__60_1(IndexedColumn lhs, IndexedColumn rhs); // 0x0000000180E3B7D0-0x0000000180E3B7E0
			internal string <Update>b__105_2(TableMapping.Column c); // 0x0000000180E3B8A0-0x0000000180E3B8F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass95_0 // TypeDefIndex: 15445
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass95_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <InsertAll>b__0(); // 0x0000000180E3C6D0-0x0000000180E3C900
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass96_0 // TypeDefIndex: 15446
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
			public string extra; // 0x28
	
			// Constructors
			public <>c__DisplayClass96_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <InsertAll>b__0(); // 0x0000000180E3C900-0x0000000180E3CB10
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass97_0 // TypeDefIndex: 15447
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
			public Type objType; // 0x28
	
			// Constructors
			public <>c__DisplayClass97_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <InsertAll>b__0(); // 0x0000000180E3CB10-0x0000000180E3CD20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass105_0 // TypeDefIndex: 15448
		{
			// Fields
			public TableMapping.Column pk; // 0x10
			public object obj; // 0x18
	
			// Constructors
			public <>c__DisplayClass105_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <Update>b__0(TableMapping.Column p); // 0x0000000180E3B910-0x0000000180E3B920
			internal object <Update>b__1(TableMapping.Column c); // 0x0000000180E3B920-0x0000000180E3B970
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass106_0 // TypeDefIndex: 15449
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass106_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <UpdateAll>b__0(); // 0x0000000180E3B970-0x0000000180E3BB70
		}
	
		// Constructors
		public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = false /* Metadata: 0x0078498B */); // 0x0000000180E1BA00-0x0000000180E1BA30
		public SQLiteConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = false /* Metadata: 0x0078498C */); // 0x0000000180E1BA30-0x0000000180E1BF30
		static SQLiteConnection(); // 0x0000000180E1B950-0x0000000180E1BA00
	
		// Methods
		internal void InvokeTrace(string message); // 0x0000000180E1A6C0-0x0000000180E1A6E0
		internal void InvokeTimeExecution(TimeSpan executionTime, TimeSpan totalExecutionTime); // 0x0000000180E1A6A0-0x0000000180E1A6C0
		private void mayCreateSyncObject(string databasePath); // 0x0000000180E1C1E0-0x0000000180E1C2F0
		public void EnableLoadExtension(int onoff); // 0x0000000180E19520-0x0000000180E19630
		private static byte[] GetNullTerminatedUtf8(string s); // 0x0000000180E19A40-0x0000000180E19B10
		public TableMapping GetMapping(Type type, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x0078498D */); // 0x0000000180E19900-0x0000000180E19A40
		public TableMapping GetMapping<T>();
		public int DropTable<T>();
		public int CreateTable<T>(CreateFlags createFlags = CreateFlags.None /* Metadata: 0x00784991 */);
		public int CreateTable(Type ty, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x00784995 */); // 0x0000000180E187B0-0x0000000180E19120
		public int CreateIndex(string indexName, string tableName, string[] columnNames, bool unique = false /* Metadata: 0x00784999 */); // 0x0000000180E18580-0x0000000180E187B0
		public int CreateIndex(string indexName, string tableName, string columnName, bool unique = false /* Metadata: 0x0078499A */); // 0x0000000180E183F0-0x0000000180E184E0
		public int CreateIndex(string tableName, string columnName, bool unique = false /* Metadata: 0x0078499B */); // 0x0000000180E182D0-0x0000000180E183F0
		public int CreateIndex(string tableName, string[] columnNames, bool unique = false /* Metadata: 0x0078499C */); // 0x0000000180E184E0-0x0000000180E18580
		public void CreateIndex<T>(Expression<Func<T, object>> property, bool unique = false /* Metadata: 0x0078499D */);
		public List<ColumnInfo> GetTableInfo(string tableName); // 0x0000000180E19B10-0x0000000180E19B90
		private void MigrateTable(TableMapping map); // 0x0000000180E1A6E0-0x0000000180E1AB70
		protected virtual SQLiteCommand NewCommand(); // 0x0000000180E1AB70-0x0000000180E1AC10
		public SQLiteCommand CreateCommand(string cmdText, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] ps); // 0x0000000180E18160-0x0000000180E182D0
		public int Execute(string query, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args); // 0x0000000180E19630-0x0000000180E197C0
		public T ExecuteScalar<T>(string query, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args);
		public List<T> Query<T>(string query, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args)
			where T : new();
		public IEnumerable<T> DeferredQuery<T>(string query, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args)
			where T : new();
		public List<object> Query(TableMapping map, string query, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args); // 0x0000000180E1AC10-0x0000000180E1AC90
		public IEnumerable<object> DeferredQuery(TableMapping map, string query, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] args); // 0x0000000180E19120-0x0000000180E191A0
		public TableQuery<T> Table<T>()
			where T : new();
		public T Get<T>(object pk)
			where T : new();
		public T Get<T>(Expression<Func<T, bool>> predicate)
			where T : new();
		public T Find<T>(object pk)
			where T : new();
		public object Find(object pk, TableMapping map); // 0x0000000180E197C0-0x0000000180E19900
		public T Find<T>(Expression<Func<T, bool>> predicate)
			where T : new();
		public void BeginTransaction(); // 0x0000000180E17C00-0x0000000180E17D70
		public string SaveTransactionPoint(); // 0x0000000180E1B0C0-0x0000000180E1B3F0
		public void Rollback(); // 0x0000000180E1ADC0-0x0000000180E1ADD0
		public void RollbackTo(string savepoint); // 0x0000000180E1ADB0-0x0000000180E1ADC0
		private void RollbackTo(string savepoint, bool noThrow); // 0x0000000180E1ACE0-0x0000000180E1ADB0
		public void Release(string savepoint); // 0x0000000180E1AC90-0x0000000180E1ACE0
		private void DoSavePointExecute(string savepoint, string cmd); // 0x0000000180E19400-0x0000000180E19520
		public void Commit(); // 0x0000000180E180F0-0x0000000180E18160
		public void RunInTransaction(Action action); // 0x0000000180E1AF10-0x0000000180E1B0C0
		public void RunInDatabaseLock(Action action); // 0x0000000180E1ADD0-0x0000000180E1AF10
		public int InsertAll(IEnumerable objects); // 0x0000000180E19C50-0x0000000180E19D00
		public int InsertAll(IEnumerable objects, string extra); // 0x0000000180E19B90-0x0000000180E19C50
		public int InsertAll(IEnumerable objects, Type objType); // 0x0000000180E19D00-0x0000000180E19DC0
		public int Insert(object obj); // 0x0000000180E1A630-0x0000000180E1A6A0
		public int InsertOrReplace(object obj); // 0x0000000180E19E30-0x0000000180E19EA0
		public int Insert(object obj, Type objType); // 0x0000000180E1A550-0x0000000180E1A5C0
		public int InsertOrReplace(object obj, Type objType); // 0x0000000180E19DC0-0x0000000180E19E30
		public int Insert(object obj, string extra); // 0x0000000180E1A5C0-0x0000000180E1A630
		public int Insert(object obj, string extra, Type objType); // 0x0000000180E19EA0-0x0000000180E1A550
		public int Update(object obj); // 0x0000000180E1B900-0x0000000180E1B950
		public int Update(object obj, Type objType); // 0x0000000180E1B4C0-0x0000000180E1B900
		public int UpdateAll(IEnumerable objects); // 0x0000000180E1B410-0x0000000180E1B4C0
		public int Delete(object objectToDelete); // 0x0000000180E191A0-0x0000000180E19380
		public int Delete<T>(object primaryKey);
		public int DeleteAll<T>();
		~SQLiteConnection(); // 0x000000018072E430-0x000000018072E4D0
		public void Dispose(); // 0x0000000180E19380-0x0000000180E193F0
		protected virtual void Dispose(bool disposing); // 0x0000000180E193F0-0x0000000180E19400
		public void Close(); // 0x0000000180E17D70-0x0000000180E180F0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <CreateTable>b__60_0(TableMapping.Column p); // 0x0000000180E1B3F0-0x0000000180E1B410
	}
}

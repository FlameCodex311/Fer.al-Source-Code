/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public class SQLiteConnection : IDisposable // TypeDefIndex: 16277
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IntPtr <Handle>k__BackingField; // 0x50
		internal static readonly IntPtr NullHandle; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <DatabasePath>k__BackingField; // 0x58
		private static Dictionary<string, object> syncObjects; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Trace>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <TimeExecution>k__BackingField; // 0x61
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TraceHandler TraceEvent; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TimeExecutionHandler TimeExecutionEvent; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <StoreDateTimeAsTicks>k__BackingField; // 0x78
		private static bool _preserveDuringLinkMagic; // 0x10
	
		// Properties
		public IntPtr Handle { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public string DatabasePath { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public bool Trace { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0
		public bool TimeExecution { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180459DB0-0x0000000180459DC0 0x000000018045A0B0-0x000000018045A0C0
		public bool StoreDateTimeAsTicks { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180453D00-0x0000000180453D10 0x0000000180453D10-0x0000000180453D20
		public object SyncObject { get; } // 0x0000000180459C50-0x0000000180459CD0 
		public TimeSpan BusyTimeout { get; set; } // 0x0000000180372430-0x0000000180372440 0x000000018045A000-0x000000018045A0B0
		public IEnumerable<TableMapping> TableMappings { get; } // 0x0000000180459CD0-0x0000000180459DB0 
		public bool IsInTransaction { get; } // 0x0000000180459C40-0x0000000180459C50 
	
		// Events
		public event TraceHandler TraceEvent {
			add; // 0x0000000180459BA0-0x0000000180459C40
			remove; // 0x0000000180459F60-0x000000018045A000
		}
		public event TimeExecutionHandler TimeExecutionEvent {
			add; // 0x0000000180459B00-0x0000000180459BA0
			remove; // 0x0000000180459EC0-0x0000000180459F60
		}
	
		// Nested types
		public delegate void TraceHandler(string message); // TypeDefIndex: 16278; 0x000000018047A570-0x000000018047A990
	
		public delegate void TimeExecutionHandler(TimeSpan executionTime, TimeSpan totalExecutionTime); // TypeDefIndex: 16279; 0x000000018047A260-0x000000018047A570
	
		private struct IndexedColumn // TypeDefIndex: 16280
		{
			// Fields
			public int Order; // 0x00
			public string ColumnName; // 0x08
		}
	
		private struct IndexInfo // TypeDefIndex: 16281
		{
			// Fields
			public string IndexName; // 0x00
			public string TableName; // 0x08
			public bool Unique; // 0x10
			public List<IndexedColumn> Columns; // 0x18
		}
	
		public class ColumnInfo // TypeDefIndex: 16282
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string <Name>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <notnull>k__BackingField; // 0x18
	
			// Properties
			[Column] // 0x00000001801D6510-0x00000001801D6540
			public string Name { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public int notnull { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
	
			// Constructors
			public ColumnInfo(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public override string ToString(); // 0x0000000180372440-0x0000000180372450
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16283
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<IndexedColumn> <>9__60_1; // 0x08
			public static Func<TableMapping.Column, string> <>9__105_2; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018047B370-0x000000018047B3D0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <CreateTable>b__60_1(IndexedColumn lhs, IndexedColumn rhs); // 0x000000018047AA10-0x000000018047AA20
			internal string <Update>b__105_2(TableMapping.Column c); // 0x000000018047AA20-0x000000018047AA70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass95_0 // TypeDefIndex: 16284
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass95_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <InsertAll>b__0(); // 0x000000018047AD40-0x000000018047AF70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass96_0 // TypeDefIndex: 16285
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
			public string extra; // 0x28
	
			// Constructors
			public <>c__DisplayClass96_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <InsertAll>b__0(); // 0x000000018047AF70-0x000000018047B170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass97_0 // TypeDefIndex: 16286
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
			public Type objType; // 0x28
	
			// Constructors
			public <>c__DisplayClass97_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <InsertAll>b__0(); // 0x000000018047B170-0x000000018047B370
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass105_0 // TypeDefIndex: 16287
		{
			// Fields
			public TableMapping.Column pk; // 0x10
			public object obj; // 0x18
	
			// Constructors
			public <>c__DisplayClass105_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <Update>b__0(TableMapping.Column p); // 0x000000018047AA90-0x000000018047AAA0
			internal object <Update>b__1(TableMapping.Column c); // 0x000000018047AAA0-0x000000018047AAF0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass106_0 // TypeDefIndex: 16288
		{
			// Fields
			public IEnumerable objects; // 0x10
			public int c; // 0x18
			public SQLiteConnection <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass106_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <UpdateAll>b__0(); // 0x000000018047AAF0-0x000000018047ACF0
		}
	
		// Constructors
		public SQLiteConnection(string databasePath, bool storeDateTimeAsTicks = false /* Metadata: 0x007BBAFB */); // 0x0000000180459710-0x0000000180459740
		public SQLiteConnection(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks = false /* Metadata: 0x007BBAFC */); // 0x0000000180459740-0x0000000180459B00
		static SQLiteConnection(); // 0x0000000180459660-0x0000000180459710
	
		// Methods
		internal void InvokeTrace(string message); // 0x0000000180458450-0x0000000180458470
		internal void InvokeTimeExecution(TimeSpan executionTime, TimeSpan totalExecutionTime); // 0x0000000180458430-0x0000000180458450
		private void mayCreateSyncObject(string databasePath); // 0x0000000180459DC0-0x0000000180459EC0
		public void EnableLoadExtension(int onoff); // 0x00000001804573C0-0x0000000180457440
		private static byte[] GetNullTerminatedUtf8(string s); // 0x00000001804578E0-0x00000001804579A0
		public TableMapping GetMapping(Type type, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x007BBAFD */); // 0x00000001804577A0-0x00000001804578E0
		public TableMapping GetMapping<T>();
		public int DropTable<T>();
		public int CreateTable<T>(CreateFlags createFlags = CreateFlags.None /* Metadata: 0x007BBB01 */);
		public int CreateTable(Type ty, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x007BBB05 */); // 0x00000001804566A0-0x0000000180456FD0
		public int CreateIndex(string indexName, string tableName, string[] columnNames, bool unique = false /* Metadata: 0x007BBB09 */); // 0x0000000180456490-0x00000001804566A0
		public int CreateIndex(string indexName, string tableName, string columnName, bool unique = false /* Metadata: 0x007BBB0A */); // 0x0000000180456310-0x00000001804563F0
		public int CreateIndex(string tableName, string columnName, bool unique = false /* Metadata: 0x007BBB0B */); // 0x0000000180456200-0x0000000180456310
		public int CreateIndex(string tableName, string[] columnNames, bool unique = false /* Metadata: 0x007BBB0C */); // 0x00000001804563F0-0x0000000180456490
		public void CreateIndex<T>(Expression<Func<T, object>> property, bool unique = false /* Metadata: 0x007BBB0D */);
		public List<ColumnInfo> GetTableInfo(string tableName); // 0x00000001804579A0-0x0000000180457A20
		private void MigrateTable(TableMapping map); // 0x0000000180458470-0x00000001804588F0
		protected virtual SQLiteCommand NewCommand(); // 0x00000001804588F0-0x0000000180458950
		public SQLiteCommand CreateCommand(string cmdText, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] ps); // 0x0000000180456110-0x0000000180456200
		public int Execute(string query, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // 0x0000000180457440-0x00000001804575C0
		public T ExecuteScalar<T>(string query, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args);
		public List<T> Query<T>(string query, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args)
			where T : new();
		public IEnumerable<T> DeferredQuery<T>(string query, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args)
			where T : new();
		public List<object> Query(TableMapping map, string query, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // 0x0000000180458950-0x00000001804589D0
		public IEnumerable<object> DeferredQuery(TableMapping map, string query, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // 0x0000000180456FD0-0x0000000180457050
		public TableQuery<T> Table<T>()
			where T : new();
		public T Get<T>(object pk)
			where T : new();
		public T Get<T>(Expression<Func<T, bool>> predicate)
			where T : new();
		public T Find<T>(object pk)
			where T : new();
		public object Find(object pk, TableMapping map); // 0x0000000180457660-0x00000001804577A0
		public T Find<T>(Expression<Func<T, bool>> predicate)
			where T : new();
		public void BeginTransaction(); // 0x0000000180455C90-0x0000000180455E00
		public string SaveTransactionPoint(); // 0x0000000180458E00-0x0000000180459110
		public void Rollback(); // 0x0000000180458B00-0x0000000180458B10
		public void RollbackTo(string savepoint); // 0x0000000180458AF0-0x0000000180458B00
		private void RollbackTo(string savepoint, bool noThrow); // 0x0000000180458A20-0x0000000180458AF0
		public void Release(string savepoint); // 0x00000001804589D0-0x0000000180458A20
		private void DoSavePointExecute(string savepoint, string cmd); // 0x00000001804572A0-0x00000001804573C0
		public void Commit(); // 0x00000001804560A0-0x0000000180456110
		public void RunInTransaction(Action action); // 0x0000000180458C50-0x0000000180458E00
		public void RunInDatabaseLock(Action action); // 0x0000000180458B10-0x0000000180458C50
		public int InsertAll(IEnumerable objects); // 0x0000000180457AE0-0x0000000180457B90
		public int InsertAll(IEnumerable objects, string extra); // 0x0000000180457A20-0x0000000180457AE0
		public int InsertAll(IEnumerable objects, Type objType); // 0x0000000180457B90-0x0000000180457C50
		public int Insert(object obj); // 0x00000001804583C0-0x0000000180458430
		public int InsertOrReplace(object obj); // 0x0000000180457CC0-0x0000000180457D30
		public int Insert(object obj, Type objType); // 0x00000001804582E0-0x0000000180458350
		public int InsertOrReplace(object obj, Type objType); // 0x0000000180457C50-0x0000000180457CC0
		public int Insert(object obj, string extra); // 0x0000000180458350-0x00000001804583C0
		public int Insert(object obj, string extra, Type objType); // 0x0000000180457D30-0x00000001804582E0
		public int Update(object obj); // 0x0000000180459610-0x0000000180459660
		public int Update(object obj, Type objType); // 0x00000001804591E0-0x0000000180459610
		public int UpdateAll(IEnumerable objects); // 0x0000000180459130-0x00000001804591E0
		public int Delete(object objectToDelete); // 0x0000000180457050-0x0000000180457220
		public int Delete<T>(object primaryKey);
		public int DeleteAll<T>();
		~SQLiteConnection(); // 0x00000001804575C0-0x0000000180457660
		public void Dispose(); // 0x0000000180457220-0x0000000180457290
		protected virtual void Dispose(bool disposing); // 0x0000000180457290-0x00000001804572A0
		public void Close(); // 0x0000000180455E00-0x00000001804560A0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <CreateTable>b__60_0(TableMapping.Column p); // 0x0000000180459110-0x0000000180459130
	}
}

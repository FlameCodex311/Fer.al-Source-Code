/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public class TableMapping // TypeDefIndex: 16300
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <MappedType>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <TableName>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Column[] <Columns>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Column <PK>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <GetByPrimaryKeySql>k__BackingField; // 0x30
		private Column _autoPk; // 0x38
		private Column[] _insertColumns; // 0x40
		private Column[] _insertOrReplaceColumns; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasAutoIncPK>k__BackingField; // 0x50
		private PreparedSqlLiteInsertCommand _insertCommand; // 0x58
		private string _insertCommandExtra; // 0x60
	
		// Properties
		public Type MappedType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public string TableName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public Column[] Columns { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public Column PK { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public string GetByPrimaryKeySql { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public bool HasAutoIncPK { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0
		public Column[] InsertColumns { get; } // 0x000000018047A050-0x000000018047A170 
		public Column[] InsertOrReplaceColumns { get; } // 0x000000018047A170-0x000000018047A1C0 
	
		// Nested types
		public class Column // TypeDefIndex: 16301
		{
			// Fields
			private PropertyInfo _prop; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string <Name>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Type <ColumnType>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string <Collation>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <IsAutoInc>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <IsAutoGuid>k__BackingField; // 0x31
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <IsPK>k__BackingField; // 0x32
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private IEnumerable<IndexedAttribute> <Indices>k__BackingField; // 0x38
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <IsNullable>k__BackingField; // 0x40
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int? <MaxStringLength>k__BackingField; // 0x44
	
			// Properties
			public string Name { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
			public string PropertyName { get; } // 0x0000000180455BD0-0x0000000180455C00 
			public Type ColumnType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
			public string Collation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
			public bool IsAutoInc { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180455C10-0x0000000180455C20
			public bool IsAutoGuid { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455B80-0x0000000180455B90 0x0000000180455C00-0x0000000180455C10
			public bool IsPK { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455BB0-0x0000000180455BC0 0x0000000180455C30-0x0000000180455C40
			public IEnumerable<IndexedAttribute> Indices { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
			public bool IsNullable { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455BA0-0x0000000180455BB0 0x0000000180455C20-0x0000000180455C30
			public int? MaxStringLength { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455BC0-0x0000000180455BD0 0x0000000180455C40-0x0000000180455C50
	
			// Constructors
			public Column(PropertyInfo prop, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x007BBB12 */); // 0x00000001804557E0-0x0000000180455B80
	
			// Methods
			public void SetValue(object obj, object val); // 0x00000001804557A0-0x00000001804557E0
			public object GetValue(object obj); // 0x0000000180455760-0x00000001804557A0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16302
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Column, bool> <>9__30_0; // 0x08
			public static Func<Column, string> <>9__38_0; // 0x10
			public static Func<Column, string> <>9__38_1; // 0x18
	
			// Constructors
			static <>c(); // 0x000000018047B3D0-0x000000018047B430
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <get_InsertColumns>b__30_0(Column c); // 0x000000018047AA70-0x000000018047AA90
			internal string <CreateInsertCommand>b__38_0(Column c); // 0x000000018047A990-0x000000018047A9E0
			internal string <CreateInsertCommand>b__38_1(Column c); // 0x000000018047A9E0-0x000000018047AA10
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 16303
		{
			// Fields
			public string propertyName; // 0x10
	
			// Constructors
			public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <FindColumnWithPropertyName>b__0(Column c); // 0x000000018047ACF0-0x000000018047AD40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 16304
		{
			// Fields
			public string columnName; // 0x10
	
			// Constructors
			public <>c__DisplayClass34_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <FindColumn>b__0(Column c); // 0x0000000180387C90-0x0000000180387CC0
		}
	
		// Constructors
		public TableMapping(Type type, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x007BBB0E */); // 0x0000000180479CC0-0x000000018047A050
	
		// Methods
		public void SetAutoIncPK(object obj, long id); // 0x0000000180479BD0-0x0000000180479CC0
		public Column FindColumnWithPropertyName(string propertyName); // 0x00000001804799F0-0x0000000180479AA0
		public Column FindColumn(string columnName); // 0x0000000180479AA0-0x0000000180479B50
		public PreparedSqlLiteInsertCommand GetInsertCommand(SQLiteConnection conn, string extra); // 0x0000000180479B50-0x0000000180479BD0
		private PreparedSqlLiteInsertCommand CreateInsertCommand(SQLiteConnection conn, string extra); // 0x0000000180479530-0x00000001804799C0
		protected internal void Dispose(); // 0x00000001804799C0-0x00000001804799F0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class TableMapping // TypeDefIndex: 15461
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <MappedType>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <TableName>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Column[] <Columns>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Column <PK>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <GetByPrimaryKeySql>k__BackingField; // 0x30
		private Column _autoPk; // 0x38
		private Column[] _insertColumns; // 0x40
		private Column[] _insertOrReplaceColumns; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasAutoIncPK>k__BackingField; // 0x50
		private PreparedSqlLiteInsertCommand _insertCommand; // 0x58
		private string _insertCommandExtra; // 0x60
	
		// Properties
		public Type MappedType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public string TableName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public Column[] Columns { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public Column PK { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public string GetByPrimaryKeySql { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public bool HasAutoIncPK { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00
		public Column[] InsertColumns { get; } // 0x0000000180E3ADB0-0x0000000180E3AED0 
		public Column[] InsertOrReplaceColumns { get; } // 0x0000000180E3AED0-0x0000000180E3AF20 
	
		// Nested types
		public class Column // TypeDefIndex: 15462
		{
			// Fields
			private PropertyInfo _prop; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private string <Name>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Type <ColumnType>k__BackingField; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private string <Collation>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <IsAutoInc>k__BackingField; // 0x30
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <IsAutoGuid>k__BackingField; // 0x31
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <IsPK>k__BackingField; // 0x32
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private IEnumerable<IndexedAttribute> <Indices>k__BackingField; // 0x38
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <IsNullable>k__BackingField; // 0x40
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int? <MaxStringLength>k__BackingField; // 0x44
	
			// Properties
			public string Name { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
			public string PropertyName { get; } // 0x0000000180470100-0x0000000180470130 
			public Type ColumnType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
			public string Collation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
			public bool IsAutoInc { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048B840-0x000000018048B850 0x000000018048B850-0x000000018048B860
			public bool IsAutoGuid { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001806DA7B0-0x00000001806DA7C0 0x0000000180E07050-0x0000000180E07060
			public bool IsPK { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E07030-0x0000000180E07040 0x0000000180E07060-0x0000000180E07070
			public IEnumerable<IndexedAttribute> Indices { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
			public bool IsNullable { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180478660-0x0000000180478670 0x00000001807009C0-0x00000001807009D0
			public int? MaxStringLength { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E07040-0x0000000180E07050 0x0000000180E07070-0x0000000180E07080
	
			// Constructors
			public Column(PropertyInfo prop, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x007849A2 */); // 0x0000000180E06AD0-0x0000000180E07030
	
			// Methods
			public void SetValue(object obj, object val); // 0x0000000180E06A90-0x0000000180E06AD0
			public object GetValue(object obj); // 0x0000000180E06A40-0x0000000180E06A90
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15463
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Column, bool> <>9__30_0; // 0x08
			public static Func<Column, string> <>9__38_0; // 0x10
			public static Func<Column, string> <>9__38_1; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000180E3CE40-0x0000000180E3CEA0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <get_InsertColumns>b__30_0(Column c); // 0x0000000180E3B8F0-0x0000000180E3B910
			internal string <CreateInsertCommand>b__38_0(Column c); // 0x0000000180E3B750-0x0000000180E3B7A0
			internal string <CreateInsertCommand>b__38_1(Column c); // 0x0000000180E3B7A0-0x0000000180E3B7D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 15464
		{
			// Fields
			public string propertyName; // 0x10
	
			// Constructors
			public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <FindColumnWithPropertyName>b__0(Column c); // 0x0000000180E3BE30-0x0000000180E3BE80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 15465
		{
			// Fields
			public string columnName; // 0x10
	
			// Constructors
			public <>c__DisplayClass34_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <FindColumn>b__0(Column c); // 0x0000000180E3BE80-0x0000000180E3BEB0
		}
	
		// Constructors
		public TableMapping(Type type, CreateFlags createFlags = CreateFlags.None /* Metadata: 0x0078499E */); // 0x0000000180E3AA10-0x0000000180E3ADB0
	
		// Methods
		public void SetAutoIncPK(object obj, long id); // 0x0000000180E3A920-0x0000000180E3AA10
		public Column FindColumnWithPropertyName(string propertyName); // 0x0000000180E3A740-0x0000000180E3A7F0
		public Column FindColumn(string columnName); // 0x0000000180E3A7F0-0x0000000180E3A8A0
		public PreparedSqlLiteInsertCommand GetInsertCommand(SQLiteConnection conn, string extra); // 0x0000000180E3A8A0-0x0000000180E3A920
		private PreparedSqlLiteInsertCommand CreateInsertCommand(SQLiteConnection conn, string extra); // 0x0000000180E3A220-0x0000000180E3A6C0
		protected internal void Dispose(); // 0x0000000180E3A6C0-0x0000000180E3A740
	}
}

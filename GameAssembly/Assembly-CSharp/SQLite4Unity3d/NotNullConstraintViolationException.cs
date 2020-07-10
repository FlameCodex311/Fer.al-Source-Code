/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class NotNullConstraintViolationException : SQLiteException // TypeDefIndex: 15434
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IEnumerable<TableMapping.Column> <Columns>k__BackingField; // 0x90
	
		// Properties
		public IEnumerable<TableMapping.Column> Columns { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180382A80-0x0000000180382A90 0x000000018049D4D0-0x000000018049D4E0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 15435
		{
			// Fields
			public object obj; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <.ctor>b__0(TableMapping.Column c); // 0x0000000180E3C1D0-0x0000000180E3C240
		}
	
		// Constructors
		protected NotNullConstraintViolationException(SQLite3.Result r, string message); // 0x0000000180E07370-0x0000000180E07390
		protected NotNullConstraintViolationException(SQLite3.Result r, string message, TableMapping mapping, object obj); // 0x0000000180E07240-0x0000000180E07370
	
		// Methods
		public static new NotNullConstraintViolationException New(SQLite3.Result r, string message); // 0x0000000180E07080-0x0000000180E070F0
		public static NotNullConstraintViolationException New(SQLite3.Result r, string message, TableMapping mapping, object obj); // 0x0000000180E071B0-0x0000000180E07240
		public static NotNullConstraintViolationException New(SQLiteException exception, TableMapping mapping, object obj); // 0x0000000180E070F0-0x0000000180E071B0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public class NotNullConstraintViolationException : SQLiteException // TypeDefIndex: 16273
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IEnumerable<TableMapping.Column> <Columns>k__BackingField; // 0x90
	
		// Properties
		public IEnumerable<TableMapping.Column> Columns { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 16274
		{
			// Fields
			public object obj; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <.ctor>b__0(TableMapping.Column c); // 0x000000018074A0E0-0x000000018074A120
		}
	
		// Constructors
		protected NotNullConstraintViolationException(SQLite3.Result r, string message); // 0x000000018072D5D0-0x000000018072D660
		protected NotNullConstraintViolationException(SQLite3.Result r, string message, TableMapping mapping, object obj); // 0x000000018072D4E0-0x000000018072D5D0
	
		// Methods
		public static new NotNullConstraintViolationException New(SQLite3.Result r, string message); // 0x000000018072D2E0-0x000000018072D3A0
		public static NotNullConstraintViolationException New(SQLite3.Result r, string message, TableMapping mapping, object obj); // 0x000000018072D450-0x000000018072D4E0
		public static NotNullConstraintViolationException New(SQLiteException exception, TableMapping mapping, object obj); // 0x000000018072D3A0-0x000000018072D450
	}
}

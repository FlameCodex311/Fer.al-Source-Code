/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public class PreparedSqlLiteInsertCommand : IDisposable // TypeDefIndex: 16309
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Initialized>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SQLiteConnection <Connection>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <CommandText>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IntPtr <Statement>k__BackingField; // 0x28
		internal static readonly IntPtr NullStatement; // 0x00
	
		// Properties
		public bool Initialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
		protected SQLiteConnection Connection { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string CommandText { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		protected IntPtr Statement { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		internal PreparedSqlLiteInsertCommand(SQLiteConnection conn); // 0x000000018056B4B0-0x000000018056B4E0
		static PreparedSqlLiteInsertCommand(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		public int ExecuteNonQuery(object[] source); // 0x000000018072E6C0-0x000000018072E9C0
		protected virtual IntPtr Prepare(); // 0x000000018072EA50-0x000000018072EA80
		public void Dispose(); // 0x000000018072E530-0x000000018072E590
		private void Dispose(bool disposing); // 0x000000018072E590-0x000000018072E6C0
		~PreparedSqlLiteInsertCommand(); // 0x000000018072E9C0-0x000000018072EA50
	}
}

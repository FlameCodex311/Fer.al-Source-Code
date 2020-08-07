/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public class SQLiteException : Exception // TypeDefIndex: 16272
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SQLite3.Result <Result>k__BackingField; // 0x88
	
		// Properties
		public SQLite3.Result Result { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0
	
		// Constructors
		protected SQLiteException(SQLite3.Result r, string message); // 0x000000018045A170-0x000000018045A1F0
	
		// Methods
		public static SQLiteException New(SQLite3.Result r, string message); // 0x000000018045A0D0-0x000000018045A170
	}
}

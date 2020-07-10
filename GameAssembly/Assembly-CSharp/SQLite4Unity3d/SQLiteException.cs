/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class SQLiteException : Exception // TypeDefIndex: 15433
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private SQLite3.Result <Result>k__BackingField; // 0x88
	
		// Properties
		public SQLite3.Result Result { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018049D3B0-0x000000018049D3C0 0x000000018049D3C0-0x000000018049D3D0
	
		// Constructors
		protected SQLiteException(SQLite3.Result r, string message); // 0x0000000180E1C610-0x0000000180E1C690
	
		// Methods
		public static SQLiteException New(SQLite3.Result r, string message); // 0x0000000180E1C570-0x0000000180E1C610
	}
}

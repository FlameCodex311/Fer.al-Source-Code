/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class PreparedSqlLiteInsertCommand : IDisposable // TypeDefIndex: 15470
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Initialized>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private SQLiteConnection <Connection>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <CommandText>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IntPtr <Statement>k__BackingField; // 0x28
		internal static readonly IntPtr NullStatement; // 0x00
	
		// Properties
		public bool Initialized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		protected SQLiteConnection Connection { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string CommandText { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		protected IntPtr Statement { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Constructors
		internal PreparedSqlLiteInsertCommand(SQLiteConnection conn); // 0x0000000180626C40-0x0000000180626C70
		static PreparedSqlLiteInsertCommand(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		public int ExecuteNonQuery(object[] source); // 0x0000000180E08470-0x0000000180E08790
		protected virtual IntPtr Prepare(); // 0x0000000180E08820-0x0000000180E08850
		public void Dispose(); // 0x0000000180E082E0-0x0000000180E08340
		private void Dispose(bool disposing); // 0x0000000180E08340-0x0000000180E08470
		~PreparedSqlLiteInsertCommand(); // 0x0000000180E08790-0x0000000180E08820
	}
}

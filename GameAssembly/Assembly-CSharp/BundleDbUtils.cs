/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SQLite4Unity3d;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class BundleDbUtils // TypeDefIndex: 13270
{
	// Fields
	private static SQLiteConnection _sqLiteConnection; // 0x00

	// Properties
	public static string BundleDbPath { get; } // 0x00000001813DCCE0-0x00000001813DCE30 

	// Methods
	public static void LoadBundleDbIfNull(); // 0x00000001813DCC40-0x00000001813DCCE0
	public static void CloseBundleDbConnection(); // 0x00000001813DC830-0x00000001813DC890
	public static void DeleteBundleDb(); // 0x00000001813DC890-0x00000001813DC8D0
	public static void InsertBundleDbEntry(string bundleName, string unityHash); // 0x00000001813DCB60-0x00000001813DCC40
	public static BundleDBEntry GetBundleEntry(string bundleName); // 0x00000001813DC8D0-0x00000001813DCA40
	public static string GetFullBundleName(string inBundlePath); // 0x00000001813DCA40-0x00000001813DCB60
}


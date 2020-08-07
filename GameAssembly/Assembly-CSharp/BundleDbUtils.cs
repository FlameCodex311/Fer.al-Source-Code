/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SQLite4Unity3d;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class BundleDbUtils // TypeDefIndex: 10936
{
	// Fields
	private static SQLiteConnection _sqLiteConnection; // 0x00

	// Properties
	public static string BundleDbPath { get; } // 0x0000000180495280-0x00000001804953D0 

	// Methods
	public static void LoadBundleDbIfNull(); // 0x00000001804951E0-0x0000000180495280
	public static void CloseBundleDbConnection(); // 0x0000000180494DF0-0x0000000180494E50
	public static void DeleteBundleDb(); // 0x0000000180494E50-0x0000000180494E90
	public static void InsertBundleDbEntry(string bundleName, string unityHash); // 0x0000000180495110-0x00000001804951E0
	public static BundleDBEntry GetBundleEntry(string bundleName); // 0x0000000180494E90-0x0000000180495000
	public static string GetFullBundleName(string inBundlePath); // 0x0000000180495000-0x0000000180495110
}


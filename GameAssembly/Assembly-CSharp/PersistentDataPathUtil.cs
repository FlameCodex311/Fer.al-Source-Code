/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class PersistentDataPathUtil // TypeDefIndex: 10889
{
	// Fields
	private static string[] _persistentDataPaths; // 0x00

	// Properties
	public static string PersistentDataPathInternal { get; } // 0x00000001804E08D0-0x00000001804E08E0 
	public static string PersistentDataPathExternal { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	public static string[] PersistentDataPaths { get; } // 0x00000001804E0940-0x00000001804E0AB0 
	public static string PersistentDataPath { get; } // 0x00000001804E08E0-0x00000001804E0940 

	// Methods
	public static bool IsDirectoryWritable(string path); // 0x00000001804E0460-0x00000001804E0530
	private static string GetPersistentDataPath(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] components); // 0x00000001804E01A0-0x00000001804E0310
	public static string GetPersistentFile(string relativePath); // 0x00000001804E0310-0x00000001804E0460
	public static bool SaveData(string relativePath, byte[] data); // 0x00000001804E0530-0x00000001804E0730
	private static bool SaveData(string relativePath, byte[] data, int pathIndex); // 0x00000001804E0730-0x00000001804E08D0
	public static bool FileExists(string path, string relativePath); // 0x00000001804E0110-0x00000001804E01A0
}


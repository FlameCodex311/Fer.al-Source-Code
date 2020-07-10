/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class PersistentDataPathUtil // TypeDefIndex: 13223
{
	// Fields
	private static string[] _persistentDataPaths; // 0x00

	// Properties
	public static string PersistentDataPathInternal { get; } // 0x0000000181173810-0x0000000181173820 
	public static string PersistentDataPathExternal { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	public static string[] PersistentDataPaths { get; } // 0x0000000181173880-0x00000001811739F0 
	public static string PersistentDataPath { get; } // 0x0000000181173820-0x0000000181173880 

	// Methods
	public static bool IsDirectoryWritable(string path); // 0x0000000181173390-0x0000000181173460
	private static string GetPersistentDataPath(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] components); // 0x00000001811730D0-0x0000000181173240
	public static string GetPersistentFile(string relativePath); // 0x0000000181173240-0x0000000181173390
	public static bool SaveData(string relativePath, byte[] data); // 0x0000000181173460-0x0000000181173660
	private static bool SaveData(string relativePath, byte[] data, int pathIndex); // 0x0000000181173660-0x0000000181173810
	public static bool FileExists(string path, string relativePath); // 0x0000000181173040-0x00000001811730D0
}


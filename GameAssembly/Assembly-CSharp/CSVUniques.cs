/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CSVUniques // TypeDefIndex: 13377
{
	// Fields
	private static Dictionary<string, List<string>> uniques; // 0x00
	private static Dictionary<string, List<string>> uniqueKeys; // 0x08

	// Constructors
	public CSVUniques(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public static void clearData(); // 0x00000001810230A0-0x00000001810230F0
	public static void clearData(string sheetKey); // 0x0000000181022F60-0x00000001810230A0
	public static void addUnique(string sheetKey, string uniqueKey); // 0x00000001810227E0-0x0000000181022AA0
	public static bool checkUnique(string sheetKey, string key, object value); // 0x0000000181022AA0-0x0000000181022F60
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CSVUniques // TypeDefIndex: 10968
{
	// Fields
	private static Dictionary<string, List<string>> uniques; // 0x00
	private static Dictionary<string, List<string>> uniqueKeys; // 0x08

	// Constructors
	public CSVUniques(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public static void clearData(); // 0x000000018049B970-0x000000018049B9C0
	public static void clearData(string sheetKey); // 0x000000018049B830-0x000000018049B970
	public static void addUnique(string sheetKey, string uniqueKey); // 0x000000018049B0F0-0x000000018049B3A0
	public static bool checkUnique(string sheetKey, string key, object value); // 0x000000018049B3A0-0x000000018049B830
}


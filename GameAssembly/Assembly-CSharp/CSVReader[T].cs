/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CSVReader<T> // TypeDefIndex: 10972
	where T : CSVReaderItemBase, new()
{
	// Fields
	private static string _encryptedToken;

	// Constructors
	public CSVReader();
	static CSVReader();

	// Methods
	public static CSVReaderOutput LoadCSV(string inName, string inText, bool inRequireEncrypted);
}


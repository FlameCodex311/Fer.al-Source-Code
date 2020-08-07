/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DiffPlex.Model;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace DiffPlex
{
	public interface IDiffer // TypeDefIndex: 14337
	{
		// Methods
		DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
		DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
		DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
		DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
		DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
		DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
		DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
		DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
	}
}

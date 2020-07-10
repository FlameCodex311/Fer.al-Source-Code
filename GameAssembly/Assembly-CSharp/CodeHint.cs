/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class CodeHint // TypeDefIndex: 12873
{
	// Fields
	public List<CodeHintType> hints; // 0x10

	// Constructors
	public CodeHint(); // 0x000000018127CBD0-0x000000018127CC30

	// Methods
	public void AddHint(CodeHintType inHint); // 0x000000018127CA60-0x000000018127CAC0
	public void ClearHints(); // 0x000000018127CAC0-0x000000018127CB10
	public bool IsMatch(int codeLength); // 0x000000018127CB10-0x000000018127CBD0
}


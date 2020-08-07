/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class CodeHint // TypeDefIndex: 10534
{
	// Fields
	public List<CodeHintType> hints; // 0x10

	// Constructors
	public CodeHint(); // 0x000000018077A0F0-0x000000018077A150

	// Methods
	public void AddHint(CodeHintType inHint); // 0x0000000180779F80-0x0000000180779FE0
	public void ClearHints(); // 0x0000000180779FE0-0x000000018077A030
	public bool IsMatch(int codeLength); // 0x000000018077A030-0x000000018077A0F0
}


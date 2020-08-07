/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class Code // TypeDefIndex: 10533
{
	// Fields
	public int codeLength; // 0x10
	public List<CodeColor> sequence; // 0x18

	// Constructors
	public Code(); // 0x0000000180533E40-0x0000000180533EB0

	// Methods
	public void SetCodeLength(int inLength); // 0x0000000180533BB0-0x0000000180533C50
	public void SetCode(CodeColor[] inColors); // 0x0000000180533CD0-0x0000000180533D50
	public void SetCode(List<CodeColor> inColors); // 0x0000000180533C50-0x0000000180533CD0
	public void SetCodeAtIndex(int inIndex, CodeColor inColor); // 0x0000000180533B40-0x0000000180533BB0
	public bool IsCodeValid(); // 0x0000000180533A80-0x0000000180533B40
	public static Code GenerateRandomCode(int inLength); // 0x0000000180533910-0x0000000180533A80
	public static Code GenerateRandomCode(int inLength, int inColorMask, bool allowRepeat); // 0x0000000180533640-0x0000000180533910
	public override string ToString(); // 0x0000000180533D50-0x0000000180533E40
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class Code // TypeDefIndex: 12872
{
	// Fields
	public int codeLength; // 0x10
	public List<CodeColor> sequence; // 0x18

	// Constructors
	public Code(); // 0x000000018127E3B0-0x000000018127E420

	// Methods
	public void SetCodeLength(int inLength); // 0x000000018127E110-0x000000018127E1B0
	public void SetCode(CodeColor[] inColors); // 0x000000018127E230-0x000000018127E2B0
	public void SetCode(List<CodeColor> inColors); // 0x000000018127E1B0-0x000000018127E230
	public void SetCodeAtIndex(int inIndex, CodeColor inColor); // 0x000000018127E0A0-0x000000018127E110
	public bool IsCodeValid(); // 0x000000018127DFE0-0x000000018127E0A0
	public static Code GenerateRandomCode(int inLength); // 0x000000018127DE70-0x000000018127DFE0
	public static Code GenerateRandomCode(int inLength, int inColorMask, bool allowRepeat); // 0x000000018127DB90-0x000000018127DE70
	public override string ToString(); // 0x000000018127E2B0-0x000000018127E3B0
}


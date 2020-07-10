/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeAttempt // TypeDefIndex: 12863
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Code <Code>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private CodeHint <Hint>k__BackingField; // 0x18

	// Properties
	public Code Code { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public CodeHint Hint { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170

	// Constructors
	public CodeAttempt(Code inCode); // 0x000000018126C3A0-0x000000018126C450

	// Methods
	public bool CompareToCode(Code inCode); // 0x000000018126BB00-0x000000018126BF50
	public bool AllHintsCorrect(); // 0x000000018126B840-0x000000018126B9B0
	public bool AllHintsWrong(); // 0x000000018126B9B0-0x000000018126BB00
	public bool HasWrongPlaceHint(); // 0x000000018126C220-0x000000018126C3A0
	public bool HasCorrectPlaceHint(); // 0x000000018126BF50-0x000000018126C0D0
	public bool HasDuplicates(); // 0x000000018126C0D0-0x000000018126C220
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeAttempt // TypeDefIndex: 10521
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Code <Code>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CodeHint <Hint>k__BackingField; // 0x18

	// Properties
	public Code Code { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public CodeHint Hint { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40

	// Constructors
	public CodeAttempt(Code inCode); // 0x0000000180524AE0-0x0000000180524B50
	public CodeAttempt(Code inCode, CodeHint inHint); // 0x0000000180372010-0x00000001803720F0

	// Methods
	public bool TutorialCompareToCode(Code inCode); // 0x0000000180524740-0x0000000180524AE0
	public bool AllHintsCorrect(); // 0x0000000180524040-0x00000001805241B0
	public bool AllHintsWrong(); // 0x00000001805241B0-0x0000000180524300
	public bool HasWrongPlaceHint(); // 0x00000001805245C0-0x0000000180524740
	public bool HasCorrectPlaceHint(); // 0x0000000180524300-0x0000000180524480
	public bool HasDuplicates(); // 0x0000000180524480-0x00000001805245C0
}


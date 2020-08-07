/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class WindowMessage : TaggedMessage // TypeDefIndex: 11207
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Window <Window>k__BackingField; // 0x20

	// Properties
	public UI_Window Window { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0

	// Constructors
	protected WindowMessage(string inTag, UI_Window inWindow); // 0x00000001805E5BD0-0x00000001805E5C10

	// Methods
	protected void SetParams(string inTag, UI_Window inWindow); // 0x00000001805E63F0-0x00000001805E6400
	protected void ClearParams(); // 0x00000001805E6390-0x00000001805E63F0
}


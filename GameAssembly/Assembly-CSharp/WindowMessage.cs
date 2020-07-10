/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class WindowMessage : TaggedMessage // TypeDefIndex: 13536
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Window <Window>k__BackingField; // 0x20

	// Properties
	public UI_Window Window { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0

	// Constructors
	protected WindowMessage(string inTag, UI_Window inWindow); // 0x0000000180FFE8F0-0x0000000180FFE930

	// Methods
	protected void SetParams(string inTag, UI_Window inWindow); // 0x0000000180FFF120-0x0000000180FFF130
	protected void ClearParams(); // 0x0000000180FFF0C0-0x0000000180FFF120
}


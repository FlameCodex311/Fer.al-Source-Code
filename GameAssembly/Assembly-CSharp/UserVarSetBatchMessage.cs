/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UserVarSetBatchMessage : ServerMessage // TypeDefIndex: 12942
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <userVarDefId>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <updatedValueCount>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int[] <indices>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private long[] <newValues>k__BackingField; // 0x50

	// Properties
	public bool success { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180455C10-0x0000000180455C20
	public string userVarDefId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	public int updatedValueCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379F10-0x0000000180379F20 0x00000001804ADAD0-0x00000001804ADAE0
	public int[] indices { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
	public long[] newValues { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0

	// Constructors
	public UserVarSetBatchMessage(XtReader data); // 0x000000018066C540-0x000000018066C6B0
}


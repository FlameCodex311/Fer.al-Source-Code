/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UserVarSetBatchMessage : ServerMessage // TypeDefIndex: 11410
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <userVarDefId>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <updatedValueCount>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int[] <indices>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private long[] <newValues>k__BackingField; // 0x50

	// Properties
	public bool success { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048B840-0x000000018048B850 0x000000018048B850-0x000000018048B860
	public string userVarDefId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	public int updatedValueCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018047AB20-0x000000018047AB30 0x00000001804D0BC0-0x00000001804D0BD0
	public int[] indices { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
	public long[] newValues { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860

	// Constructors
	public UserVarSetBatchMessage(XtReader data); // 0x0000000181220710-0x0000000181220890
}


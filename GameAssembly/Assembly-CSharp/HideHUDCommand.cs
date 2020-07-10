/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class HideHUDCommand : Message // TypeDefIndex: 10841
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static int <HideCount>k__BackingField; // 0x00
	private static Dictionary<string, int> _hideCountOverrideOffsets; // 0x08

	// Properties
	public static int HideCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F54BB0-0x0000000180F54C10 0x0000000180F54C10-0x0000000180F54C70
	public static bool Hidden { get; } // 0x0000000180F54B10-0x0000000180F54BB0 

	// Constructors
	public HideHUDCommand(bool inHide); // 0x0000000180F54460-0x0000000180F546D0
	public HideHUDCommand(bool inHide, string[] inExclusionKeys); // 0x0000000180F546D0-0x0000000180F54B10
	static HideHUDCommand(); // 0x0000000180F54400-0x0000000180F54460

	// Methods
	public static bool IsHidden(string inExclusionKey = "" /* Metadata: 0x0078204E */); // 0x0000000180F541A0-0x0000000180F54360
	[CoreResetTarget] // 0x00000001800E0A70-0x00000001800E0AA0
	[RuntimeInitializeOnLoadMethod] // 0x00000001800E0A70-0x00000001800E0AA0
	public static void Reset(); // 0x0000000180F54360-0x0000000180F54400
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class HideHUDCommand : Message // TypeDefIndex: 12351
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static int <HideCount>k__BackingField; // 0x00
	private static Dictionary<string, int> _hideCountOverrideOffsets; // 0x08

	// Properties
	public static int HideCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018061F080-0x000000018061F0E0 0x000000018061F0E0-0x000000018061F140
	public static bool Hidden { get; } // 0x000000018061EFE0-0x000000018061F080 

	// Constructors
	public HideHUDCommand(bool inHide); // 0x000000018061E930-0x000000018061EBA0
	public HideHUDCommand(bool inHide, string[] inExclusionKeys); // 0x000000018061EBA0-0x000000018061EFE0
	static HideHUDCommand(); // 0x000000018061E8D0-0x000000018061E930

	// Methods
	public static bool IsHidden(string inExclusionKey = "" /* Metadata: 0x007B970D */); // 0x000000018061E670-0x000000018061E830
	[CoreResetTarget] // 0x00000001801FEF10-0x00000001801FEF40
	[RuntimeInitializeOnLoadMethod] // 0x00000001801FEF10-0x00000001801FEF40
	public static void Reset(); // 0x000000018061E830-0x000000018061E8D0
}


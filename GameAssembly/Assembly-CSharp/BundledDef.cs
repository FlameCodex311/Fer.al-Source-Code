/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class BundledDef : BaseDef // TypeDefIndex: 13319
{
	// Fields
	[Header] // 0x00000001801258B0-0x0000000180125910
	[Tooltip] // 0x00000001801258B0-0x0000000180125910
	public string bundleID; // 0x50
	public string fullBundleID; // 0x58
	public static Dictionary<string, string> bundleRootDict; // 0x00

	// Constructors
	public BundledDef(); // 0x00000001813DDC60-0x00000001813DDCC0
	static BundledDef(); // 0x00000001813DDC00-0x00000001813DDC60

	// Methods
	public static string RepairBundleIDString(string inString); // 0x00000001813DDAA0-0x00000001813DDC00
	public override void LoadEntry(); // 0x00000001813DD860-0x00000001813DDAA0
}


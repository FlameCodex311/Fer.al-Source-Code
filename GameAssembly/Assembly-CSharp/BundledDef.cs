/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class BundledDef : BaseDef // TypeDefIndex: 10990
{
	// Fields
	[Header] // 0x00000001801FFD30-0x00000001801FFD90
	[Tooltip] // 0x00000001801FFD30-0x00000001801FFD90
	public string bundleID; // 0x50
	public string fullBundleID; // 0x58
	public static Dictionary<string, string> bundleRootDict; // 0x00

	// Constructors
	public BundledDef(); // 0x0000000180496200-0x0000000180496260
	static BundledDef(); // 0x00000001804961A0-0x0000000180496200

	// Methods
	public static string RepairBundleIDString(string inString); // 0x0000000180496050-0x00000001804961A0
	public override void LoadEntry(); // 0x0000000180495E10-0x0000000180496050
}


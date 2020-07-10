/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BundledDefComponent : DefComponent // TypeDefIndex: 13365
{
	// Fields
	[Header] // 0x00000001801258B0-0x0000000180125910
	[Tooltip] // 0x00000001801258B0-0x0000000180125910
	public string bundleID; // 0x18
	private string _fullBundleID; // 0x20
	public static Dictionary<string, string> bundleIDRootFromChartName; // 0x00

	// Properties
	public string FullBundleID { get; } // 0x00000001813DD770-0x00000001813DD860 
	protected virtual string FullBundleIDParentPath { get; } // 0x00000001813DD6E0-0x00000001813DD770 
	public string BundleIDRoot { get; } // 0x00000001813DD650-0x00000001813DD6E0 

	// Constructors
	public BundledDefComponent(); // 0x0000000180363710-0x0000000180363720
	static BundledDefComponent(); // 0x00000001813DD5F0-0x00000001813DD650

	// Methods
	protected override void LoadEntry(); // 0x00000001813DD590-0x00000001813DD5F0
}


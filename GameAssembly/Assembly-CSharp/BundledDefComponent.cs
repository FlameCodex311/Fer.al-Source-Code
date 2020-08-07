/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BundledDefComponent : DefComponent // TypeDefIndex: 11036
{
	// Fields
	[Header] // 0x00000001801FFD30-0x00000001801FFD90
	[Tooltip] // 0x00000001801FFD30-0x00000001801FFD90
	public string bundleID; // 0x18
	private string _fullBundleID; // 0x20
	public static Dictionary<string, string> bundleIDRootFromChartName; // 0x00

	// Properties
	public string FullBundleID { get; } // 0x0000000180495D20-0x0000000180495E10 
	protected virtual string FullBundleIDParentPath { get; } // 0x0000000180495C90-0x0000000180495D20 
	public string BundleIDRoot { get; } // 0x0000000180495C00-0x0000000180495C90 

	// Constructors
	public BundledDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200
	static BundledDefComponent(); // 0x0000000180495BA0-0x0000000180495C00

	// Methods
	protected override void LoadEntry(); // 0x0000000180495B40-0x0000000180495BA0
}


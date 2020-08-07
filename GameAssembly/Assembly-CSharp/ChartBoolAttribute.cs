/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChartBoolAttribute : ChartDrawableFieldAttribute // TypeDefIndex: 13014
{
	// Fields
	private bool? _csvSetOnExportValue; // 0xA8
	private bool _csvTrueRequiredToExport; // 0xAA

	// Properties
	public bool CSVSetOnExport { get; set; } // 0x000000018049E420-0x000000018049E460 0x000000018049E470-0x000000018049E4D0
	public bool CSVTrueRequiredToExport { get; set; } // 0x000000018049E460-0x000000018049E470 0x000000018049E4D0-0x000000018049E4E0
	public override bool CSVAllowExport { get; } // 0x000000018049E280-0x000000018049E420 

	// Constructors
	public ChartBoolAttribute(); // 0x000000018049E220-0x000000018049E280

	// Methods
	public override bool OnExportAsCSV(); // 0x000000018049E1A0-0x000000018049E220
}


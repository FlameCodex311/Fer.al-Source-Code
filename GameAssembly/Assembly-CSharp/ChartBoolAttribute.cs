/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChartBoolAttribute : ChartDrawableFieldAttribute // TypeDefIndex: 11491
{
	// Fields
	private bool? _csvSetOnExportValue; // 0xA8
	private bool _csvTrueRequiredToExport; // 0xAA

	// Properties
	public bool CSVSetOnExport { get; set; } // 0x0000000181025AB0-0x0000000181025AF0 0x0000000181025B00-0x0000000181025B60
	public bool CSVTrueRequiredToExport { get; set; } // 0x0000000181025AF0-0x0000000181025B00 0x0000000181025B60-0x0000000181025B70
	public override bool CSVAllowExport { get; } // 0x0000000181025910-0x0000000181025AB0 

	// Constructors
	public ChartBoolAttribute(); // 0x00000001810258B0-0x0000000181025910

	// Methods
	public override bool OnExportAsCSV(); // 0x0000000181025830-0x00000001810258B0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x00000001801FE180-0x00000001801FE1B0
public class FilterDefComponent : DefComponent // TypeDefIndex: 11978
{
	// Fields
	[ChartDef] // 0x00000001801FE450-0x00000001801FE500
	[ChartList] // 0x00000001801FE450-0x00000001801FE500
	public List<string> localizedFilterDefIds; // 0x18
	private List<string> _filters; // 0x20

	// Properties
	public List<string> Filters { get; } // 0x000000018069F3D0-0x000000018069F5C0 

	// Constructors
	public FilterDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	private void AddAutomaticFilters(); // 0x000000018069E850-0x000000018069EAA0
	private void AddAttachPointFilter(); // 0x000000018069E100-0x000000018069E850
	private void AddFurnitureCategoryFilter(); // 0x000000018069EBF0-0x000000018069EEA0
	private void AddInventoryCategoryFilter(); // 0x000000018069EEA0-0x000000018069F190
	private void AddColorFilter(); // 0x000000018069EAA0-0x000000018069EBF0
	private void AddRarityFilter(); // 0x000000018069F190-0x000000018069F3D0
}


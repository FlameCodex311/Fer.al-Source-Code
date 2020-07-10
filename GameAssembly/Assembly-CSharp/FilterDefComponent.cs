/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x0000000180128F50-0x0000000180128F80
public class FilterDefComponent : DefComponent // TypeDefIndex: 10490
{
	// Fields
	[ChartDef] // 0x0000000180129150-0x0000000180129200
	[ChartList] // 0x0000000180129150-0x0000000180129200
	public List<string> localizedFilterDefIds; // 0x18
	private List<string> _filters; // 0x20

	// Properties
	public List<string> Filters { get; } // 0x00000001811096F0-0x00000001811099D0 

	// Constructors
	public FilterDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	private void AddAutomaticFilters(); // 0x0000000181108C70-0x0000000181108D80
	private void AddAttachPointFilter(); // 0x00000001811084E0-0x0000000181108C70
	private void AddFurnitureCategoryFilter(); // 0x0000000181108ED0-0x00000001811091A0
	private void AddInventoryCategoryFilter(); // 0x00000001811091A0-0x00000001811094A0
	private void AddColorFilter(); // 0x0000000181108D80-0x0000000181108ED0
	private void AddRarityFilter(); // 0x00000001811094A0-0x00000001811096F0
}


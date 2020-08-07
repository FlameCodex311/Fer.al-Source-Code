/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public interface IFilterable // TypeDefIndex: 13606
{
	// Properties
	List<string> SupportedFilters { get; }

	// Methods
	void AddFilter(string inFilter);
	void RemoveFilter(string inFilter);
}


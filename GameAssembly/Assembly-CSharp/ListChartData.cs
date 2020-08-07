/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ListChartData : ChartDataObject<ListDef, ListChartData> // TypeDefIndex: 11017
{
	// Constructors
	public ListChartData(); // 0x0000000180C583B0-0x0000000180C58410

	// Methods
	public static List<string> GetStringListWithDefID(string inDefID); // 0x0000000180C58340-0x0000000180C583B0
	public static List<string> GetListWithDefID(string inDefID); // 0x0000000180C58100-0x0000000180C581B0
	public static List<T> GetGenericListWithDefID<T>(Func<string, T> inGetDefWithDefIDFunc, string inListDefID)
		where T : BaseDef;
	public static List<string> GetLocalizedStringsFromListWithDefID(string inListDefID); // 0x0000000180C581B0-0x0000000180C58340
}


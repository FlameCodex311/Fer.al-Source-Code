/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ListChartData : ChartDataObject<ListDef, ListChartData> // TypeDefIndex: 13346
{
	// Constructors
	public ListChartData(); // 0x00000001812D26E0-0x00000001812D2740

	// Methods
	public static List<string> GetStringListWithDefID(string inDefID); // 0x00000001812D2670-0x00000001812D26E0
	public static List<string> GetListWithDefID(string inDefID); // 0x00000001812D2430-0x00000001812D24E0
	public static List<T> GetGenericListWithDefID<T>(Func<string, T> inGetDefWithDefIDFunc, string inListDefID)
		where T : BaseDef;
	public static List<string> GetLocalizedStringsFromListWithDefID(string inListDefID); // 0x00000001812D24E0-0x00000001812D2670
}


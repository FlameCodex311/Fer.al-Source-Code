/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LocalizationChartData : ChartDataObject<LocalizationDef, LocalizationChartData> // TypeDefIndex: 13348
{
	// Fields
	public static Dictionary<SystemLanguage, string> systemLanguageToAbbreviationMap; // 0x00
	public static Dictionary<string, SystemLanguage> abbrevationToSystemLanguageMap; // 0x08

	// Constructors
	public LocalizationChartData(); // 0x00000001811E77D0-0x00000001811E7830
	static LocalizationChartData(); // 0x00000001811E75D0-0x00000001811E77D0

	// Methods
	public static SystemLanguage GetCurrentSystemLanguage(); // 0x00000001811E7030-0x00000001811E70D0
	public static string GetLanguageAbbreviation(SystemLanguage inLanguage); // 0x00000001811E70D0-0x00000001811E71F0
	public static string GetCurrentLanguageAbbreviation(); // 0x00000001811E6E40-0x00000001811E7030
	public static SystemLanguage GetSystemLanguageByAbbreviation(string abbreviation); // 0x00000001811E73D0-0x00000001811E74B0
	public static string Format(string inDefID, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] parameters); // 0x00000001811E6DD0-0x00000001811E6E40
	public static string GetString(string inDefID); // 0x00000001811E71F0-0x00000001811E73D0
	public string Get(string inDefID, string inDefault = "-1" /* Metadata: 0x00783B9C */); // 0x00000001811E74B0-0x00000001811E75D0
}


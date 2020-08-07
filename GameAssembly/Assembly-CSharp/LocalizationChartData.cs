/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LocalizationChartData : ChartDataObject<LocalizationDef, LocalizationChartData> // TypeDefIndex: 11019
{
	// Fields
	public static Dictionary<SystemLanguage, string> systemLanguageToAbbreviationMap; // 0x00
	public static Dictionary<string, SystemLanguage> abbrevationToSystemLanguageMap; // 0x08

	// Constructors
	public LocalizationChartData(); // 0x00000001804EE380-0x00000001804EE3E0
	static LocalizationChartData(); // 0x00000001804EE190-0x00000001804EE380

	// Methods
	public static SystemLanguage GetCurrentSystemLanguage(); // 0x00000001804EDBF0-0x00000001804EDC90
	public static string GetLanguageAbbreviation(SystemLanguage inLanguage); // 0x00000001804EDC90-0x00000001804EDDB0
	public static string GetCurrentLanguageAbbreviation(); // 0x00000001804EDA00-0x00000001804EDBF0
	public static SystemLanguage GetSystemLanguageByAbbreviation(string abbreviation); // 0x00000001804EDF90-0x00000001804EE070
	public static string Format(string inDefID, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] parameters); // 0x00000001804ED990-0x00000001804EDA00
	public static string GetString(string inDefID); // 0x00000001804EDDB0-0x00000001804EDF90
	public string Get(string inDefID, string inDefault = "-1" /* Metadata: 0x0077C665 */); // 0x00000001804EE070-0x00000001804EE190
}


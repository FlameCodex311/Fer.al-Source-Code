/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018024B220-0x000000018024B250
public class LocalizationDefComponent : DefComponent // TypeDefIndex: 11731
{
	// Fields
	[ChartBool] // 0x000000018024B3A0-0x000000018024B3E0
	public bool needsTranslation; // 0x18
	[ChartMultiLineString] // 0x000000018024B540-0x000000018024B5A0
	public string en; // 0x20
	[ChartMultiLineString] // 0x000000018024B7F0-0x000000018024B850
	public string fr; // 0x28
	[ChartMultiLineString] // 0x000000018024B940-0x000000018024B9A0
	public string de; // 0x30
	[ChartMultiLineString] // 0x000000018024BC90-0x000000018024BCF0
	public string es; // 0x38
	[ChartMultiLineString] // 0x000000018024BE60-0x000000018024BEC0
	public string pt; // 0x40

	// Properties
	public string LocalizedString { get; } // 0x00000001804EE540-0x00000001804EE5E0 

	// Constructors
	public LocalizationDefComponent(); // 0x00000001804EE4D0-0x00000001804EE540

	// Methods
	[ChartSearch] // 0x000000018024C190-0x000000018024C1C0
	public static bool NeedsTranslationSearch(DefComponent inDefComponent, string inSearch); // 0x00000001804EE420-0x00000001804EE4D0
	public string GetLocalizedStringWithLanguage(SystemLanguage inSystemLanguage); // 0x00000001804EE3E0-0x00000001804EE420
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800B70E0-0x00000001800B7110
public class LocalizationDefComponent : DefComponent // TypeDefIndex: 10240
{
	// Fields
	[ChartBool] // 0x00000001800B7260-0x00000001800B72A0
	public bool needsTranslation; // 0x18
	[ChartMultiLineString] // 0x00000001800B7330-0x00000001800B7390
	public string en; // 0x20
	[ChartMultiLineString] // 0x00000001800B7480-0x00000001800B74E0
	public string fr; // 0x28
	[ChartMultiLineString] // 0x00000001800B7650-0x00000001800B76B0
	public string de; // 0x30
	[ChartMultiLineString] // 0x00000001800B78A0-0x00000001800B7900
	public string es; // 0x38
	[ChartMultiLineString] // 0x00000001800B7AE0-0x00000001800B7B40
	public string pt; // 0x40

	// Properties
	public string LocalizedString { get; } // 0x00000001811E7990-0x00000001811E7A30 

	// Constructors
	public LocalizationDefComponent(); // 0x00000001811E7920-0x00000001811E7990

	// Methods
	[ChartSearch] // 0x00000001800B7E90-0x00000001800B7EC0
	public static bool NeedsTranslationSearch(DefComponent inDefComponent, string inSearch); // 0x00000001811E7870-0x00000001811E7920
	public string GetLocalizedStringWithLanguage(SystemLanguage inSystemLanguage); // 0x00000001811E7830-0x00000001811E7870
}


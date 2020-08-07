/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unitilities.Tuples;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteInEditMode] // 0x000000018026C020-0x000000018026C080
[RequireComponent] // 0x000000018026C020-0x000000018026C080
public class UI_TextThemeApplier : UI_ThemeApplier // TypeDefIndex: 11257
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _textTarget; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _ignoreSizeSettings; // 0x38

	// Properties
	public WWTextMeshProUGUI TextTarget { get; } // 0x00000001804D52D0-0x00000001804D5350 

	// Constructors
	public UI_TextThemeApplier(); // 0x0000000180379B10-0x0000000180379B20

	// Methods
	public override List<StringTuple> GetDataOptions(); // 0x00000001804D5180-0x00000001804D51E0
	public override bool AddThemeDataFromTarget(string inName); // 0x00000001804D4C80-0x00000001804D4D60
	public override bool UpdateThemeDataFromTarget(string inId, string inName); // 0x00000001804D51E0-0x00000001804D52D0
	protected override void ApplyTheme(); // 0x00000001804D4D60-0x00000001804D50F0
	protected override void DereferenceAssets(); // 0x00000001804D50F0-0x00000001804D5180
}


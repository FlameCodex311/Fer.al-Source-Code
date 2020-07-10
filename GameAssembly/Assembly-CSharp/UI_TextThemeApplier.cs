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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteInEditMode] // 0x00000001800D30B0-0x00000001800D3110
[RequireComponent] // 0x00000001800D30B0-0x00000001800D3110
public class UI_TextThemeApplier : UI_ThemeApplier // TypeDefIndex: 13590
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _textTarget; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _ignoreSizeSettings; // 0x38

	// Properties
	public WWTextMeshProUGUI TextTarget { get; } // 0x0000000180F946C0-0x0000000180F94740 

	// Constructors
	public UI_TextThemeApplier(); // 0x0000000180F94670-0x0000000180F946C0

	// Methods
	public override List<StringTuple> GetDataOptions(); // 0x0000000180F944D0-0x0000000180F94580
	public override bool AddThemeDataFromTarget(string inName); // 0x0000000180F93F20-0x0000000180F94000
	public override bool UpdateThemeDataFromTarget(string inId, string inName); // 0x0000000180F94580-0x0000000180F94670
	protected override void ApplyTheme(); // 0x0000000180F94000-0x0000000180F94440
	protected override void DereferenceAssets(); // 0x0000000180F94440-0x0000000180F944D0
}


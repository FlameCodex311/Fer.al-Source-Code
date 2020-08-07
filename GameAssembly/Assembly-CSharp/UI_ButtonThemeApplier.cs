/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteInEditMode] // 0x0000000180268B30-0x0000000180268B90
[RequireComponent] // 0x0000000180268B30-0x0000000180268B90
public class UI_ButtonThemeApplier : UI_ThemeApplier // TypeDefIndex: 11253
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _buttonTarget; // 0x30

	// Properties
	public WWButton ButtonTarget { get; } // 0x000000018051ECA0-0x000000018051ED20 

	// Constructors
	public UI_ButtonThemeApplier(); // 0x000000018051EC90-0x000000018051ECA0

	// Methods
	public override List<StringTuple> GetDataOptions(); // 0x000000018051EB40-0x000000018051EBA0
	public override bool AddThemeDataFromTarget(string inName); // 0x000000018051E800-0x000000018051E8E0
	public override bool UpdateThemeDataFromTarget(string inId, string inName); // 0x000000018051EBA0-0x000000018051EC90
	protected override void ApplyTheme(); // 0x000000018051E8E0-0x000000018051EAB0
	protected override void DereferenceAssets(); // 0x000000018051EAB0-0x000000018051EB40
}


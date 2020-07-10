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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteInEditMode] // 0x00000001800CE420-0x00000001800CE480
[RequireComponent] // 0x00000001800CE420-0x00000001800CE480
public class UI_ButtonThemeApplier : UI_ThemeApplier // TypeDefIndex: 13586
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _buttonTarget; // 0x30

	// Properties
	public WWButton ButtonTarget { get; } // 0x0000000180FB9E30-0x0000000180FB9EB0 

	// Constructors
	public UI_ButtonThemeApplier(); // 0x0000000180FB9E20-0x0000000180FB9E30

	// Methods
	public override List<StringTuple> GetDataOptions(); // 0x0000000180FB9CD0-0x0000000180FB9D30
	public override bool AddThemeDataFromTarget(string inName); // 0x0000000180FB9980-0x0000000180FB9A60
	public override bool UpdateThemeDataFromTarget(string inId, string inName); // 0x0000000180FB9D30-0x0000000180FB9E20
	protected override void ApplyTheme(); // 0x0000000180FB9A60-0x0000000180FB9C40
	protected override void DereferenceAssets(); // 0x0000000180FB9C40-0x0000000180FB9CD0
}


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

[ExecuteAlways] // 0x0000000180269CA0-0x0000000180269D00
[RequireComponent] // 0x0000000180269CA0-0x0000000180269D00
public class UI_ImageThemeApplier : UI_ThemeApplier // TypeDefIndex: 11255
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _imageTarget; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _ignoreFillAmount; // 0x38

	// Properties
	public WWImage ImageTarget { get; } // 0x0000000180379B30-0x0000000180379BB0 
	public bool IgnoreFillAmount { get; } // 0x0000000180379B20-0x0000000180379B30 

	// Constructors
	public UI_ImageThemeApplier(); // 0x0000000180379B10-0x0000000180379B20

	// Methods
	public override List<StringTuple> GetDataOptions(); // 0x00000001803799C0-0x0000000180379A20
	public override bool AddThemeDataFromTarget(string inId); // 0x0000000180379580-0x0000000180379660
	public override bool UpdateThemeDataFromTarget(string inId, string inName); // 0x0000000180379A20-0x0000000180379B10
	protected override void ApplyTheme(); // 0x0000000180379660-0x0000000180379920
	protected override void DereferenceAssets(); // 0x0000000180379920-0x00000001803799C0
}


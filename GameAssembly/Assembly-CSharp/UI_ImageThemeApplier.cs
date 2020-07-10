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

[ExecuteAlways] // 0x00000001800D0310-0x00000001800D0370
[RequireComponent] // 0x00000001800D0310-0x00000001800D0370
public class UI_ImageThemeApplier : UI_ThemeApplier // TypeDefIndex: 13588
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _imageTarget; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _ignoreFillAmount; // 0x38

	// Properties
	public WWImage ImageTarget { get; } // 0x0000000180E42360-0x0000000180E423E0 
	public bool IgnoreFillAmount { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 

	// Constructors
	public UI_ImageThemeApplier(); // 0x0000000180E42350-0x0000000180E42360

	// Methods
	public override List<StringTuple> GetDataOptions(); // 0x0000000180E42200-0x0000000180E42260
	public override bool AddThemeDataFromTarget(string inId); // 0x0000000180E41DB0-0x0000000180E41E90
	public override bool UpdateThemeDataFromTarget(string inId, string inName); // 0x0000000180E42260-0x0000000180E42350
	protected override void ApplyTheme(); // 0x0000000180E41E90-0x0000000180E42160
	protected override void DereferenceAssets(); // 0x0000000180E42160-0x0000000180E42200
}


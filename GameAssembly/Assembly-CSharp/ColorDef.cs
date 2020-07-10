/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ColorDef : BaseDef // TypeDefIndex: 10113
{
	// Fields
	private string _primaryColorString; // 0x50
	private Color? _primaryColorColor; // 0x58
	private string _bodySecondaryColorString; // 0x70
	private Color? _bodySecondaryColorColor; // 0x78
	private string _eyeSecondaryColorString; // 0x90
	private Color? _eyeSecondaryColorColor; // 0x98

	// Properties
	public Color primaryColor { get; } // 0x00000001814701E0-0x0000000181470290 
	public Color bodySecondaryColor { get; } // 0x0000000181470060-0x0000000181470120 
	public Color eyeSecondaryColor { get; } // 0x0000000181470120-0x00000001814701E0 

	// Constructors
	public ColorDef(); // 0x000000018146FFC0-0x0000000181470060

	// Methods
	public override void LoadEntry(); // 0x000000018146FF30-0x000000018146FFC0
}


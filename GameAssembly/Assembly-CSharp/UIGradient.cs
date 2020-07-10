/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x00000001800C29A0-0x00000001800C29D0
public class UIGradient : BaseMeshEffect // TypeDefIndex: 12011
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color m_color1; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color m_color2; // 0x30
	[Range] // 0x00000001800C2E10-0x00000001800C2E50
	[SerializeField] // 0x00000001800C2E10-0x00000001800C2E50
	private float m_angle; // 0x40
	public bool m_ignoreRatio; // 0x44

	// Properties
	public Color Color1 { get; set; } // 0x0000000180CC6480-0x0000000180CC6490 0x0000000180FB4350-0x0000000180FB43D0
	public Color Color2 { get; set; } // 0x000000018038E0C0-0x000000018038E0D0 0x0000000180FB43D0-0x0000000180FB4450
	public float Angle { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000180FB4300-0x0000000180FB4350

	// Constructors
	public UIGradient(); // 0x0000000180FB42B0-0x0000000180FB4300

	// Methods
	public override void ModifyMesh(VertexHelper vh); // 0x0000000180FB3E10-0x0000000180FB42B0
}


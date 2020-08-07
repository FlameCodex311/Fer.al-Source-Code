/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x0000000180267340-0x0000000180267370
public class UIGradient : BaseMeshEffect // TypeDefIndex: 13557
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color m_color1; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color m_color2; // 0x30
	[Range] // 0x0000000180267630-0x0000000180267670
	[SerializeField] // 0x0000000180267630-0x0000000180267670
	private float m_angle; // 0x40
	public bool m_ignoreRatio; // 0x44

	// Properties
	public Color Color1 { get; set; } // 0x00000001804A4210-0x00000001804A4220 0x00000001805192E0-0x0000000180519360
	public Color Color2 { get; set; } // 0x000000018043C660-0x000000018043C670 0x0000000180519360-0x00000001805193E0
	public float Angle { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x0000000180519290-0x00000001805192E0

	// Constructors
	public UIGradient(); // 0x0000000180519240-0x0000000180519290

	// Methods
	public override void ModifyMesh(VertexHelper vh); // 0x0000000180518DB0-0x0000000180519240
}


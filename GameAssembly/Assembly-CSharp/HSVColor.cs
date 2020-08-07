/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public struct HSVColor : ISerializationCallbackReceiver // TypeDefIndex: 11346
{
	// Fields
	private bool _colorIsConverted; // 0x00
	private Color _color; // 0x04
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _h; // 0x18
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _s; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _v; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _hsv; // 0x30

	// Properties
	public Color Color { get; } // 0x000000018000AC00-0x000000018000AC90 
	private string HSV { get; } // 0x000000018000AC90-0x000000018000ACE0 
	public float H { get; set; } // 0x000000018000ACE0-0x000000018000ACF0 0x000000018000AD10-0x000000018000AEA0
	public float S { get; set; } // 0x000000018000ACF0-0x000000018000AD00 0x000000018000AEA0-0x000000018000B040
	public float V { get; set; } // 0x000000018000AD00-0x000000018000AD10 0x000000018000B040-0x000000018000B2F0

	// Constructors
	public HSVColor(HSVColor inColor); // 0x000000018000A980-0x000000018000AA40
	public HSVColor(float h, float s, float v); // 0x000000018000AA40-0x000000018000AA50
	public HSVColor(Color rgbColor); // 0x000000018000AA50-0x000000018000AC00

	// Methods
	private void ConvertToNewFormat(); // 0x000000018000A6B0-0x000000018000A700
	public override bool Equals(object obj); // 0x000000018000A700-0x000000018000A890
	public static bool operator ==(HSVColor a, HSVColor b); // 0x0000000180687CC0-0x0000000180687D70
	public static bool operator !=(HSVColor a, HSVColor b); // 0x0000000180687D70-0x0000000180687E20
	public override int GetHashCode(); // 0x000000018000A890-0x000000018000A8F0
	public Vector4 ToVector4(); // 0x000000018000A8F0-0x000000018000A980
	public static HSVColor Random(); // 0x0000000180687430-0x0000000180687CC0
	public static HSVColor RandomDark(); // 0x00000001806873A0-0x0000000180687430
	public void OnBeforeSerialize(); // 0x0000000180003FD0-0x00000001800045A0
	public void OnAfterDeserialize(); // 0x0000000180003FD0-0x00000001800045A0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public struct HSVColor : ISerializationCallbackReceiver // TypeDefIndex: 13679
{
	// Fields
	private bool _colorIsConverted; // 0x00
	private Color _color; // 0x04
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _h; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _s; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _v; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _hsv; // 0x30

	// Properties
	public Color Color { get; } // 0x00000001801F8B70-0x00000001801F8C00 
	private string HSV { get; } // 0x00000001801F8C00-0x00000001801F8C50 
	public float H { get; set; } // 0x00000001801F8C50-0x00000001801F8C60 0x00000001801F8C80-0x00000001801F8C90
	public float S { get; set; } // 0x00000001801F8C60-0x00000001801F8C70 0x00000001801F8C90-0x00000001801F8E40
	public float V { get; set; } // 0x00000001801F8C70-0x00000001801F8C80 0x00000001801F8E40-0x00000001801F8F60

	// Constructors
	public HSVColor(HSVColor inColor); // 0x00000001801F88F0-0x00000001801F89B0
	public HSVColor(float h, float s, float v); // 0x00000001801F89B0-0x00000001801F89C0
	public HSVColor(Color rgbColor); // 0x00000001801F89C0-0x00000001801F8B70

	// Methods
	private void ConvertToNewFormat(); // 0x00000001801F8620-0x00000001801F8670
	public override bool Equals(object obj); // 0x00000001801F8670-0x00000001801F8800
	public static bool operator ==(HSVColor a, HSVColor b); // 0x000000018105C6A0-0x000000018105C750
	public static bool operator !=(HSVColor a, HSVColor b); // 0x000000018105C750-0x000000018105CB50
	public override int GetHashCode(); // 0x00000001801F8800-0x00000001801F8860
	public Vector4 ToVector4(); // 0x00000001801F8860-0x00000001801F88F0
	public static HSVColor Random(); // 0x000000018105BDE0-0x000000018105C6A0
	public static HSVColor RandomDark(); // 0x000000018105BD50-0x000000018105BDE0
	public void OnBeforeSerialize(); // 0x0000000180003310-0x0000000180003870
	public void OnAfterDeserialize(); // 0x0000000180003310-0x0000000180003870
}


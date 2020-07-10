/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x000000018015ADE0-0x000000018015AE10
public class SanctuaryLightDefComponent : DefComponent // TypeDefIndex: 10140
{
	// Fields
	[ChartColor] // 0x00000001800B5960-0x00000001800B5970
	public Color color; // 0x18
	[ChartMinMax] // 0x000000018015B1D0-0x000000018015B210
	[SerializeField] // 0x000000018015B1D0-0x000000018015B210
	private Vector2 _minMaxBrightness; // 0x28
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isBlank; // 0x30
	public const string DEFID_DEFAULT_EXTERIOR = "12553"; // Metadata: 0x00746AA3
	public const string DEFID_DEFAULT_INTERIOR = "12555"; // Metadata: 0x00746AAC

	// Properties
	public float MinBrightness { get; } // 0x0000000180487D50-0x0000000180487D60 
	public float MaxBrightness { get; } // 0x0000000180487D70-0x0000000180487D80 

	// Constructors
	public SanctuaryLightDefComponent(); // 0x0000000181362760-0x00000001813627B0
}


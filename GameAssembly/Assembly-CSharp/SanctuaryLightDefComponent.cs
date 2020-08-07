/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180232CC0-0x0000000180232CF0
public class SanctuaryLightDefComponent : DefComponent // TypeDefIndex: 11631
{
	// Fields
	[ChartColor] // 0x00000001801DE450-0x00000001801DE460
	public Color color; // 0x18
	[ChartMinMax] // 0x0000000180233150-0x0000000180233190
	[SerializeField] // 0x0000000180233150-0x0000000180233190
	private Vector2 _minMaxBrightness; // 0x28
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isBlank; // 0x30
	public const string DEFID_DEFAULT_EXTERIOR = "12553"; // Metadata: 0x0077CEC9
	public const string DEFID_DEFAULT_INTERIOR = "12555"; // Metadata: 0x0077CED2

	// Properties
	public float MinBrightness { get; } // 0x0000000180491DA0-0x0000000180491DB0 
	public float MaxBrightness { get; } // 0x00000001807DDA30-0x00000001807DDA40 

	// Constructors
	public SanctuaryLightDefComponent(); // 0x0000000180BEAFD0-0x0000000180BEB020
}


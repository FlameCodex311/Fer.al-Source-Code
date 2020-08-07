/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FX_ColorizePerSurface : ManagedBehaviour // TypeDefIndex: 11922
{
	// Fields
	private ParticleSystem _currentParticleSystem; // 0x50
	private Color? _surfaceColor; // 0x58
	private Color? _initialColor; // 0x6C
	public ColorModeType colorMode; // 0x80

	// Properties
	public ParticleSystem currentParticleSystem { get; } // 0x0000000180861F10-0x0000000180861F90 

	// Nested types
	[Serializable]
	public enum ColorModeType // TypeDefIndex: 11923
	{
		StartColor = 0,
		TrailsColorOverLifetime = 10
	}

	// Constructors
	public FX_ColorizePerSurface(); // 0x0000000180861EB0-0x0000000180861F10

	// Methods
	public override void MStart(); // 0x0000000180861DB0-0x0000000180861EB0
	public void Colorize(Color? inColor); // 0x0000000180861CC0-0x0000000180861DB0
}


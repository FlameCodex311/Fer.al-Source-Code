/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FX_ColorizePerSurface : ManagedBehaviour // TypeDefIndex: 10445
{
	// Fields
	private ParticleSystem _currentParticleSystem; // 0x50
	private Color? _surfaceColor; // 0x58
	private Color? _initialColor; // 0x6C
	public ColorModeType colorMode; // 0x80

	// Properties
	public ParticleSystem currentParticleSystem { get; } // 0x0000000181194DC0-0x0000000181194E40 

	// Nested types
	[Serializable]
	public enum ColorModeType // TypeDefIndex: 10446
	{
		StartColor = 0,
		TrailsColorOverLifetime = 10
	}

	// Constructors
	public FX_ColorizePerSurface(); // 0x0000000181194D60-0x0000000181194DC0

	// Methods
	public override void MStart(); // 0x0000000181194C60-0x0000000181194D60
	public void Colorize(Color? inColor); // 0x0000000181194B70-0x0000000181194C60
}


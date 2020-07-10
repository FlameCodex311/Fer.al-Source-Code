/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FX_ConformColorsToActorShader : ManagedBehaviour // TypeDefIndex: 12768
{
	// Fields
	public Renderer sourceRenderer; // 0x50
	public int colorID; // 0x58
	public ColorModeType colorMode; // 0x5C
	private string _colorIDProperty; // 0x60
	private ParticleSystem _currentParticleSystem; // 0x68
	private float _timer; // 0x70
	private Vector4? _lastColor; // 0x74

	// Properties
	private string ColorIDProperty { get; } // 0x0000000181195700-0x0000000181195770 
	public ParticleSystem CurrentParticleSystem { get; } // 0x0000000181195770-0x00000001811957F0 

	// Nested types
	[Serializable]
	public enum ColorModeType // TypeDefIndex: 12769
	{
		StartColor = 0,
		TrailsColorOverLifetime = 10
	}

	// Constructors
	public FX_ConformColorsToActorShader(); // 0x00000001811956A0-0x0000000181195700

	// Methods
	public override void MStart(); // 0x0000000181195640-0x0000000181195650
	public override void MUpdate(); // 0x0000000181195650-0x00000001811956A0
	public void ApplyColors(); // 0x0000000181194E40-0x0000000181195640
}


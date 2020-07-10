/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[AddComponentMenu] // 0x000000018010DA50-0x000000018010DA90
[ExecuteInEditMode] // 0x000000018010DA50-0x000000018010DA90
public class VA_AudioSource : MonoBehaviour // TypeDefIndex: 13248
{
	// Fields
	[Tooltip] // 0x000000018010DDC0-0x000000018010DDF0
	public bool Compound; // 0x20
	[Tooltip] // 0x000000018010DFC0-0x000000018010DFF0
	public VA_Shape Shape; // 0x28
	[Tooltip] // 0x000000018010E170-0x000000018010E1A0
	public List<VA_Shape> Shapes; // 0x30
	[Tooltip] // 0x000000018010E3C0-0x000000018010E3F0
	public VA_VolumetricShape ExcludedShape; // 0x38
	[Tooltip] // 0x000000018010E5C0-0x000000018010E5F0
	public List<VA_VolumetricShape> ExcludedShapes; // 0x40
	[Tooltip] // 0x000000018010E820-0x000000018010E850
	public bool Blend; // 0x48
	[Tooltip] // 0x000000018010EA20-0x000000018010EA50
	public float BlendMinDistance; // 0x4C
	[Tooltip] // 0x000000018010EC70-0x000000018010ECA0
	public float BlendMaxDistance; // 0x50
	[Tooltip] // 0x000000018010ED60-0x000000018010ED90
	public AnimationCurve BlendCurve; // 0x58
	[Tooltip] // 0x000000018010EE70-0x000000018010EEA0
	public bool Volume; // 0x60
	[Tooltip] // 0x000000018010EFF0-0x000000018010F020
	public float VolumeMinDistance; // 0x64
	[Tooltip] // 0x000000018010F210-0x000000018010F240
	public float VolumeMaxDistance; // 0x68
	[Tooltip] // 0x000000018010F380-0x000000018010F3B0
	public AnimationCurve VolumeCurve; // 0x70
	private FeralAudioEmitter _feralAudioEmitter; // 0x78
	private AudioSource _audioSource; // 0x80

	// Properties
	public bool HasVolumetricShape { get; } // 0x0000000181221B70-0x0000000181221EA0 

	// Constructors
	public VA_AudioSource(); // 0x00000001812218C0-0x0000000181221B70

	// Methods
	private void SetAudioSourceAndPosition(); // 0x0000000181221400-0x0000000181221600
	private void LateUpdate(); // 0x0000000181220FB0-0x0000000181221400
	protected virtual void SetPanLevel(float newPanLevel); // 0x0000000181221600-0x00000001812216A0
	protected virtual void SetVolume(float newVolume); // 0x00000001812216A0-0x0000000181221740
	private void UpdateShapes(); // 0x0000000181221740-0x00000001812218C0
}


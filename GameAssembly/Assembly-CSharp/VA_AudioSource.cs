/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[AddComponentMenu] // 0x00000001801E5330-0x00000001801E5370
[ExecuteInEditMode] // 0x00000001801E5330-0x00000001801E5370
public class VA_AudioSource : MonoBehaviour // TypeDefIndex: 10914
{
	// Fields
	[Tooltip] // 0x00000001801E5740-0x00000001801E5770
	public bool Compound; // 0x20
	[Tooltip] // 0x00000001801E59D0-0x00000001801E5A00
	public VA_Shape Shape; // 0x28
	[Tooltip] // 0x00000001801E5BB0-0x00000001801E5BE0
	public List<VA_Shape> Shapes; // 0x30
	[Tooltip] // 0x00000001801E5D80-0x00000001801E5DB0
	public VA_VolumetricShape ExcludedShape; // 0x38
	[Tooltip] // 0x00000001801E60B0-0x00000001801E60E0
	public List<VA_VolumetricShape> ExcludedShapes; // 0x40
	[Tooltip] // 0x00000001801E6360-0x00000001801E6390
	public bool Blend; // 0x48
	[Tooltip] // 0x00000001801E6610-0x00000001801E6640
	public float BlendMinDistance; // 0x4C
	[Tooltip] // 0x00000001801E6750-0x00000001801E6780
	public float BlendMaxDistance; // 0x50
	[Tooltip] // 0x00000001801E6AF0-0x00000001801E6B20
	public AnimationCurve BlendCurve; // 0x58
	[Tooltip] // 0x00000001801E6CF0-0x00000001801E6D20
	public bool Volume; // 0x60
	[Tooltip] // 0x00000001801E7090-0x00000001801E70C0
	public float VolumeMinDistance; // 0x64
	[Tooltip] // 0x00000001801E7360-0x00000001801E7390
	public float VolumeMaxDistance; // 0x68
	[Tooltip] // 0x00000001801E74F0-0x00000001801E7520
	public AnimationCurve VolumeCurve; // 0x70
	private FeralAudioEmitter _feralAudioEmitter; // 0x78
	private AudioSource _audioSource; // 0x80

	// Properties
	public bool HasVolumetricShape { get; } // 0x000000018066D950-0x000000018066DC70 

	// Constructors
	public VA_AudioSource(); // 0x000000018066D6B0-0x000000018066D950

	// Methods
	private void SetAudioSourceAndPosition(); // 0x000000018066D1F0-0x000000018066D3F0
	private void LateUpdate(); // 0x000000018066CDB0-0x000000018066D1F0
	protected virtual void SetPanLevel(float newPanLevel); // 0x000000018066D3F0-0x000000018066D490
	protected virtual void SetVolume(float newVolume); // 0x000000018066D490-0x000000018066D530
	private void UpdateShapes(); // 0x000000018066D530-0x000000018066D6B0
}


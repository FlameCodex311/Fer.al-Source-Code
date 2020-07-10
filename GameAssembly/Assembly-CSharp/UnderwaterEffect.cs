/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteInEditMode] // 0x00000001800B4050-0x00000001800B4080
[ImageEffectAllowedInSceneView] // 0x00000001800B4050-0x00000001800B4080
public class UnderwaterEffect : MonoBehaviour // TypeDefIndex: 13773
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Material _mat; // 0x20
	[Range] // 0x0000000180108BE0-0x0000000180108C20
	[SerializeField] // 0x0000000180108BE0-0x0000000180108C20
	private float _pixelOffset; // 0x28
	[Range] // 0x0000000180108E40-0x0000000180108E80
	[SerializeField] // 0x0000000180108E40-0x0000000180108E80
	private float _noiseScale; // 0x2C
	[Range] // 0x0000000180108E40-0x0000000180108E80
	[SerializeField] // 0x0000000180108E40-0x0000000180108E80
	private float _noiseFrequency; // 0x30
	[Range] // 0x000000018010A540-0x000000018010A580
	[SerializeField] // 0x000000018010A540-0x000000018010A580
	private float _noiseSpeed; // 0x34
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _depthStart; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _depthDistance; // 0x3C

	// Constructors
	public UnderwaterEffect(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Update(); // 0x0000000180F89690-0x0000000180F897A0
	private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x0000000180F89610-0x0000000180F89690
}


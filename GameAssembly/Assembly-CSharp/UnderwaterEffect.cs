/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteInEditMode] // 0x00000001801CDDD0-0x00000001801CDE00
[ImageEffectAllowedInSceneView] // 0x00000001801CDDD0-0x00000001801CDE00
public class UnderwaterEffect : MonoBehaviour // TypeDefIndex: 11446
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Material _mat; // 0x20
	[Range] // 0x00000001801E33D0-0x00000001801E3410
	[SerializeField] // 0x00000001801E33D0-0x00000001801E3410
	private float _pixelOffset; // 0x28
	[Range] // 0x00000001801E3650-0x00000001801E3690
	[SerializeField] // 0x00000001801E3650-0x00000001801E3690
	private float _noiseScale; // 0x2C
	[Range] // 0x00000001801E3650-0x00000001801E3690
	[SerializeField] // 0x00000001801E3650-0x00000001801E3690
	private float _noiseFrequency; // 0x30
	[Range] // 0x00000001801E3B80-0x00000001801E3BC0
	[SerializeField] // 0x00000001801E3B80-0x00000001801E3BC0
	private float _noiseSpeed; // 0x34
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _depthStart; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _depthDistance; // 0x3C

	// Constructors
	public UnderwaterEffect(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Update(); // 0x0000000180455520-0x0000000180455630
	private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x00000001804554A0-0x0000000180455520
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
public class FogEffect : MonoBehaviour // TypeDefIndex: 11444
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Material _mat; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _fogColor; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _depthStart; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _depthDistance; // 0x3C

	// Constructors
	public FogEffect(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001806A1090-0x00000001806A10F0
	private void Update(); // 0x00000001806A10F0-0x00000001806A1190
	private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x00000001806A1010-0x00000001806A1090
}


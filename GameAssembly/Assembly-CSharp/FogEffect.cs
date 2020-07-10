/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
public class FogEffect : MonoBehaviour // TypeDefIndex: 13771
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Material _mat; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _fogColor; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _depthStart; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _depthDistance; // 0x3C

	// Constructors
	public FogEffect(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x000000018110B110-0x000000018110B170
	private void Update(); // 0x000000018110B170-0x000000018110B210
	private void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x000000018110B090-0x000000018110B110
}


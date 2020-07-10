/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteInEditMode] // 0x00000001800B36B0-0x00000001800B36C0
public class FakeAmbientLight : MonoBehaviour // TypeDefIndex: 10438
{
	// Fields
	public static FakeAmbientLight instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _ambientColor; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _shadowColor; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Light _lightComponent; // 0x40
	private Color _lastShadowColor; // 0x48
	private Color _lastAmbientColor; // 0x58

	// Properties
	private Light LightComponent { get; } // 0x0000000181490800-0x0000000181490880 

	// Constructors
	public FakeAmbientLight(); // 0x0000000181490760-0x0000000181490800

	// Methods
	private void SetupLightComponent(); // 0x0000000181490550-0x0000000181490740
	private void SetupGlobalShadowColor(); // 0x00000001814904D0-0x0000000181490550
	private void SetupGlobalAmbientColor(); // 0x0000000181490450-0x00000001814904D0
	private void Awake(); // 0x0000000181490380-0x00000001814903B0
	private void OnEnable(); // 0x0000000181490400-0x0000000181490450
	private void OnDisable(); // 0x00000001814903B0-0x0000000181490400
	private void Update(); // 0x0000000181490740-0x0000000181490760
	public Color GetFinalAmbientColor(); // 0x0000000180CC6480-0x0000000180CC6490
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ExecuteInEditMode] // 0x00000001801CDAD0-0x00000001801CDAE0
public class FakeAmbientLight : MonoBehaviour // TypeDefIndex: 11948
{
	// Fields
	public static FakeAmbientLight instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _ambientColor; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _shadowColor; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Light _lightComponent; // 0x40
	private Color _lastShadowColor; // 0x48
	private Color _lastAmbientColor; // 0x58

	// Properties
	private Light LightComponent { get; } // 0x00000001808681A0-0x0000000180868220 

	// Constructors
	public FakeAmbientLight(); // 0x0000000180868100-0x00000001808681A0

	// Methods
	private void SetupLightComponent(); // 0x0000000180867EF0-0x00000001808680E0
	private void SetupGlobalShadowColor(); // 0x0000000180867E70-0x0000000180867EF0
	private void SetupGlobalAmbientColor(); // 0x0000000180867DF0-0x0000000180867E70
	private void Awake(); // 0x0000000180867D20-0x0000000180867D50
	private void OnEnable(); // 0x0000000180867DA0-0x0000000180867DF0
	private void OnDisable(); // 0x0000000180867D50-0x0000000180867DA0
	private void Update(); // 0x00000001808680E0-0x0000000180868100
	public Color GetFinalAmbientColor(); // 0x00000001804A4210-0x00000001804A4220
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FX_P_Ember_Script : MonoBehaviour // TypeDefIndex: 12772
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _emberSize; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private OnVariableChangeDelegate OnVariableChange; // 0x28

	// Properties
	public float EmberSize { get; set; } // 0x0000000180487DA0-0x0000000180487DB0 0x00000001811961A0-0x00000001811961D0

	// Events
	public event OnVariableChangeDelegate OnVariableChange {
		add; // 0x00000001811961D0-0x0000000181196270
		remove; // 0x0000000181196270-0x0000000181196310
	}

	// Nested types
	public delegate void OnVariableChangeDelegate(float newVal); // TypeDefIndex: 12773; 0x0000000180480520-0x00000001804807C0

	// Constructors
	public FX_P_Ember_Script(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000181195E70-0x0000000181195F80
	public void VariableChangeHandler(float newVal); // 0x00000001811961A0-0x00000001811961D0
	private void Update(); // 0x0000000181195F80-0x00000001811961A0
}


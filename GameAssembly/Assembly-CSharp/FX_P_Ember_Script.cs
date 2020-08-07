/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FX_P_Ember_Script : MonoBehaviour // TypeDefIndex: 10430
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _emberSize; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private OnVariableChangeDelegate OnVariableChange; // 0x28

	// Properties
	public float EmberSize { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x00000001808634C0-0x00000001808634F0

	// Events
	public event OnVariableChangeDelegate OnVariableChange {
		add; // 0x00000001808634F0-0x0000000180863590
		remove; // 0x0000000180863590-0x0000000180863630
	}

	// Nested types
	public delegate void OnVariableChangeDelegate(float newVal); // TypeDefIndex: 10431; 0x0000000180869B60-0x0000000180869E50

	// Constructors
	public FX_P_Ember_Script(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001808631A0-0x00000001808632B0
	public void VariableChangeHandler(float newVal); // 0x00000001808634C0-0x00000001808634F0
	private void Update(); // 0x00000001808632B0-0x00000001808634C0
}


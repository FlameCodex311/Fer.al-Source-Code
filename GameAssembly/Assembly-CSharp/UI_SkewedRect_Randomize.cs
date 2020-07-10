/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SkewedRect_Randomize : MonoBehaviour // TypeDefIndex: 12356
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _rectangle; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxDistance; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _randomizeOnEnable; // 0x2C
	public Action OnRandomized; // 0x30

	// Properties
	public bool RandomizeOnEnable { get; } // 0x0000000180EF5140-0x0000000180EF5150 

	// Constructors
	public UI_SkewedRect_Randomize(); // 0x0000000180EF5130-0x0000000180EF5140

	// Methods
	[DeMethodButton] // 0x000000018014C2E0-0x000000018014C340
	public void Randomize(); // 0x0000000180EF4D10-0x0000000180EF50F0
	private void OnEnable(); // 0x0000000180EF4D00-0x0000000180EF4D10
	private void Reset(); // 0x0000000180EF50F0-0x0000000180EF5130
}


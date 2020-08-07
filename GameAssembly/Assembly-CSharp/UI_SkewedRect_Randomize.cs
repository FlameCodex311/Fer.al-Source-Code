/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SkewedRect_Randomize : MonoBehaviour // TypeDefIndex: 13941
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _rectangle; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxDistance; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _randomizeOnEnable; // 0x2C
	public Action OnRandomized; // 0x30

	// Properties
	public bool RandomizeOnEnable { get; } // 0x00000001804CA280-0x00000001804CA290 

	// Constructors
	public UI_SkewedRect_Randomize(); // 0x00000001804CA270-0x00000001804CA280

	// Methods
	[DeMethodButton] // 0x0000000180245790-0x00000001802457F0
	public void Randomize(); // 0x00000001804C9E70-0x00000001804CA230
	private void OnEnable(); // 0x00000001804C9E60-0x00000001804C9E70
	private void Reset(); // 0x00000001804CA230-0x00000001804CA270
}


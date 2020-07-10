/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MaterialFlicker : ManagedBehaviour // TypeDefIndex: 10647
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject[] _objects; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _colorName; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _shaderName; // 0x60
	[ColorUsage] // 0x000000018015DD30-0x000000018015DD60
	[SerializeField] // 0x000000018015DD30-0x000000018015DD60
	private Color _startingColor; // 0x68
	[Range] // 0x000000018015DFC0-0x000000018015E000
	[SerializeField] // 0x000000018015DFC0-0x000000018015E000
	private float _startingRandomTimeMin; // 0x78
	[Range] // 0x000000018015DFC0-0x000000018015E000
	[SerializeField] // 0x000000018015DFC0-0x000000018015E000
	private float _startingRandomTimeMax; // 0x7C
	[ColorUsage] // 0x000000018015DD30-0x000000018015DD60
	[SerializeField] // 0x000000018015DD30-0x000000018015DD60
	private Color _flickerColor; // 0x80
	[Range] // 0x000000018015DFC0-0x000000018015E000
	[SerializeField] // 0x000000018015DFC0-0x000000018015E000
	private float _flickerRandomTimeMin; // 0x90
	[Range] // 0x000000018015DFC0-0x000000018015E000
	[SerializeField] // 0x000000018015DFC0-0x000000018015E000
	private float _flickerRandomTimeMax; // 0x94
	private List<GameObject> _splitObjects; // 0x98
	private List<Material> _flickerMaterials; // 0xA0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateFlicker>d__12 : IEnumerator<object> // TypeDefIndex: 10648
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MaterialFlicker <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateFlicker>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BDAD0-0x00000001810BDDC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BDDC0-0x00000001810BDE10
	}

	// Constructors
	public MaterialFlicker(); // 0x00000001810AE920-0x00000001810AEA60

	// Methods
	public override void MStart(); // 0x00000001810AE560-0x00000001810AE7E0
	[IteratorStateMachine] // 0x000000018015EC50-0x000000018015ECA0
	private IEnumerator UpdateFlicker(); // 0x00000001810AE8C0-0x00000001810AE920
	private void UpdateColor(Color inColor); // 0x00000001810AE7E0-0x00000001810AE8C0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MaterialFlicker : ManagedBehaviour // TypeDefIndex: 12150
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject[] _objects; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _colorName; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _shaderName; // 0x60
	[ColorUsage] // 0x000000018023E250-0x000000018023E280
	[SerializeField] // 0x000000018023E250-0x000000018023E280
	private Color _startingColor; // 0x68
	[Range] // 0x000000018023E460-0x000000018023E4A0
	[SerializeField] // 0x000000018023E460-0x000000018023E4A0
	private float _startingRandomTimeMin; // 0x78
	[Range] // 0x000000018023E460-0x000000018023E4A0
	[SerializeField] // 0x000000018023E460-0x000000018023E4A0
	private float _startingRandomTimeMax; // 0x7C
	[ColorUsage] // 0x000000018023E250-0x000000018023E280
	[SerializeField] // 0x000000018023E250-0x000000018023E280
	private Color _flickerColor; // 0x80
	[Range] // 0x000000018023E460-0x000000018023E4A0
	[SerializeField] // 0x000000018023E460-0x000000018023E4A0
	private float _flickerRandomTimeMin; // 0x90
	[Range] // 0x000000018023E460-0x000000018023E4A0
	[SerializeField] // 0x000000018023E460-0x000000018023E4A0
	private float _flickerRandomTimeMax; // 0x94
	private List<GameObject> _splitObjects; // 0x98
	private List<Material> _flickerMaterials; // 0xA0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateFlicker>d__12 : IEnumerator<object> // TypeDefIndex: 12151
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MaterialFlicker <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateFlicker>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807F1570-0x00000001807F1840
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807F1840-0x00000001807F1890
	}

	// Constructors
	public MaterialFlicker(); // 0x00000001807EAFA0-0x00000001807EC1F0

	// Methods
	public override void MStart(); // 0x00000001807EAC00-0x00000001807EAE60
	[IteratorStateMachine] // 0x000000018023EEC0-0x000000018023EF10
	private IEnumerator UpdateFlicker(); // 0x00000001807EAF40-0x00000001807EAFA0
	private void UpdateColor(Color inColor); // 0x00000001807EAE60-0x00000001807EAF40
}


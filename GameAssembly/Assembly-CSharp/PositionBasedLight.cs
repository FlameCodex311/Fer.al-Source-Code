/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BeautifyEffect;
using DG.Tweening.Core;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PositionBasedLight : ManagedBehaviour // TypeDefIndex: 14259
{
	// Fields
	public Light keyLight; // 0x50
	public Color topColor; // 0x58
	public Color bottomColor; // 0x68
	public float topLightIntensity; // 0x78
	public float bottomLightIntensity; // 0x7C
	public Light waterLight; // 0x80
	public float waterLightIntensityTop; // 0x88
	public float waterLightIntensityBot; // 0x8C
	public Material skyBoxMaterial; // 0x90
	public Color skyBoxColorTop; // 0x98
	public Color skyBoxColorBottom; // 0xA8
	public float fogEndDistTop; // 0xB8
	public float fogEndDistBot; // 0xBC
	public Color fogColorTop; // 0xC0
	public Color fogColorBottom; // 0xD0
	public float bloomIntesityTop; // 0xE0
	public float bloomIntesityBot; // 0xE4
	public float bloomThresholdTop; // 0xE8
	public float bloomThresholdBot; // 0xEC
	public float duration; // 0xF0
	public GameObject swampObj; // 0xF8
	public Camera playerCam; // 0x100
	private Beautify _beautify; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Setup>d__24 : IEnumerator<object> // TypeDefIndex: 14260
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public PositionBasedLight <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Setup>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EB9C0-0x00000001804EBAF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EBAF0-0x00000001804EBB40
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14261
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static DOGetter<Color> <>9__25_4; // 0x08
		public static DOSetter<Color> <>9__25_5; // 0x10
		public static DOGetter<float> <>9__25_6; // 0x18
		public static DOSetter<float> <>9__25_7; // 0x20
		public static DOGetter<Color> <>9__26_4; // 0x28
		public static DOSetter<Color> <>9__26_5; // 0x30
		public static DOGetter<float> <>9__26_6; // 0x38
		public static DOSetter<float> <>9__26_7; // 0x40

		// Constructors
		static <>c(); // 0x00000001804ED470-0x00000001804ED4D0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal Color <OnTriggerEnter>b__25_4(); // 0x00000001804ECC10-0x00000001804ECC40
		internal void <OnTriggerEnter>b__25_5(Color x); // 0x00000001804ECC40-0x00000001804ECC60
		internal float <OnTriggerEnter>b__25_6(); // 0x00000001804ECC60-0x00000001804ECC70
		internal void <OnTriggerEnter>b__25_7(float x); // 0x00000001804ECC70-0x00000001804ECC80
		internal Color <OnTriggerExit>b__26_4(); // 0x00000001804ECC10-0x00000001804ECC40
		internal void <OnTriggerExit>b__26_5(Color x); // 0x00000001804ECC40-0x00000001804ECC60
		internal float <OnTriggerExit>b__26_6(); // 0x00000001804ECC60-0x00000001804ECC70
		internal void <OnTriggerExit>b__26_7(float x); // 0x00000001804ECC70-0x00000001804ECC80
	}

	// Constructors
	public PositionBasedLight(); // 0x00000001804E6B80-0x00000001804E6BE0

	// Methods
	public override void MStart(); // 0x00000001804E5CE0-0x00000001804E5F00
	[IteratorStateMachine] // 0x00000001801FCE80-0x00000001801FCED0
	private IEnumerator Setup(); // 0x00000001804E6A60-0x00000001804E6AC0
	private void OnTriggerEnter(Collider other); // 0x00000001804E5F00-0x00000001804E64B0
	private void OnTriggerExit(Collider other); // 0x00000001804E64B0-0x00000001804E6A60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <OnTriggerEnter>b__25_0(); // 0x00000001804E6AC0-0x00000001804E6AF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerEnter>b__25_1(float x); // 0x00000001804E6AF0-0x00000001804E6B20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <OnTriggerEnter>b__25_2(); // 0x00000001804E6B20-0x00000001804E6B50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerEnter>b__25_3(float x); // 0x00000001804E6B50-0x00000001804E6B80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <OnTriggerExit>b__26_0(); // 0x00000001804E6AC0-0x00000001804E6AF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerExit>b__26_1(float x); // 0x00000001804E6AF0-0x00000001804E6B20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <OnTriggerExit>b__26_2(); // 0x00000001804E6B20-0x00000001804E6B50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerExit>b__26_3(float x); // 0x00000001804E6B50-0x00000001804E6B80
}


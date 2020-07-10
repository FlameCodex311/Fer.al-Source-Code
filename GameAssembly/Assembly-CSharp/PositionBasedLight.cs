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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PositionBasedLight : ManagedBehaviour // TypeDefIndex: 12690
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Setup>d__24 : IEnumerator<object> // TypeDefIndex: 12691
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public PositionBasedLight <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Setup>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181166AD0-0x0000000181166C10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181166C10-0x0000000181166C60
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12692
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
		static <>c(); // 0x0000000181166E70-0x0000000181166ED0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal Color <OnTriggerEnter>b__25_4(); // 0x0000000181166CB0-0x0000000181166CE0
		internal void <OnTriggerEnter>b__25_5(Color x); // 0x0000000181166CE0-0x0000000181166D00
		internal float <OnTriggerEnter>b__25_6(); // 0x0000000181166D00-0x0000000181166D10
		internal void <OnTriggerEnter>b__25_7(float x); // 0x0000000181166D10-0x0000000181166D20
		internal Color <OnTriggerExit>b__26_4(); // 0x0000000181166CB0-0x0000000181166CE0
		internal void <OnTriggerExit>b__26_5(Color x); // 0x0000000181166CE0-0x0000000181166D00
		internal float <OnTriggerExit>b__26_6(); // 0x0000000181166D00-0x0000000181166D10
		internal void <OnTriggerExit>b__26_7(float x); // 0x0000000181166D10-0x0000000181166D20
	}

	// Constructors
	public PositionBasedLight(); // 0x000000018115D890-0x000000018115D8F0

	// Methods
	public override void MStart(); // 0x000000018115C9F0-0x000000018115CC10
	[IteratorStateMachine] // 0x000000018010EE20-0x000000018010EE70
	private IEnumerator Setup(); // 0x000000018115D770-0x000000018115D7D0
	private void OnTriggerEnter(Collider other); // 0x000000018115CC10-0x000000018115D1C0
	private void OnTriggerExit(Collider other); // 0x000000018115D1C0-0x000000018115D770
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <OnTriggerEnter>b__25_0(); // 0x000000018115D7D0-0x000000018115D800
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTriggerEnter>b__25_1(float x); // 0x000000018115D800-0x000000018115D830
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <OnTriggerEnter>b__25_2(); // 0x000000018115D830-0x000000018115D860
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTriggerEnter>b__25_3(float x); // 0x000000018115D860-0x000000018115D890
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <OnTriggerExit>b__26_0(); // 0x000000018115D7D0-0x000000018115D800
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTriggerExit>b__26_1(float x); // 0x000000018115D800-0x000000018115D830
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <OnTriggerExit>b__26_2(); // 0x000000018115D830-0x000000018115D860
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTriggerExit>b__26_3(float x); // 0x000000018115D860-0x000000018115D890
}


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

public class FakeLight : ManagedBehaviour // TypeDefIndex: 11950
{
	// Fields
	private static List<FakeLight> activeInScene; // 0x00
	[Header] // 0x00000001801F0050-0x00000001801F0080
	public FakeLightBlendMode blendMode; // 0x50
	public Color color; // 0x54
	public Color color2; // 0x64
	[Header] // 0x00000001801F01C0-0x00000001801F01F0
	public float falloff; // 0x74
	[Header] // 0x00000001801F05C0-0x00000001801F05F0
	public bool animated; // 0x78
	public float animationSpeedLow; // 0x7C
	public float animationSpeedHigh; // 0x80
	public AnimationCurve animationCurve; // 0x88
	private float _animatedLerp; // 0x90
	private float _animatedTime; // 0x94
	private float _animatedSpeed; // 0x98
	private static QRoutineGroup _fakeLightParentQRoutineGroup; // 0x08
	private QRoutineGroup _lightQRoutineGroup; // 0xA0

	// Properties
	private static QRoutineGroup FakeLightParentQRoutineGroup { get; } // 0x0000000180868EF0-0x0000000180869050 
	private QRoutineGroup LightQRoutineGroup { get; } // 0x0000000180869050-0x00000001808692B0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateAnimationRoutine>d__21 : IEnumerator<object> // TypeDefIndex: 11951
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FakeLight <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateAnimationRoutine>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086C320-0x000000018086C460
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086C460-0x000000018086C660
	}

	// Constructors
	public FakeLight(); // 0x0000000180868CC0-0x0000000180868EF0
	static FakeLight(); // 0x0000000180868C60-0x0000000180868CC0

	// Methods
	public override void MOnEnable(); // 0x00000001803774A0-0x00000001803774B0
	public override void MOnDisable(); // 0x00000001803774A0-0x00000001803774B0
	private void UpdateAnimation(float inDelta); // 0x0000000180868B80-0x0000000180868C60
	[IteratorStateMachine] // 0x00000001801F0740-0x00000001801F0790
	private IEnumerator UpdateAnimationRoutine(); // 0x0000000180868B20-0x0000000180868B80
	private Color GetFinalColor(); // 0x0000000180868AB0-0x0000000180868B20
	public static void GetColorsForPosition(Vector3 inPos, out Color outMultColor, out Color outAddColor); // 0x00000001808684C0-0x0000000180868AB0
}


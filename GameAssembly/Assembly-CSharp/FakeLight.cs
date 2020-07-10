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

public class FakeLight : ManagedBehaviour // TypeDefIndex: 10440
{
	// Fields
	private static List<FakeLight> activeInScene; // 0x00
	[Header] // 0x00000001801133D0-0x0000000180113400
	public FakeLightBlendMode blendMode; // 0x50
	public Color color; // 0x54
	public Color color2; // 0x64
	[Header] // 0x0000000180113550-0x0000000180113580
	public float falloff; // 0x74
	[Header] // 0x00000001801136B0-0x00000001801136E0
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
	private static QRoutineGroup FakeLightParentQRoutineGroup { get; } // 0x0000000181491570-0x00000001814916D0 
	private QRoutineGroup LightQRoutineGroup { get; } // 0x00000001814916D0-0x0000000181491940 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateAnimationRoutine>d__21 : IEnumerator<object> // TypeDefIndex: 10441
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FakeLight <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateAnimationRoutine>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814AB3F0-0x00000001814AB530
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814AB530-0x00000001814AB580
	}

	// Constructors
	public FakeLight(); // 0x0000000181491330-0x0000000181491570
	static FakeLight(); // 0x00000001814912D0-0x0000000181491330

	// Methods
	public override void MOnEnable(); // 0x00000001803581E0-0x00000001803581F0
	public override void MOnDisable(); // 0x00000001803581E0-0x00000001803581F0
	private void UpdateAnimation(float inDelta); // 0x00000001814911F0-0x00000001814912D0
	[IteratorStateMachine] // 0x00000001801137B0-0x0000000180113800
	private IEnumerator UpdateAnimationRoutine(); // 0x0000000181491190-0x00000001814911F0
	private Color GetFinalColor(); // 0x0000000181491120-0x0000000181491190
	public static void GetColorsForPosition(Vector3 inPos, out Color outMultColor, out Color outAddColor); // 0x0000000181490B20-0x0000000181491120
}


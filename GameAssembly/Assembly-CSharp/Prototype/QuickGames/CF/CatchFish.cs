/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.CF
{
	public class CatchFish : QuickGamesBase // TypeDefIndex: 16322
	{
		// Fields
		[Header] // 0x00000001800D52D0-0x00000001800D5300
		public Transform aimer; // 0xF0
		public List<Transform> targets; // 0xF8
		public Transform startPoint; // 0x100
		public LineRenderer line; // 0x108
		public float rotateSpeed; // 0x110
		public float rotateRange; // 0x114
		public float fadeTime; // 0x118
		public float lineSpeed; // 0x11C
		public int lineVerts; // 0x120
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0x124
		private bool _launched; // 0x128
		private float _minAngle; // 0x12C
		private float _maxAngle; // 0x130
		private float[] _targetAngles; // 0x138
		private int _hitTargetIndex; // 0x140
		private int _rotateDir; // 0x144
		private List<Vector3> _pointList; // 0x148
		private List<Vector3> _lineList; // 0x150
		private Transform[] _targets; // 0x158
		private Transform _hitTarget; // 0x160
		private Vector3 _midPoint; // 0x168
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__24 : IEnumerator<object> // TypeDefIndex: 16323
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchFish <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AD5E0-0x00000001813AD6C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AD6C0-0x00000001813AD710
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__25 : IEnumerator<object> // TypeDefIndex: 16324
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchFish <>4__this; // 0x20
			private int <i>5__2; // 0x28
			private float <t>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813ADDF0-0x00000001813AE5A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AE5A0-0x00000001813AE5F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FadeTarget>d__26 : IEnumerator<object> // TypeDefIndex: 16325
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchFish <>4__this; // 0x20
			public int inTargetIndex; // 0x28
			private Color <fadeTo>5__2; // 0x2C
			private RawImage <image>5__3; // 0x40
			private float <t>5__4; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FadeTarget>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A8750-0x00000001813A89D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A89D0-0x00000001813A8A20
		}
	
		// Constructors
		public CatchFish(); // 0x0000000181396DB0-0x0000000181396E80
	
		// Methods
		public override void MStart(); // 0x0000000181395990-0x0000000181396480
		private void RotateAimer(); // 0x0000000181396AD0-0x0000000181396CE0
		public override void QuickGameUpdate(); // 0x0000000181396480-0x0000000181396AD0
		[IteratorStateMachine] // 0x00000001800D5630-0x00000001800D5680
		public override IEnumerator ShowIntro(); // 0x0000000181396CE0-0x0000000181396D40
		[IteratorStateMachine] // 0x00000001800D58B0-0x00000001800D5900
		public override IEnumerator ShowResults(); // 0x0000000181396D40-0x0000000181396DA0
		[IteratorStateMachine] // 0x00000001800D5AB0-0x00000001800D5B00
		private IEnumerator FadeTarget(int inTargetIndex); // 0x0000000181395920-0x0000000181395990
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}

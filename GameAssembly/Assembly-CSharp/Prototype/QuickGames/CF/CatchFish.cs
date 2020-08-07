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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.CF
{
	public class CatchFish : QuickGamesBase // TypeDefIndex: 15064
	{
		// Fields
		[Header] // 0x00000001801E6410-0x00000001801E6440
		public Transform aimer; // 0xF0
		public List<Transform> targets; // 0xF8
		public Transform startPoint; // 0x100
		public LineRenderer line; // 0x108
		public float rotateSpeed; // 0x110
		public float rotateRange; // 0x114
		public float fadeTime; // 0x118
		public float lineSpeed; // 0x11C
		public int lineVerts; // 0x120
		[Header] // 0x00000001801D1640-0x00000001801D1670
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__24 : IEnumerator<object> // TypeDefIndex: 15065
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchFish <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE1990-0x0000000180AE1A70
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE1A70-0x0000000180AE1AC0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__25 : IEnumerator<object> // TypeDefIndex: 15066
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CatchFish <>4__this; // 0x20
			private int <i>5__2; // 0x28
			private float <t>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE2E00-0x0000000180AE3580
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE3580-0x0000000180AE35D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FadeTarget>d__26 : IEnumerator<object> // TypeDefIndex: 15067
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FadeTarget>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADEDA0-0x0000000180ADF020
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADF020-0x0000000180ADF070
		}
	
		// Constructors
		public CatchFish(); // 0x0000000180ACE190-0x0000000180ACE260
	
		// Methods
		public override void MStart(); // 0x0000000180ACCE30-0x0000000180ACD8A0
		private void RotateAimer(); // 0x0000000180ACDED0-0x0000000180ACE0D0
		public override void QuickGameUpdate(); // 0x0000000180ACD8A0-0x0000000180ACDED0
		[IteratorStateMachine] // 0x00000001801E6820-0x00000001801E6870
		public override IEnumerator ShowIntro(); // 0x0000000180ACE0D0-0x0000000180ACE130
		[IteratorStateMachine] // 0x00000001801E6B60-0x00000001801E6BB0
		public override IEnumerator ShowResults(); // 0x0000000180ACE130-0x0000000180ACE190
		[IteratorStateMachine] // 0x00000001801E6FC0-0x00000001801E7010
		private IEnumerator FadeTarget(int inTargetIndex); // 0x0000000180ACCDC0-0x0000000180ACCE30
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}

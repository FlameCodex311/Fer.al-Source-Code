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

namespace Prototype.QuickGames.Worms
{
	public class Worms : QuickGamesBase // TypeDefIndex: 15003
	{
		// Fields
		[Header] // 0x000000018028A770-0x000000018028A7A0
		public QuickGamesAudio wormsAudio; // 0xF0
		[Tooltip] // 0x000000018025FC10-0x000000018025FC40
		public Transform cursorObject; // 0xF8
		public Transform targetLocations; // 0x100
		public Transform target; // 0x108
		public Transform nonTarget; // 0x110
		[Tooltip] // 0x0000000180230C20-0x0000000180230C50
		public float targetMoveDistnceMaxX; // 0x118
		[Tooltip] // 0x0000000180230C20-0x0000000180230C50
		public float targetMoveDistnceMaxY; // 0x11C
		[Tooltip] // 0x0000000180230E50-0x0000000180230E80
		public float cursorMoveDistnceMaxX; // 0x120
		[Tooltip] // 0x0000000180230E50-0x0000000180230E80
		public float cursorMoveDistnceMaxY; // 0x124
		public float targetMoveSpeedMin; // 0x128
		public float targetMoveSpeedMax; // 0x12C
		public float nonTargetMoveSpeedMin; // 0x130
		public float nonTargetMoveSpeedMax; // 0x134
		[Tooltip] // 0x000000018028B030-0x000000018028B060
		public int nonTargetCount; // 0x138
		public float cursorRange; // 0x13C
		public float resultsFadeTime; // 0x140
		private HashSet<RawImage> allWormsImages; // 0x148
		private HashSet<WormMover> allWorms; // 0x150
		private Vector2[] cursorSphere; // 0x158
		private RectTransform _hudRect; // 0x160
		private Vector2 _mousePos; // 0x168
		private Camera _cam; // 0x170
	
		// Nested types
		private class WormMover : UnityEngine.MonoBehaviour // TypeDefIndex: 15004
		{
			// Fields
			public float moveSpeed; // 0x18
			public bool isTarget; // 0x1C
			public Worms wormsGame; // 0x20
			public RawImage image; // 0x28
			public Vector2 moveDir; // 0x30
			private Transform _transform; // 0x38
			private Vector2 _position; // 0x40
			private Vector2 _scale; // 0x48
			private float _targetMoveDistnceMaxX; // 0x50
			private float _targetMoveDistnceMaxY; // 0x54
			private bool _pulseIn; // 0x58
			private Color _pulseOutColor; // 0x5C
			private float _currentPulseTime; // 0x6C
	
			// Constructors
			public WormMover(); // 0x0000000180A466A0-0x0000000180A46700
	
			// Methods
			private void Awake(); // 0x0000000180A46050-0x0000000180A460F0
			public void Init(); // 0x0000000180A460F0-0x0000000180A46260
			public void WormUpdate(); // 0x0000000180A46260-0x0000000180A466A0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15005
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Transform> <>9__27_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180A444C0-0x0000000180A44520
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <QuickGameUpdate>b__27_0(Transform y, Transform x); // 0x0000000180A443B0-0x0000000180A44410
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__28 : IEnumerator<object> // TypeDefIndex: 15006
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Worms <>4__this; // 0x20
			private Color <transparentWhite>5__2; // 0x28
			private float <fadeTime>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A421F0-0x0000000180A42740
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A42740-0x0000000180A42790
		}
	
		// Constructors
		public Worms(); // 0x0000000180A47FD0-0x0000000180A48090
	
		// Methods
		public override void MStart(); // 0x0000000180A46700-0x0000000180A467B0
		private void PlaceTargets(); // 0x0000000180A46AD0-0x0000000180A472B0
		private Vector2 RotateV2(Vector2 v, float degrees); // 0x0000000180A47EB0-0x0000000180A47F70
		private void OnDrawGizmos(); // 0x0000000180A46980-0x0000000180A46AD0
		public override void QuickGameUpdate(); // 0x0000000180A472B0-0x0000000180A47EB0
		[IteratorStateMachine] // 0x000000018028B1B0-0x000000018028B200
		public override IEnumerator ShowResults(); // 0x0000000180A47F70-0x0000000180A47FD0
		private void MoveCursor(); // 0x0000000180A467B0-0x0000000180A46980
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}

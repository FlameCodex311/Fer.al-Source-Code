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

namespace Prototype.QuickGames.Worms
{
	public class Worms : QuickGamesBase // TypeDefIndex: 16261
	{
		// Fields
		[Header] // 0x000000018016C470-0x000000018016C4A0
		public QuickGamesAudio wormsAudio; // 0xF0
		[Tooltip] // 0x0000000180140C80-0x0000000180140CB0
		public Transform cursorObject; // 0xF8
		public Transform targetLocations; // 0x100
		public Transform target; // 0x108
		public Transform nonTarget; // 0x110
		[Tooltip] // 0x000000018010DCB0-0x000000018010DCE0
		public float targetMoveDistnceMaxX; // 0x118
		[Tooltip] // 0x000000018010DCB0-0x000000018010DCE0
		public float targetMoveDistnceMaxY; // 0x11C
		[Tooltip] // 0x000000018010DF10-0x000000018010DF40
		public float cursorMoveDistnceMaxX; // 0x120
		[Tooltip] // 0x000000018010DF10-0x000000018010DF40
		public float cursorMoveDistnceMaxY; // 0x124
		public float targetMoveSpeedMin; // 0x128
		public float targetMoveSpeedMax; // 0x12C
		public float nonTargetMoveSpeedMin; // 0x130
		public float nonTargetMoveSpeedMax; // 0x134
		[Tooltip] // 0x000000018016E020-0x000000018016E050
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
		private class WormMover : UnityEngine.MonoBehaviour // TypeDefIndex: 16262
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
			public WormMover(); // 0x000000018160A2F0-0x000000018160A350
	
			// Methods
			private void Awake(); // 0x0000000181609C80-0x0000000181609D20
			public void Init(); // 0x0000000181609D20-0x0000000181609EA0
			public void WormUpdate(); // 0x0000000181609EA0-0x000000018160A2F0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 16263
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Transform> <>9__27_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181607FF0-0x0000000181608050
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <QuickGameUpdate>b__27_0(Transform y, Transform x); // 0x0000000181607ED0-0x0000000181607F40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__28 : IEnumerator<object> // TypeDefIndex: 16264
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Worms <>4__this; // 0x20
			private Color <transparentWhite>5__2; // 0x28
			private float <fadeTime>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181605640-0x0000000181605BB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181605BB0-0x0000000181605C00
		}
	
		// Constructors
		public Worms(); // 0x000000018160BCA0-0x000000018161AEA0
	
		// Methods
		public override void MStart(); // 0x000000018160A350-0x000000018160A410
		private void PlaceTargets(); // 0x000000018160A740-0x000000018160AF40
		private Vector2 RotateV2(Vector2 v, float degrees); // 0x000000018160BB80-0x000000018160BC40
		private void OnDrawGizmos(); // 0x000000018160A5E0-0x000000018160A740
		public override void QuickGameUpdate(); // 0x000000018160AF40-0x000000018160BB80
		[IteratorStateMachine] // 0x000000018016E280-0x000000018016E2D0
		public override IEnumerator ShowResults(); // 0x000000018160BC40-0x000000018160BCA0
		private void MoveCursor(); // 0x000000018160A410-0x000000018160A5E0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181395900-0x0000000181395910
	}
}

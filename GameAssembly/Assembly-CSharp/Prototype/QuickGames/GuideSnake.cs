/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class GuideSnake : QuickGamesBase // TypeDefIndex: 14861
	{
		// Fields
		[Header] // 0x0000000180238990-0x00000001802389C0
		public GameObject snakeHead; // 0xF0
		public GameObject snakeBodyPart; // 0xF8
		public GameObject target; // 0x100
		public Transform snakeEyesRotator; // 0x108
		public Transform ember; // 0x110
		public float screenLimitX; // 0x118
		public float screenLimitY; // 0x11C
		public int numSegments; // 0x120
		public float snakeSpeed; // 0x124
		public float timeBetweenSegments; // 0x128
		public int tailLength; // 0x12C
		public int numEmbers; // 0x130
		public float pulseTime; // 0x134
		public float pulseScale; // 0x138
		public float eyeRotateSpeed; // 0x13C
		public float placementBuffer; // 0x140
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0x144
		private int _bodyPartsSiblingIndex; // 0x148
		private Vector2 _moveDir; // 0x14C
		private List<SnakeMover> _allParts; // 0x158
		private float _minMoveDist; // 0x160
		private List<Vector2> _movePositions; // 0x168
		private List<Vector3> _placedPositions; // 0x170
	
		// Nested types
		private class SnakeMover : MonoBehaviour // TypeDefIndex: 14862
		{
			// Fields
			internal GuideSnake Game; // 0x20
			internal Vector3 moveTo; // 0x28
			internal Vector3 scale; // 0x34
			internal int movePositionIndex; // 0x40
			internal bool isHead; // 0x44
			internal RawImage image; // 0x48
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <RotateEyes>d__7 : IEnumerator<object> // TypeDefIndex: 14863
			{
				// Fields
				private int <>1__state; // 0x10
				private object <>2__current; // 0x18
				public SnakeMover <>4__this; // 0x20
				public float inAngle; // 0x28
				private Quaternion <startRot>5__2; // 0x2C
				private Quaternion <endRotate>5__3; // 0x3C
				private float <i>5__4; // 0x4C
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <RotateEyes>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x0000000180993810-0x0000000180993AF0
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000180993AF0-0x0000000180993B40
			}
	
			// Constructors
			public SnakeMover(); // 0x000000018098FF30-0x000000018098FF40
	
			// Methods
			private void Awake(); // 0x000000018098F930-0x000000018098F970
			[IteratorStateMachine] // 0x000000018023A840-0x000000018023A890
			private IEnumerator RotateEyes(float inAngle); // 0x000000018098FEC0-0x000000018098FF30
			internal void Move(); // 0x000000018098F970-0x000000018098FE30
			private void OnTriggerEnter2D(Collider2D collision); // 0x000000018098FE30-0x000000018098FEC0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__25 : IEnumerator<object> // TypeDefIndex: 14864
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private float <nextSegment>5__2; // 0x28
			private float <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809945B0-0x0000000180994860
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994860-0x00000001809948B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PlaceObjects>d__33 : IEnumerator<object> // TypeDefIndex: 14865
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private float <delay>5__2; // 0x28
			private int <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PlaceObjects>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180992FA0-0x0000000180993300
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180993300-0x0000000180993350
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ScalePart>d__34 : IEnumerator<object> // TypeDefIndex: 14866
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			public SnakeMover inSM; // 0x28
			private float <halfTime>5__2; // 0x30
			private Vector3 <startScale>5__3; // 0x34
			private Vector3 <endScale>5__4; // 0x40
			private float <i>5__5; // 0x4C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ScalePart>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180994050-0x0000000180994410
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994410-0x0000000180994460
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ColorPart>d__35 : IEnumerator<object> // TypeDefIndex: 14867
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			public SnakeMover inSM; // 0x28
			private float <halfTime>5__2; // 0x30
			private Color <results>5__3; // 0x34
			private Color <white>5__4; // 0x44
			private float <i>5__5; // 0x54
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ColorPart>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809910B0-0x0000000180991280
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180991280-0x00000001809912D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <HitTarget>d__36 : IEnumerator<object> // TypeDefIndex: 14868
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Collider2D inCollider; // 0x20
			public GuideSnake <>4__this; // 0x28
			private Vector3 <startScale>5__2; // 0x30
			private float <i>5__3; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <HitTarget>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180992A50-0x0000000180992D20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180992D20-0x0000000180992D70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ScaleAll>d__37 : IEnumerator<object> // TypeDefIndex: 14869
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ScaleAll>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180993B40-0x0000000180993CA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180993CA0-0x0000000180993CF0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__38 : IEnumerator<object> // TypeDefIndex: 14870
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180995B90-0x0000000180995D00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180995D00-0x0000000180995D50
		}
	
		// Constructors
		public GuideSnake(); // 0x0000000180984220-0x0000000180984380
	
		// Methods
		public override void MStart(); // 0x00000001809831B0-0x0000000180983550
		[IteratorStateMachine] // 0x0000000180238EA0-0x0000000180238EF0
		public override IEnumerator ShowIntro(); // 0x0000000180984160-0x00000001809841C0
		private void FixedUpdate(); // 0x0000000180982CF0-0x0000000180982D00
		public override void QuickGameUpdate(); // 0x0000000180983A40-0x0000000180984090
		private void MakeBodyPart(); // 0x0000000180983550-0x0000000180983930
		private Vector3 GetPlacmentPos(bool inFirst, int inTries); // 0x0000000180982E00-0x0000000180983140
		private void GetNextMovePosition(); // 0x0000000180982D00-0x0000000180982E00
		private void MoveParts(); // 0x0000000180983930-0x00000001809839E0
		private void OutOfBounds(); // 0x000000018097FD50-0x000000018097FD60
		[IteratorStateMachine] // 0x0000000180239350-0x00000001802393A0
		private IEnumerator PlaceObjects(); // 0x00000001809839E0-0x0000000180983A40
		[IteratorStateMachine] // 0x0000000180239640-0x0000000180239690
		private IEnumerator ScalePart(SnakeMover inSM); // 0x00000001809840F0-0x0000000180984160
		[IteratorStateMachine] // 0x00000001802398E0-0x0000000180239930
		private IEnumerator ColorPart(SnakeMover inSM); // 0x0000000180982C80-0x0000000180982CF0
		[IteratorStateMachine] // 0x0000000180239CA0-0x0000000180239CF0
		private IEnumerator HitTarget(Collider2D inCollider); // 0x0000000180983140-0x00000001809831B0
		[IteratorStateMachine] // 0x0000000180239F70-0x0000000180239FC0
		private IEnumerator ScaleAll(); // 0x0000000180984090-0x00000001809840F0
		[IteratorStateMachine] // 0x000000018023A230-0x000000018023A280
		public override IEnumerator ShowResults(); // 0x00000001809841C0-0x0000000180984220
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}

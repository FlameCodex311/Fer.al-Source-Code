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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class GuideSnake : QuickGamesBase // TypeDefIndex: 16119
	{
		// Fields
		[Header] // 0x0000000180115730-0x0000000180115760
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
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0x144
		private int _bodyPartsSiblingIndex; // 0x148
		private Vector2 _moveDir; // 0x14C
		private List<SnakeMover> _allParts; // 0x158
		private float _minMoveDist; // 0x160
		private List<Vector2> _movePositions; // 0x168
		private List<Vector3> _placedPositions; // 0x170
	
		// Nested types
		private class SnakeMover : MonoBehaviour // TypeDefIndex: 16120
		{
			// Fields
			internal GuideSnake Game; // 0x20
			internal Vector3 moveTo; // 0x28
			internal Vector3 scale; // 0x34
			internal int movePositionIndex; // 0x40
			internal bool isHead; // 0x44
			internal RawImage image; // 0x48
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <RotateEyes>d__7 : IEnumerator<object> // TypeDefIndex: 16121
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
				object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <RotateEyes>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x00000001813FC880-0x00000001813FCB70
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x00000001813FCB70-0x00000001813FCBC0
			}
	
			// Constructors
			public SnakeMover(); // 0x00000001813F8BF0-0x00000001813F8C00
	
			// Methods
			private void Awake(); // 0x00000001813F85E0-0x00000001813F8620
			[IteratorStateMachine] // 0x0000000180119340-0x0000000180119390
			private IEnumerator RotateEyes(float inAngle); // 0x00000001813F8B80-0x00000001813F8BF0
			internal void Move(); // 0x00000001813F8620-0x00000001813F8AF0
			private void OnTriggerEnter2D(Collider2D collision); // 0x00000001813F8AF0-0x00000001813F8B80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__25 : IEnumerator<object> // TypeDefIndex: 16122
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private float <nextSegment>5__2; // 0x28
			private float <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FD650-0x00000001813FD910
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FD910-0x00000001813FD960
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PlaceObjects>d__33 : IEnumerator<object> // TypeDefIndex: 16123
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private float <delay>5__2; // 0x28
			private int <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PlaceObjects>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FC000-0x00000001813FC370
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FC370-0x00000001813FC3C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ScalePart>d__34 : IEnumerator<object> // TypeDefIndex: 16124
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ScalePart>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FD0E0-0x00000001813FD4B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FD4B0-0x00000001813FD500
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ColorPart>d__35 : IEnumerator<object> // TypeDefIndex: 16125
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ColorPart>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9DA0-0x00000001813F9F70
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F9F70-0x00000001813F9FC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <HitTarget>d__36 : IEnumerator<object> // TypeDefIndex: 16126
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Collider2D inCollider; // 0x20
			public GuideSnake <>4__this; // 0x28
			private Vector3 <startScale>5__2; // 0x30
			private float <i>5__3; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <HitTarget>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FBAA0-0x00000001813FBD80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FBD80-0x00000001813FBDD0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ScaleAll>d__37 : IEnumerator<object> // TypeDefIndex: 16127
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ScaleAll>d__37(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FCBC0-0x00000001813FCD20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FCD20-0x00000001813FCD70
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__38 : IEnumerator<object> // TypeDefIndex: 16128
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GuideSnake <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FF930-0x00000001813FFAB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FFAB0-0x00000001813FFB00
		}
	
		// Constructors
		public GuideSnake(); // 0x00000001813ECCF0-0x00000001813ECE50
	
		// Methods
		public override void MStart(); // 0x00000001813EBC30-0x00000001813EBFE0
		[IteratorStateMachine] // 0x00000001801159E0-0x0000000180115A30
		public override IEnumerator ShowIntro(); // 0x00000001813ECC30-0x00000001813ECC90
		private void FixedUpdate(); // 0x00000001813EB750-0x00000001813EB760
		public override void QuickGameUpdate(); // 0x00000001813EC4F0-0x00000001813ECB60
		private void MakeBodyPart(); // 0x00000001813EBFE0-0x00000001813EC3D0
		private Vector3 GetPlacmentPos(bool inFirst, int inTries); // 0x00000001813EB870-0x00000001813EBBC0
		private void GetNextMovePosition(); // 0x00000001813EB760-0x00000001813EB870
		private void MoveParts(); // 0x00000001813EC3D0-0x00000001813EC490
		private void OutOfBounds(); // 0x00000001813E86E0-0x00000001813E86F0
		[IteratorStateMachine] // 0x0000000180115C10-0x0000000180115C60
		private IEnumerator PlaceObjects(); // 0x00000001813EC490-0x00000001813EC4F0
		[IteratorStateMachine] // 0x00000001801170C0-0x0000000180117110
		private IEnumerator ScalePart(SnakeMover inSM); // 0x00000001813ECBC0-0x00000001813ECC30
		[IteratorStateMachine] // 0x0000000180117380-0x00000001801173D0
		private IEnumerator ColorPart(SnakeMover inSM); // 0x00000001813EB6E0-0x00000001813EB750
		[IteratorStateMachine] // 0x00000001801175E0-0x0000000180117630
		private IEnumerator HitTarget(Collider2D inCollider); // 0x00000001813EBBC0-0x00000001813EBC30
		[IteratorStateMachine] // 0x00000001801178D0-0x0000000180117920
		private IEnumerator ScaleAll(); // 0x00000001813ECB60-0x00000001813ECBC0
		[IteratorStateMachine] // 0x0000000180117BE0-0x0000000180117C30
		public override IEnumerator ShowResults(); // 0x00000001813ECC90-0x00000001813ECCF0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}

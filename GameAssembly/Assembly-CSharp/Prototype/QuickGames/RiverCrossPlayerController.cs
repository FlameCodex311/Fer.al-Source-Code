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
	public class RiverCrossPlayerController : MonoBehaviour // TypeDefIndex: 14979
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EPlayerState <state>k__BackingField; // 0x20
		public Image standingImage; // 0x28
		public Image movingImage; // 0x30
		private RiverCrossController parentController; // 0x38
		private Rigidbody2D playerBody; // 0x40
		private RectTransform playerRectTransform; // 0x48
		private Vector3 playerRotation; // 0x50
		private float movementAmount; // 0x5C
		private bool _isMoving; // 0x60
		private float _moveTime; // 0x64
		private float _currentTime; // 0x68
		private float _normalizedTime; // 0x6C
		private Vector2 _originalPos; // 0x70
		private Vector2 _targetPos; // 0x78
		private Vector2 _movementDir; // 0x80
	
		// Properties
		public EPlayerState state { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
	
		// Nested types
		public enum EPlayerState // TypeDefIndex: 14980
		{
			ON_GROUND = 0,
			MOVING = 1,
			IN_WATER = 2,
			ON_LOG = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Move>d__27 : IEnumerator<object> // TypeDefIndex: 14981
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossPlayerController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Move>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5CCD0-0x0000000180A5CF60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5CF60-0x0000000180A5CFB0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateMovement>d__28 : IEnumerator<object> // TypeDefIndex: 14982
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossPlayerController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateMovement>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5BC70-0x0000000180A5BDD0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5BDD0-0x0000000180A5BE20
		}
	
		// Constructors
		public RiverCrossPlayerController(); // 0x0000000180A59340-0x0000000180A59350
	
		// Methods
		public void SetUp(RiverCrossController parent, float logGap); // 0x0000000180A58EB0-0x0000000180A59020
		private void OnCollisionEnter2D(Collision2D collision); // 0x0000000180A58E00-0x0000000180A58E40
		private void OnCollisionExit2D(Collision2D collision); // 0x0000000180A58E40-0x0000000180A58EB0
		public void FallInWater(); // 0x0000000180A58CE0-0x0000000180A58D30
		public void LandOnLog(); // 0x0000000180A58D90-0x0000000180A58DA0
		public void LandOnGround(bool finished); // 0x0000000180A58D30-0x0000000180A58D90
		public void UpdatePosition(int direction, float speed); // 0x0000000180A59280-0x0000000180A59340
		public void TryMovePlayer(int xDirOverride = 0 /* Metadata: 0x007BB0AD */, int yDirOverride = 0 /* Metadata: 0x007BB0B1 */); // 0x0000000180A59020-0x0000000180A59280
		[IteratorStateMachine] // 0x000000018027C310-0x000000018027C360
		private IEnumerator Move(); // 0x0000000180A58DA0-0x0000000180A58E00
		[IteratorStateMachine] // 0x000000018027C5C0-0x000000018027C610
		private IEnumerator AnimateMovement(); // 0x0000000180A58C80-0x0000000180A58CE0
	}
}

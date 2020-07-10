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
	public class RiverCrossPlayerController : MonoBehaviour // TypeDefIndex: 16237
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public EPlayerState state { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
	
		// Nested types
		public enum EPlayerState // TypeDefIndex: 16238
		{
			ON_GROUND = 0,
			MOVING = 1,
			IN_WATER = 2,
			ON_LOG = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Move>d__27 : IEnumerator<object> // TypeDefIndex: 16239
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossPlayerController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Move>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153B390-0x000000018153B620
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153B620-0x000000018153B670
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateMovement>d__28 : IEnumerator<object> // TypeDefIndex: 16240
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossPlayerController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateMovement>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153A2D0-0x000000018153A430
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153A430-0x000000018153A480
		}
	
		// Constructors
		public RiverCrossPlayerController(); // 0x0000000181536FF0-0x0000000181537000
	
		// Methods
		public void SetUp(RiverCrossController parent, float logGap); // 0x0000000181536B60-0x0000000181536CD0
		private void OnCollisionEnter2D(Collision2D collision); // 0x0000000181536AB0-0x0000000181536AF0
		private void OnCollisionExit2D(Collision2D collision); // 0x0000000181536AF0-0x0000000181536B60
		public void FallInWater(); // 0x0000000181536990-0x00000001815369E0
		public void LandOnLog(); // 0x0000000181536A40-0x0000000181536A50
		public void LandOnGround(bool finished); // 0x00000001815369E0-0x0000000181536A40
		public void UpdatePosition(int direction, float speed); // 0x0000000181536F30-0x0000000181536FF0
		public void TryMovePlayer(int xDirOverride = 0 /* Metadata: 0x007854BB */, int yDirOverride = 0 /* Metadata: 0x007854BF */); // 0x0000000181536CD0-0x0000000181536F30
		[IteratorStateMachine] // 0x000000018015BB00-0x000000018015BB50
		private IEnumerator Move(); // 0x0000000181536A50-0x0000000181536AB0
		[IteratorStateMachine] // 0x000000018015BF10-0x000000018015BF60
		private IEnumerator AnimateMovement(); // 0x0000000181536930-0x0000000181536990
	}
}

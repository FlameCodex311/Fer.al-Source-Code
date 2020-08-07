/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PongPongBallController : MonoBehaviour // TypeDefIndex: 14947
	{
		// Fields
		public float speed; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Rigidbody2D <Body>k__BackingField; // 0x28
		private RectTransform rectTransform; // 0x30
		private Vector2 startPos; // 0x38
		private PongPongController parentController; // 0x40
		private bool isAboutToMove; // 0x48
		private float startDelay; // 0x4C
		private float elapsedDelayTime; // 0x50
	
		// Properties
		public Rigidbody2D Body { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	
		// Constructors
		public PongPongBallController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(Vector2 startPos, PongPongController parent); // 0x0000000180A50CD0-0x0000000180A50D60
		public void Reset(); // 0x0000000180A50BF0-0x0000000180A50CB0
		public void Serve(float delay); // 0x0000000180A50CB0-0x0000000180A50CD0
		public void QuickGameUpdate(); // 0x0000000180A50AE0-0x0000000180A50BF0
		private void StartMoving(); // 0x0000000180A50D60-0x0000000180A50E40
		private void OnCollisionEnter2D(Collision2D collision); // 0x0000000180A50900-0x0000000180A50970
		private void OnTriggerEnter2D(Collider2D collision); // 0x0000000180A50970-0x0000000180A50AE0
	}
}

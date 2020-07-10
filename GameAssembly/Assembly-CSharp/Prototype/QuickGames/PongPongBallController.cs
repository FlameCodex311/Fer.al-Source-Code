/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PongPongBallController : MonoBehaviour // TypeDefIndex: 16205
	{
		// Fields
		public float speed; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Rigidbody2D <Body>k__BackingField; // 0x28
		private RectTransform rectTransform; // 0x30
		private Vector2 startPos; // 0x38
		private PongPongController parentController; // 0x40
		private bool isAboutToMove; // 0x48
		private float startDelay; // 0x4C
		private float elapsedDelayTime; // 0x50
	
		// Properties
		public Rigidbody2D Body { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	
		// Constructors
		public PongPongBallController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(Vector2 startPos, PongPongController parent); // 0x000000018152E790-0x000000018152E830
		public void Reset(); // 0x000000018152E6A0-0x000000018152E770
		public void Serve(float delay); // 0x000000018152E770-0x000000018152E790
		public void QuickGameUpdate(); // 0x000000018152E590-0x000000018152E6A0
		private void StartMoving(); // 0x000000018152E830-0x000000018152E910
		private void OnCollisionEnter2D(Collision2D collision); // 0x000000018152E3B0-0x000000018152E420
		private void OnTriggerEnter2D(Collider2D collision); // 0x000000018152E420-0x000000018152E590
	}
}

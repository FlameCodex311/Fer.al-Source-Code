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
	public class CatchTargetController : MonoBehaviour // TypeDefIndex: 16093
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsAlive>k__BackingField; // 0x20
		public int value; // 0x24
		private CoinCatch parentController; // 0x28
	
		// Properties
		public bool IsAlive { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
	
		// Constructors
		public CatchTargetController(); // 0x00000001813985D0-0x00000001813985E0
	
		// Methods
		public void SetUp(CoinCatch parent, float xPos, float yPos, Vector2 force); // 0x0000000181398500-0x00000001813985D0
		private void OnTriggerEnter2D(Collider2D collision); // 0x00000001813983A0-0x0000000181398500
		public void Kill(); // 0x0000000181398330-0x00000001813983A0
	}
}

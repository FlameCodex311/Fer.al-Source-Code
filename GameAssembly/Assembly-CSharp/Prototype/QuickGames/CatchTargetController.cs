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
	public class CatchTargetController : MonoBehaviour // TypeDefIndex: 14835
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsAlive>k__BackingField; // 0x20
		public int value; // 0x24
		private CoinCatch parentController; // 0x28
	
		// Properties
		public bool IsAlive { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FA090-0x00000001803FA0A0 0x00000001803FA0B0-0x00000001803FA0C0
	
		// Constructors
		public CatchTargetController(); // 0x0000000180ACF920-0x0000000180ACF930
	
		// Methods
		public void SetUp(CoinCatch parent, float xPos, float yPos, Vector2 force); // 0x0000000180ACF850-0x0000000180ACF920
		private void OnTriggerEnter2D(Collider2D collision); // 0x0000000180ACF6F0-0x0000000180ACF850
		public void Kill(); // 0x0000000180ACF680-0x0000000180ACF6F0
	}
}

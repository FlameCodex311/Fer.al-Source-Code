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
	public class PotionMixingBottleController : MonoBehaviour // TypeDefIndex: 14951
	{
		// Fields
		public bool isTop; // 0x20
		private string layerName; // 0x28
		private Color color; // 0x30
		private PotionMixingController parentController; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsFull>k__BackingField; // 0x48
		private float elapsedTime; // 0x4C
		private float waitTime; // 0x50
	
		// Properties
		public bool IsFull { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
	
		// Constructors
		public PotionMixingBottleController(); // 0x0000000180A52760-0x0000000180A52770
	
		// Methods
		public void SetUp(string layer, Color color, PotionMixingController parentController); // 0x0000000180A52450-0x0000000180A525F0
		private void Update(); // 0x0000000180A525F0-0x0000000180A52760
	}
}

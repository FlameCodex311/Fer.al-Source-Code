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
	public class PotionMixingBottleController : MonoBehaviour // TypeDefIndex: 16209
	{
		// Fields
		public bool isTop; // 0x20
		private string layerName; // 0x28
		private Color color; // 0x30
		private PotionMixingController parentController; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsFull>k__BackingField; // 0x48
		private float elapsedTime; // 0x4C
		private float waitTime; // 0x50
	
		// Properties
		public bool IsFull { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
	
		// Constructors
		public PotionMixingBottleController(); // 0x0000000181530270-0x0000000181530280
	
		// Methods
		public void SetUp(string layer, Color color, PotionMixingController parentController); // 0x000000018152FF50-0x00000001815300F0
		private void Update(); // 0x00000001815300F0-0x0000000181530270
	}
}

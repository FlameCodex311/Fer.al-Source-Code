/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class WhackAMoleHoleContentsController : MonoBehaviour // TypeDefIndex: 14999
	{
		// Fields
		public Color normalColor; // 0x20
		public Color rareColor; // 0x30
		private Image image; // 0x40
		private WhackAMoleHoleController parentController; // 0x48
	
		// Constructors
		public WhackAMoleHoleContentsController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(WhackAMoleHoleController parent); // 0x0000000180A44DA0-0x0000000180A44E20
		public void ClickHandler(); // 0x0000000180A44C70-0x0000000180A44D20
		public void MakeRare(); // 0x0000000180A44D60-0x0000000180A44DA0
		public void MakeNormal(); // 0x0000000180A44D20-0x0000000180A44D60
	}
}

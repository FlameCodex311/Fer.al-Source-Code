/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class WhackAMoleHoleContentsController : MonoBehaviour // TypeDefIndex: 16257
	{
		// Fields
		public Color normalColor; // 0x20
		public Color rareColor; // 0x30
		private Image image; // 0x40
		private WhackAMoleHoleController parentController; // 0x48
	
		// Constructors
		public WhackAMoleHoleContentsController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(WhackAMoleHoleController parent); // 0x0000000181608970-0x00000001816089F0
		public void ClickHandler(); // 0x0000000181608830-0x00000001816088F0
		public void MakeRare(); // 0x0000000181608930-0x0000000181608970
		public void MakeNormal(); // 0x00000001816088F0-0x0000000181608930
	}
}

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
	public class MatchThreeCursorController : MonoBehaviour // TypeDefIndex: 14916
	{
		// Fields
		public int direction; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <X>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Y>k__BackingField; // 0x28
		private float offsetX; // 0x2C
		private float offsetY; // 0x30
		private float cellWidth; // 0x34
		private float cellHeight; // 0x38
		private int xMax; // 0x3C
		private int yMax; // 0x40
		private GameObject horizontal; // 0x48
		private GameObject vertical; // 0x50
		private RectTransform rectTransform; // 0x58
		private Image hImage; // 0x60
		private Image vImage; // 0x68
	
		// Properties
		public int X { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180491DB0-0x0000000180491DC0 0x0000000180569610-0x0000000180569620
		public int Y { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
	
		// Constructors
		public MatchThreeCursorController(); // 0x000000018077E9E0-0x000000018077E9F0
	
		// Methods
		public void Initialize(int startX, int startY, int xMax, int yMax, float offsetX, float offsetY, float cellWidth, float cellHeight); // 0x000000018098B120-0x000000018098B350
		private void UpdateDirection(int dir); // 0x000000018098B420-0x000000018098B470
		private void UpdateGraphic(bool move, bool rotate); // 0x000000018098B470-0x000000018098B540
		public void FlipCursor(); // 0x000000018098B000-0x000000018098B050
		public void TryMove(int dx, int dy); // 0x000000018098B350-0x000000018098B420
		public int[] GetSelectedIndices(); // 0x000000018098B050-0x000000018098B120
	}
}

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
	public class MatchThreeCursorController : MonoBehaviour // TypeDefIndex: 16174
	{
		// Fields
		public int direction; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <X>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public int X { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
		public int Y { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
	
		// Constructors
		public MatchThreeCursorController(); // 0x00000001813F4140-0x00000001813F4150
	
		// Methods
		public void Initialize(int startX, int startY, int xMax, int yMax, float offsetX, float offsetY, float cellWidth, float cellHeight); // 0x00000001813F3D00-0x00000001813F3F40
		private void UpdateDirection(int dir); // 0x00000001813F4020-0x00000001813F4070
		private void UpdateGraphic(bool move, bool rotate); // 0x00000001813F4070-0x00000001813F4140
		public void FlipCursor(); // 0x00000001813F3BD0-0x00000001813F3C20
		public void TryMove(int dx, int dy); // 0x00000001813F3F40-0x00000001813F4020
		public int[] GetSelectedIndices(); // 0x00000001813F3C20-0x00000001813F3D00
	}
}

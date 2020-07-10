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
	public class MazeCellController : MonoBehaviour // TypeDefIndex: 16175
	{
		// Fields
		public Color startColor; // 0x20
		public Color destinationColor; // 0x30
		private GameObject signHolder; // 0x40
		private Image image; // 0x48
		private GameObject top_closed; // 0x50
		private GameObject top_open; // 0x58
		private GameObject bottom_closed; // 0x60
		private GameObject bottom_open; // 0x68
		private GameObject left_closed; // 0x70
		private GameObject left_open; // 0x78
		private GameObject right_closed; // 0x80
		private GameObject right_open; // 0x88
		private bool topState; // 0x90
		private bool bottomState; // 0x91
		private bool leftState; // 0x92
		private bool rightState; // 0x93
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private MazeController.MazeChunk <Chunk>k__BackingField; // 0x98
	
		// Properties
		public MazeController.MazeChunk Chunk { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B70-0x0000000180369B80 0x000000018036A3D0-0x000000018036A3E0
	
		// Constructors
		public MazeCellController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(bool top, bool bottom, bool left, bool right); // 0x0000000181526660-0x0000000181526A40
		public bool CanEnter(int fromDirection); // 0x00000001815264F0-0x0000000181526530
		public bool CanExit(int toDirection); // 0x00000001815264F0-0x0000000181526530
		public void SetConnection(int direction, bool value); // 0x0000000181526610-0x0000000181526660
		public void MakeStart(); // 0x00000001815265A0-0x0000000181526610
		public void MakeDestination(); // 0x0000000181526530-0x00000001815265A0
		private void UpdateVisual(); // 0x0000000181526A40-0x0000000181526B70
	}
}

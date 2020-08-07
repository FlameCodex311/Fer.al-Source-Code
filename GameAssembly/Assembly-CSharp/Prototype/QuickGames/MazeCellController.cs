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
	public class MazeCellController : MonoBehaviour // TypeDefIndex: 14917
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private MazeController.MazeChunk <Chunk>k__BackingField; // 0x98
	
		// Properties
		public MazeController.MazeChunk Chunk { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
	
		// Constructors
		public MazeCellController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(bool top, bool bottom, bool left, bool right); // 0x0000000180A48E40-0x0000000180A491F0
		public bool CanEnter(int fromDirection); // 0x0000000180A48CD0-0x0000000180A48D10
		public bool CanExit(int toDirection); // 0x0000000180A48CD0-0x0000000180A48D10
		public void SetConnection(int direction, bool value); // 0x0000000180A48DF0-0x0000000180A48E40
		public void MakeStart(); // 0x0000000180A48D80-0x0000000180A48DF0
		public void MakeDestination(); // 0x0000000180A48D10-0x0000000180A48D80
		private void UpdateVisual(); // 0x0000000180A491F0-0x0000000180A49320
	}
}

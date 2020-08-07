/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PianoRollController : MonoBehaviour // TypeDefIndex: 14941
	{
		// Fields
		public GameObject pianoNotePrefab; // 0x20
		public GameObject pianoBarPrefab; // 0x28
		private PianoSong song; // 0x30
		private PianoController parentController; // 0x38
		private List<PianoBarController> bars; // 0x40
		private List<PianoNoteController> notes; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <BeatHeight>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <BarHeight>k__BackingField; // 0x54
		private Rigidbody2D body; // 0x58
	
		// Properties
		public float BeatHeight { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180791CE0-0x0000000180791CF0 0x00000001807E32A0-0x00000001807E32B0
		public float BarHeight { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180791CD0-0x0000000180791CE0 0x0000000180A506C0-0x0000000180A506D0
	
		// Constructors
		public PianoRollController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(PianoSong song, PianoController parentController); // 0x0000000180A50650-0x0000000180A506C0
		private void Create(); // 0x0000000180A50310-0x0000000180A50540
		public void QuickGameUpdate(); // 0x0000000180A50590-0x0000000180A50650
		public Vector2 GetNotePosition(PianoSong.Note note); // 0x0000000180A50540-0x0000000180A50590
	}
}

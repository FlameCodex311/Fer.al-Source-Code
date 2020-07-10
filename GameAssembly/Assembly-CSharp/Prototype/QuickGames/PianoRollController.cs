/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PianoRollController : MonoBehaviour // TypeDefIndex: 16199
	{
		// Fields
		public GameObject pianoNotePrefab; // 0x20
		public GameObject pianoBarPrefab; // 0x28
		private PianoSong song; // 0x30
		private PianoController parentController; // 0x38
		private List<PianoBarController> bars; // 0x40
		private List<PianoNoteController> notes; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <BeatHeight>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <BarHeight>k__BackingField; // 0x54
		private Rigidbody2D body; // 0x58
	
		// Properties
		public float BeatHeight { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D20-0x0000000180487D30 0x0000000180DD2D90-0x0000000180DD2DA0
		public float BarHeight { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487CF0-0x0000000180487D00 0x0000000180DD2D30-0x0000000180DD2D40
	
		// Constructors
		public PianoRollController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(PianoSong song, PianoController parentController); // 0x000000018152E100-0x000000018152E170
		private void Create(); // 0x000000018152DDA0-0x000000018152DFE0
		public void QuickGameUpdate(); // 0x000000018152E040-0x000000018152E100
		public Vector2 GetNotePosition(PianoSong.Note note); // 0x000000018152DFE0-0x000000018152E040
	}
}

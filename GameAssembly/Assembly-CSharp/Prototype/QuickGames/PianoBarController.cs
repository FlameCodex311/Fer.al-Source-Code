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
	public class PianoBarController : MonoBehaviour // TypeDefIndex: 16190
	{
		// Fields
		public GameObject pianoBeatPrefab; // 0x20
		private PianoSong.Bar bar; // 0x28
		private PianoRollController parentController; // 0x30
		private List<PianoNoteController> noteControllers; // 0x38
	
		// Constructors
		public PianoBarController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(PianoSong.Bar bar, PianoRollController parentController); // 0x000000018152BE70-0x000000018152BE80
		public void AddNotes(); // 0x000000018152B860-0x000000018152BE70
	}
}

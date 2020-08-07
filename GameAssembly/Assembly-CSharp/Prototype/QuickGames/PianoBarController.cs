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
	public class PianoBarController : MonoBehaviour // TypeDefIndex: 14932
	{
		// Fields
		public GameObject pianoBeatPrefab; // 0x20
		private PianoSong.Bar bar; // 0x28
		private PianoRollController parentController; // 0x30
		private List<PianoNoteController> noteControllers; // 0x38
	
		// Constructors
		public PianoBarController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(PianoSong.Bar bar, PianoRollController parentController); // 0x0000000180A4E450-0x0000000180A4E460
		public void AddNotes(); // 0x0000000180A4DE80-0x0000000180A4E450
	}
}

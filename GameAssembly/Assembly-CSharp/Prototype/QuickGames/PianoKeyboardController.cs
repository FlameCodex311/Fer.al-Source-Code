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
	public class PianoKeyboardController : MonoBehaviour // TypeDefIndex: 16196
	{
		// Fields
		public List<PianoKeyController> keyControllers; // 0x20
		public NoteTriggerController noteTrigger_Excellent; // 0x28
		public NoteTriggerController noteTrigger_Good; // 0x30
		public NoteTriggerController noteTrigger_Fair; // 0x38
		public NoteTriggerController noteTrigger_Bad; // 0x40
		public NoteTriggerController noteTrigger_Delete; // 0x48
		private PianoController parentController; // 0x50
		private List<bool> keyStates; // 0x58
	
		// Constructors
		public PianoKeyboardController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(PianoController pianoController); // 0x000000018152D640-0x000000018152D810
		public void UpdateInput(); // 0x000000018152D810-0x000000018152DD40
		public void NoteTriggerEntered(int level, GameObject beatObject); // 0x000000018152D380-0x000000018152D640
	}
}

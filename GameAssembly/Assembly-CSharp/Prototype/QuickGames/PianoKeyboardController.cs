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
	public class PianoKeyboardController : MonoBehaviour // TypeDefIndex: 14939
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
		public PianoKeyboardController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(PianoController pianoController); // 0x0000000180A4FC10-0x0000000180A4FDC0
		public void UpdateInput(); // 0x0000000180A4FDC0-0x0000000180A502B0
		public void NoteTriggerEntered(int level, GameObject beatObject); // 0x0000000180A4F960-0x0000000180A4FC10
	}
}

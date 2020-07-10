/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PianoController : QuickGamesBase // TypeDefIndex: 16192
	{
		// Fields
		public List<PianoKeyController> keys; // 0xF0
		public PianoRollController pianoRollController; // 0xF8
		public PianoKeyboardController keyboardController; // 0x100
		private PianoSong song; // 0x108
		private bool isPlaying; // 0x110
		private int score; // 0x114
		private UnityEngine.UI.Text scoreText; // 0x118
		private UnityEngine.UI.Text popupText; // 0x120
		private Color popupStartColor; // 0x128
		private Color popupEndColor; // 0x138
		private float popupTime; // 0x148
		private float elapsedPopupTime; // 0x14C
		private bool showingPopup; // 0x150
		private bool popupChanged; // 0x151
		private IEnumerator popupCoroutine; // 0x158
		private int targetScore; // 0x160
		private Rect meterRect; // 0x164
		private RectTransform meterLevelRectTransform; // 0x178
		private string[] popupMessages; // 0x180
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartSong>d__20 : IEnumerator<object> // TypeDefIndex: 16193
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PianoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartSong>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181540680-0x0000000181540740
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181540740-0x0000000181540790
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__27 : IEnumerator<object> // TypeDefIndex: 16194
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PianoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153FCB0-0x000000018153FD50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153FDA0-0x000000018153FDF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FadePopupMessage>d__30 : IEnumerator<object> // TypeDefIndex: 16195
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PianoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FadePopupMessage>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153B060-0x000000018153B1A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153B1A0-0x000000018153B1F0
		}
	
		// Constructors
		public PianoController(); // 0x000000018152D090-0x000000018152D290
	
		// Methods
		public override void MStart(); // 0x000000018152C750-0x000000018152CBA0
		private void Initialize(); // 0x000000018152C5D0-0x000000018152C750
		[IteratorStateMachine] // 0x0000000180148CE0-0x0000000180148D30
		private IEnumerator StartSong(); // 0x000000018152CED0-0x000000018152CF30
		private PianoSong CreateSong(); // 0x000000018152BEC0-0x000000018152C540
		public void NoteSuccess(int quality); // 0x000000018152CC00-0x000000018152CC70
		public void NoteFailure(); // 0x000000018152CBA0-0x000000018152CC00
		public float GetNoteX(PianoSong.Note note); // 0x000000018152C5A0-0x000000018152C5D0
		public override void QuickGameUpdate(); // 0x000000018152CD60-0x000000018152CE70
		[IteratorStateMachine] // 0x0000000180148FD0-0x0000000180149020
		public override IEnumerator ShowResults(); // 0x000000018152CE70-0x000000018152CED0
		private void UpdateUI(); // 0x000000018152CF30-0x000000018152D090
		private void PopupMessage(string message); // 0x000000018152CC70-0x000000018152CD60
		[IteratorStateMachine] // 0x00000001801491D0-0x0000000180149220
		private IEnumerator FadePopupMessage(); // 0x000000018152C540-0x000000018152C5A0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181527E70-0x0000000181527ED0
	}
}

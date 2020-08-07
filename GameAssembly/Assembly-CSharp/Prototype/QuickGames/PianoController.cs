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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PianoController : QuickGamesBase // TypeDefIndex: 14934
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartSong>d__20 : IEnumerator<object> // TypeDefIndex: 14935
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PianoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartSong>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A61590-0x0000000180A61650
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A61650-0x0000000180A616A0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__27 : IEnumerator<object> // TypeDefIndex: 14936
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PianoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A60F90-0x0000000180A61030
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A61080-0x0000000180A610D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FadePopupMessage>d__30 : IEnumerator<object> // TypeDefIndex: 14937
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PianoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FadePopupMessage>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5C9C0-0x0000000180A5CAF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5CAF0-0x0000000180A5CB40
		}
	
		// Constructors
		public PianoController(); // 0x0000000180A4F680-0x0000000180A4F860
	
		// Methods
		public override void MStart(); // 0x0000000180A4EEC0-0x0000000180A4F1A0
		private void Initialize(); // 0x0000000180A4EBC0-0x0000000180A4EEC0
		[IteratorStateMachine] // 0x0000000180268360-0x00000001802683B0
		private IEnumerator StartSong(); // 0x0000000180A4F4C0-0x0000000180A4F520
		private PianoSong CreateSong(); // 0x0000000180A4E4B0-0x0000000180A4EB30
		public void NoteSuccess(int quality); // 0x0000000180A4F200-0x0000000180A4F270
		public void NoteFailure(); // 0x0000000180A4F1A0-0x0000000180A4F200
		public float GetNoteX(PianoSong.Note note); // 0x0000000180A4EB90-0x0000000180A4EBC0
		public override void QuickGameUpdate(); // 0x0000000180A4F360-0x0000000180A4F460
		[IteratorStateMachine] // 0x0000000180268470-0x00000001802684C0
		public override IEnumerator ShowResults(); // 0x0000000180A4F460-0x0000000180A4F4C0
		private void UpdateUI(); // 0x0000000180A4F520-0x0000000180A4F680
		private void PopupMessage(string message); // 0x0000000180A4F270-0x0000000180A4F360
		[IteratorStateMachine] // 0x00000001802685B0-0x0000000180268600
		private IEnumerator FadePopupMessage(); // 0x0000000180A4EB30-0x0000000180A4EB90
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}

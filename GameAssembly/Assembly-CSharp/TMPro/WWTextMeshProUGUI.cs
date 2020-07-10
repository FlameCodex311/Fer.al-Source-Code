/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace TMPro
{
	public class WWTextMeshProUGUI : TextMeshProUGUI // TypeDefIndex: 15371
	{
		// Fields
		public bool showUnlocalized; // 0xBE8
		[RootSelector] // 0x00000001800CB5D0-0x00000001800CB630
		public string localizationDefID; // 0xBF0
		[RootSelector] // 0x00000001800CB820-0x00000001800CB880
		public string systemLocalizationDefID; // 0xBF8
		public bool useSystemLocalization; // 0xC00
		private bool _hasBeenLocalized; // 0xC01
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <LocalizeOnLoad>d__7 : IEnumerator<object> // TypeDefIndex: 15372
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WWTextMeshProUGUI <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <LocalizeOnLoad>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181211FE0-0x00000001812121F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001812121F0-0x0000000181212240
		}
	
		// Constructors
		public WWTextMeshProUGUI(); // 0x0000000181213DD0-0x0000000181213DE0
	
		// Methods
		public void ClearAssetReferences(); // 0x0000000181213D40-0x0000000181213D70
		protected override void Awake(); // 0x0000000181213C40-0x0000000181213D40
		[IteratorStateMachine] // 0x00000001800CD0B0-0x00000001800CD100
		private IEnumerator LocalizeOnLoad(); // 0x0000000181213D70-0x0000000181213DD0
	}
}

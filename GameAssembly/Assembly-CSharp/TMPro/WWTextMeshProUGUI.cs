/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace TMPro
{
	public class WWTextMeshProUGUI : TextMeshProUGUI // TypeDefIndex: 16038
	{
		// Fields
		public bool showUnlocalized; // 0xBE8
		[RootSelector] // 0x0000000180276840-0x00000001802768A0
		public string localizationDefID; // 0xBF0
		[RootSelector] // 0x00000001802769A0-0x0000000180276A00
		public string systemLocalizationDefID; // 0xBF8
		public bool useSystemLocalization; // 0xC00
		private bool _hasBeenLocalized; // 0xC01
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <LocalizeOnLoad>d__7 : IEnumerator<object> // TypeDefIndex: 16039
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WWTextMeshProUGUI <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <LocalizeOnLoad>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180961260-0x0000000180961470
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180961470-0x00000001809614C0
		}
	
		// Constructors
		public WWTextMeshProUGUI(); // 0x0000000180962C30-0x0000000180962C40
	
		// Methods
		public void ClearAssetReferences(); // 0x0000000180962BA0-0x0000000180962BD0
		protected override void Awake(); // 0x0000000180962AA0-0x0000000180962BA0
		[IteratorStateMachine] // 0x0000000180283E80-0x0000000180283ED0
		private IEnumerator LocalizeOnLoad(); // 0x0000000180962BD0-0x0000000180962C30
	}
}

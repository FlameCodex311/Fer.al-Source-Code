/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class SimpleCombinedKeyboardMouseRemapping : UnityEngine.MonoBehaviour // TypeDefIndex: 9247
	{
		// Fields
		private const string category = "Default"; // Metadata: 0x00744DED
		private const string layout = "Default"; // Metadata: 0x00744DF8
		private const string uiCategory = "UI"; // Metadata: 0x00744E03
		private InputMapper inputMapper_keyboard; // 0x18
		private InputMapper inputMapper_mouse; // 0x20
		public GameObject buttonPrefab; // 0x28
		public GameObject textPrefab; // 0x30
		public RectTransform fieldGroupTransform; // 0x38
		public RectTransform actionGroupTransform; // 0x40
		public UnityEngine.UI.Text controllerNameUIText; // 0x48
		public UnityEngine.UI.Text statusUIText; // 0x50
		private List<Row> rows; // 0x58
		private TargetMapping _replaceTargetMapping; // 0x60
	
		// Properties
		private Player player { get; } // 0x00000001815BFA80-0x00000001815BFAF0 
	
		// Nested types
		private class Row // TypeDefIndex: 9248
		{
			// Fields
			public InputAction action; // 0x10
			public AxisRange actionRange; // 0x18
			public Button button; // 0x20
			public UnityEngine.UI.Text text; // 0x28
	
			// Constructors
			public Row(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		private struct TargetMapping // TypeDefIndex: 9249
		{
			// Fields
			public ControllerMap controllerMap; // 0x00
			public int actionElementMapId; // 0x08
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 9250
		{
			// Fields
			public int index; // 0x10
			public int actionElementMapId; // 0x14
			public SimpleCombinedKeyboardMouseRemapping <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass17_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <RedrawUI>b__0(); // 0x00000001815C2180-0x00000001815C21B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartListeningDelayed>d__22 : IEnumerator<object> // TypeDefIndex: 9251
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SimpleCombinedKeyboardMouseRemapping <>4__this; // 0x20
			public int index; // 0x28
			public ControllerMap keyboardMap; // 0x30
			public int actionElementMapToReplaceId; // 0x38
			public ControllerMap mouseMap; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartListeningDelayed>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815C1D70-0x00000001815C2130
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815C2130-0x00000001815C2180
		}
	
		// Constructors
		public SimpleCombinedKeyboardMouseRemapping(); // 0x00000001815BF9E0-0x00000001815BFA80
	
		// Methods
		private void OnEnable(); // 0x00000001815BEDA0-0x00000001815BF0C0
		private void OnDisable(); // 0x00000001815BED30-0x00000001815BEDA0
		private void RedrawUI(); // 0x00000001815BF460-0x00000001815BF940
		private void ClearUI(); // 0x00000001815BE3B0-0x00000001815BE4D0
		private void InitializeUI(); // 0x00000001815BE6E0-0x00000001815BED30
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label); // 0x00000001815BE4D0-0x00000001815BE6E0
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId); // 0x00000001815BF0C0-0x00000001815BF2D0
		[IteratorStateMachine] // 0x00000001801069F0-0x0000000180106A40
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId); // 0x00000001815BF940-0x00000001815BF9E0
		private void OnInputMapped(InputMapper.InputMappedEventData data); // 0x00000001815BF2D0-0x00000001815BF360
		private void OnStopped(InputMapper.StoppedEventData data); // 0x00000001815BF360-0x00000001815BF460
	}
}

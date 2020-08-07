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

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class SimpleCombinedKeyboardMouseRemapping : UnityEngine.MonoBehaviour // TypeDefIndex: 9413
	{
		// Fields
		private const string category = "Default"; // Metadata: 0x00779ADB
		private const string layout = "Default"; // Metadata: 0x00779AE6
		private const string uiCategory = "UI"; // Metadata: 0x00779AF1
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
		private Player player { get; } // 0x000000018106B7A0-0x000000018106B800 
	
		// Nested types
		private class Row // TypeDefIndex: 9414
		{
			// Fields
			public InputAction action; // 0x10
			public AxisRange actionRange; // 0x18
			public Button button; // 0x20
			public UnityEngine.UI.Text text; // 0x28
	
			// Constructors
			public Row(); // 0x0000000180373240-0x0000000180373250
		}
	
		private struct TargetMapping // TypeDefIndex: 9415
		{
			// Fields
			public ControllerMap controllerMap; // 0x00
			public int actionElementMapId; // 0x08
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 9416
		{
			// Fields
			public int index; // 0x10
			public int actionElementMapId; // 0x14
			public SimpleCombinedKeyboardMouseRemapping <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass17_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <RedrawUI>b__0(); // 0x000000018106ED10-0x000000018106ED40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartListeningDelayed>d__22 : IEnumerator<object> // TypeDefIndex: 9417
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartListeningDelayed>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018106E650-0x000000018106E9F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018106E9F0-0x000000018106EA40
		}
	
		// Constructors
		public SimpleCombinedKeyboardMouseRemapping(); // 0x000000018106B700-0x000000018106B7A0
	
		// Methods
		private void OnEnable(); // 0x000000018106AB10-0x000000018106AE20
		private void OnDisable(); // 0x000000018106AAA0-0x000000018106AB10
		private void RedrawUI(); // 0x000000018106B1B0-0x000000018106B660
		private void ClearUI(); // 0x000000018106A150-0x000000018106A270
		private void InitializeUI(); // 0x000000018106A470-0x000000018106AAA0
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label); // 0x000000018106A270-0x000000018106A470
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId); // 0x000000018106AE20-0x000000018106B030
		[IteratorStateMachine] // 0x0000000180268600-0x0000000180268650
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId); // 0x000000018106B660-0x000000018106B700
		private void OnInputMapped(InputMapper.InputMappedEventData data); // 0x000000018106B030-0x000000018106B0C0
		private void OnStopped(InputMapper.StoppedEventData data); // 0x000000018106B0C0-0x000000018106B1B0
	}
}

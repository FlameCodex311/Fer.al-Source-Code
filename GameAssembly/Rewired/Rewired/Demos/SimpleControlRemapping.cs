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
	public class SimpleControlRemapping : UnityEngine.MonoBehaviour // TypeDefIndex: 9252
	{
		// Fields
		private const string category = "Default"; // Metadata: 0x00744E09
		private const string layout = "Default"; // Metadata: 0x00744E14
		private const string uiCategory = "UI"; // Metadata: 0x00744E1F
		private InputMapper inputMapper; // 0x18
		public GameObject buttonPrefab; // 0x20
		public GameObject textPrefab; // 0x28
		public RectTransform fieldGroupTransform; // 0x30
		public RectTransform actionGroupTransform; // 0x38
		public UnityEngine.UI.Text controllerNameUIText; // 0x40
		public UnityEngine.UI.Text statusUIText; // 0x48
		private ControllerType selectedControllerType; // 0x50
		private int selectedControllerId; // 0x54
		private List<Row> rows; // 0x58
	
		// Properties
		private Player player { get; } // 0x00000001815C1570-0x00000001815C15E0 
		private ControllerMap controllerMap { get; } // 0x00000001815C1380-0x00000001815C14D0 
		private Controller controller { get; } // 0x00000001815C14D0-0x00000001815C1570 
	
		// Nested types
		private class Row // TypeDefIndex: 9253
		{
			// Fields
			public InputAction action; // 0x10
			public AxisRange actionRange; // 0x18
			public Button button; // 0x20
			public UnityEngine.UI.Text text; // 0x28
	
			// Constructors
			public Row(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 9254
		{
			// Fields
			public int index; // 0x10
			public int actionElementMapId; // 0x14
			public SimpleControlRemapping <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <RedrawUI>b__0(); // 0x0000000181BCCD00-0x0000000181BCCD30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartListeningDelayed>d__28 : IEnumerator<object> // TypeDefIndex: 9255
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SimpleControlRemapping <>4__this; // 0x20
			public int index; // 0x28
			public int actionElementMapToReplaceId; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartListeningDelayed>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181BCCA20-0x0000000181BCCCB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181BCCCB0-0x0000000181BCCD00
		}
	
		// Constructors
		public SimpleControlRemapping(); // 0x00000001815C1300-0x00000001815C1380
	
		// Methods
		private void OnEnable(); // 0x00000001815C05B0-0x00000001815C0820
		private void OnDisable(); // 0x00000001815C04C0-0x00000001815C05B0
		private void RedrawUI(); // 0x00000001815C0A10-0x00000001815C10E0
		private void ClearUI(); // 0x00000001815BFAF0-0x00000001815BFC40
		private void InitializeUI(); // 0x00000001815BFE50-0x00000001815C04A0
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label); // 0x00000001815BFC40-0x00000001815BFE50
		private void SetSelectedController(ControllerType controllerType); // 0x00000001815C10E0-0x00000001815C1270
		public void OnControllerSelected(int controllerType); // 0x00000001815C04B0-0x00000001815C04C0
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId); // 0x00000001815C0820-0x00000001815C0900
		[IteratorStateMachine] // 0x0000000180107610-0x0000000180107660
		private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId); // 0x00000001815C1270-0x00000001815C1300
		private void OnControllerChanged(ControllerStatusChangedEventArgs args); // 0x00000001815C04A0-0x00000001815C04B0
		private void OnInputMapped(InputMapper.InputMappedEventData data); // 0x00000001815C0900-0x00000001815C0910
		private void OnStopped(InputMapper.StoppedEventData data); // 0x00000001815C0910-0x00000001815C0A10
	}
}

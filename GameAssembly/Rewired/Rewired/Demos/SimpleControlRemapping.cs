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
	public class SimpleControlRemapping : UnityEngine.MonoBehaviour // TypeDefIndex: 9418
	{
		// Fields
		private const string category = "Default"; // Metadata: 0x00779AF7
		private const string layout = "Default"; // Metadata: 0x00779B02
		private const string uiCategory = "UI"; // Metadata: 0x00779B0D
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
		private Player player { get; } // 0x000000018106D110-0x000000018106D170 
		private ControllerMap controllerMap { get; } // 0x000000018106CF40-0x000000018106D080 
		private Controller controller { get; } // 0x000000018106D080-0x000000018106D110 
	
		// Nested types
		private class Row // TypeDefIndex: 9419
		{
			// Fields
			public InputAction action; // 0x10
			public AxisRange actionRange; // 0x18
			public Button button; // 0x20
			public UnityEngine.UI.Text text; // 0x28
	
			// Constructors
			public Row(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 9420
		{
			// Fields
			public int index; // 0x10
			public int actionElementMapId; // 0x14
			public SimpleControlRemapping <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <RedrawUI>b__0(); // 0x000000018106ED40-0x000000018106EE20
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartListeningDelayed>d__28 : IEnumerator<object> // TypeDefIndex: 9421
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SimpleControlRemapping <>4__this; // 0x20
			public int index; // 0x28
			public int actionElementMapToReplaceId; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartListeningDelayed>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018106EA40-0x000000018106ECC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018106ECC0-0x000000018106ED10
		}
	
		// Constructors
		public SimpleControlRemapping(); // 0x000000018106CEC0-0x000000018106CF40
	
		// Methods
		private void OnEnable(); // 0x000000018106C290-0x000000018106C500
		private void OnDisable(); // 0x000000018106C1A0-0x000000018106C290
		private void RedrawUI(); // 0x000000018106C6D0-0x000000018106CC50
		private void ClearUI(); // 0x000000018106B800-0x000000018106B950
		private void InitializeUI(); // 0x000000018106BB50-0x000000018106C180
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label); // 0x000000018106B950-0x000000018106BB50
		private void SetSelectedController(ControllerType controllerType); // 0x000000018106CC50-0x000000018106CE40
		public void OnControllerSelected(int controllerType); // 0x000000018106C190-0x000000018106C1A0
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId); // 0x000000018106C500-0x000000018106C5D0
		[IteratorStateMachine] // 0x0000000180269420-0x0000000180269470
		private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId); // 0x000000018106CE40-0x000000018106CEC0
		private void OnControllerChanged(ControllerStatusChangedEventArgs args); // 0x000000018106C180-0x000000018106C190
		private void OnInputMapped(InputMapper.InputMappedEventData data); // 0x000000018106C5D0-0x000000018106C5E0
		private void OnStopped(InputMapper.StoppedEventData data); // 0x000000018106C5E0-0x000000018106C6D0
	}
}

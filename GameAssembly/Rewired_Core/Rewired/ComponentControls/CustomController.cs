/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801DA220-0x00000001801DA260
	[DisallowMultipleComponent] // 0x00000001801DA220-0x00000001801DA260
	public class CustomController : ComponentController // TypeDefIndex: 5958
	{
		// Fields
		[CustomObfuscation] // 0x00000001801DA340-0x00000001801DA3A0
		[SerializeField] // 0x00000001801DA340-0x00000001801DA3A0
		[Tooltip] // 0x00000001801DA340-0x00000001801DA3A0
		private InputManager_Base _rewiredInputManager; // 0x28
		[CustomObfuscation] // 0x00000001801DA6E0-0x00000001801DA740
		[SerializeField] // 0x00000001801DA6E0-0x00000001801DA740
		[Tooltip] // 0x00000001801DA6E0-0x00000001801DA740
		private CustomControllerSelector _customControllerSelector; // 0x30
		[CustomObfuscation] // 0x00000001801DAC20-0x00000001801DAC80
		[SerializeField] // 0x00000001801DAC20-0x00000001801DAC80
		[Tooltip] // 0x00000001801DAC20-0x00000001801DAC80
		private CreateCustomControllerSettings _createCustomControllerSettings; // 0x38
		private List<InputEvent> _inputEvents; // 0x40
		[NonSerialized]
		private int _createdCustomControllerId; // 0x48
		private Action _InputSourceUpdateEvent; // 0x50
	
		// Properties
		public InputManager_Base rewiredInputManager { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x0000000180917280-0x0000000180917340
		public CustomControllerSelector customControllerSelector { get; } // 0x00000001803745C0-0x00000001803745D0 
		public CreateCustomControllerSettings createCustomControllerSettings { get; } // 0x00000001803743D0-0x00000001803743E0 
	
		// Events
		internal event Action InputSourceUpdateEvent {
			add; // 0x0000000180917180-0x0000000180917200
			remove; // 0x0000000180917200-0x0000000180917280
		}
	
		// Nested types
		[Serializable]
		public class CreateCustomControllerSettings // TypeDefIndex: 5959
		{
			// Fields
			[CustomObfuscation] // 0x00000001801DB950-0x00000001801DB9B0
			[SerializeField] // 0x00000001801DB950-0x00000001801DB9B0
			[Tooltip] // 0x00000001801DB950-0x00000001801DB9B0
			private bool _createCustomController; // 0x10
			[CustomObfuscation] // 0x00000001801DBC40-0x00000001801DBCA0
			[SerializeField] // 0x00000001801DBC40-0x00000001801DBCA0
			[Tooltip] // 0x00000001801DBC40-0x00000001801DBCA0
			private int _customControllerSourceId; // 0x14
			[CustomObfuscation] // 0x00000001801DD0E0-0x00000001801DD140
			[SerializeField] // 0x00000001801DD0E0-0x00000001801DD140
			[Tooltip] // 0x00000001801DD0E0-0x00000001801DD140
			private int _assignToPlayerId; // 0x18
			[CustomObfuscation] // 0x00000001801DD430-0x00000001801DD490
			[SerializeField] // 0x00000001801DD430-0x00000001801DD490
			[Tooltip] // 0x00000001801DD430-0x00000001801DD490
			private bool _destroyCustomController; // 0x1C
	
			// Properties
			public bool createCustomController { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x0000000180911190-0x00000001809111D0
			public int customControllerSourceId { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
			public int assignToPlayerId { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
			public bool destroyCustomController { get; set; } // 0x000000018041B650-0x000000018041B660 0x000000018041B6E0-0x000000018041B6F0
	
			// Constructors
			public CreateCustomControllerSettings(); // 0x0000000180911170-0x0000000180911190
		}
	
		private struct InputEvent // TypeDefIndex: 5960
		{
			// Fields
			public CustomControllerElementSelector.ElementType elementType; // 0x00
			public int elementIndex; // 0x04
			public float value; // 0x08
	
			// Constructors
			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, float value); // 0x0000000180022490-0x00000001800224A0
			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, bool value); // 0x00000001800224A0-0x0000000180022610
	
			// Methods
			public bool TargetMatches(CustomControllerElementSelector.ElementType elementType, int elementIndex); // 0x0000000180022480-0x0000000180022490
			public void Merge(float value); // 0x0000000180022450-0x0000000180022480
			public void Merge(bool value); // 0x0000000180022440-0x0000000180022450
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal CustomController(); // 0x0000000180917080-0x0000000180917180
	
		// Methods
		public Rewired.CustomController GetCustomController(); // 0x0000000180915420-0x0000000180915430
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnEnable(); // 0x0000000180910D20-0x0000000180910E10
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDisable(); // 0x0000000180915610-0x0000000180915680
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnValidate(); // 0x0000000180915A30-0x0000000180915AC0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void OnDestroy(); // 0x0000000180915430-0x0000000180915610
		internal override bool OnInitialize(); // 0x0000000180915680-0x00000001809157C0
		internal override void OnSubscribeEvents(); // 0x0000000180915880-0x00000001809159B0
		internal override void OnUnsubscribeEvents(); // 0x00000001809159B0-0x0000000180915A30
		public override void ClearControlValues(); // 0x00000001809146B0-0x0000000180914710
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual bool GetUseCustomController(); // 0x0000000180380B60-0x0000000180380B70
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal virtual void SetUseCustomController(bool value); // 0x00000001803774A0-0x00000001803774B0
		internal void SetAxisValue(CustomControllerElementSelector element, float value); // 0x0000000180915D80-0x0000000180916070
		internal void SetButtonValue(CustomControllerElementSelector element, bool value); // 0x0000000180916070-0x0000000180916870
		internal void ClearElementValue(CustomControllerElementTargetSet targetSet); // 0x0000000180914D30-0x0000000180914E20
		internal void ClearElementValue(CustomControllerElementTarget target); // 0x00000001809149F0-0x0000000180914D30
		internal void ClearElementValue(CustomControllerElementSelector element); // 0x0000000180914710-0x00000001809149F0
		internal int ElementExists_Editor(CustomControllerElementSelector element); // 0x0000000180914E20-0x0000000180915110
		internal bool ElementExists(CustomControllerElementSelector element); // 0x0000000180915110-0x0000000180915160
		internal bool ValidateElements(CustomControllerElementTargetSet targetSet); // 0x0000000180916FA0-0x0000000180917080
		internal bool ValidateElement(CustomControllerElementTarget target); // 0x0000000180916F80-0x0000000180916FA0
		internal bool ValidateElement(CustomControllerElementSelector element); // 0x0000000180916BE0-0x0000000180916F80
		private void OnSetProperty(); // 0x00000001809157F0-0x0000000180915880
		private bool CheckIsRewiredReady(); // 0x00000001809145E0-0x00000001809146B0
		private void ProcessInputEvents(); // 0x0000000180915AC0-0x0000000180915D80
		private Rewired.CustomController GetCustomController(bool warn); // 0x0000000180915160-0x0000000180915420
		private void TryAssignCustomControllerToPlayer(Rewired.CustomController customController); // 0x0000000180916870-0x0000000180916A30
		private void TryDestroyCustomController(); // 0x0000000180916A30-0x0000000180916BE0
		private void OnInputSourceUpdate(); // 0x00000001809157C0-0x00000001809157F0
	}
}

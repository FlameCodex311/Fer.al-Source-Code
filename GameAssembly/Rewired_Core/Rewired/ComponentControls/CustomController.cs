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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation] // 0x000000018013F010-0x000000018013F050
	[DisallowMultipleComponent] // 0x000000018013F010-0x000000018013F050
	public class CustomController : ComponentController // TypeDefIndex: 5799
	{
		// Fields
		[CustomObfuscation] // 0x000000018013F2D0-0x000000018013F330
		[SerializeField] // 0x000000018013F2D0-0x000000018013F330
		[Tooltip] // 0x000000018013F2D0-0x000000018013F330
		private InputManager_Base _rewiredInputManager; // 0x28
		[CustomObfuscation] // 0x000000018013F700-0x000000018013F760
		[SerializeField] // 0x000000018013F700-0x000000018013F760
		[Tooltip] // 0x000000018013F700-0x000000018013F760
		private CustomControllerSelector _customControllerSelector; // 0x30
		[CustomObfuscation] // 0x000000018013F8B0-0x000000018013F910
		[SerializeField] // 0x000000018013F8B0-0x000000018013F910
		[Tooltip] // 0x000000018013F8B0-0x000000018013F910
		private CreateCustomControllerSettings _createCustomControllerSettings; // 0x38
		private List<InputEvent> _inputEvents; // 0x40
		[NonSerialized]
		private int _createdCustomControllerId; // 0x48
		private Action _InputSourceUpdateEvent; // 0x50
	
		// Properties
		public InputManager_Base rewiredInputManager { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000181439970-0x0000000181439A30
		public CustomControllerSelector customControllerSelector { get; } // 0x0000000180397720-0x0000000180397730 
		public CreateCustomControllerSettings createCustomControllerSettings { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
		// Events
		internal event Action InputSourceUpdateEvent {
			add; // 0x0000000181439870-0x00000001814398F0
			remove; // 0x00000001814398F0-0x0000000181439970
		}
	
		// Nested types
		[Serializable]
		public class CreateCustomControllerSettings // TypeDefIndex: 5800
		{
			// Fields
			[CustomObfuscation] // 0x0000000180140050-0x00000001801400B0
			[SerializeField] // 0x0000000180140050-0x00000001801400B0
			[Tooltip] // 0x0000000180140050-0x00000001801400B0
			private bool _createCustomController; // 0x10
			[CustomObfuscation] // 0x0000000180140280-0x00000001801402E0
			[SerializeField] // 0x0000000180140280-0x00000001801402E0
			[Tooltip] // 0x0000000180140280-0x00000001801402E0
			private int _customControllerSourceId; // 0x14
			[CustomObfuscation] // 0x0000000180140630-0x0000000180140690
			[SerializeField] // 0x0000000180140630-0x0000000180140690
			[Tooltip] // 0x0000000180140630-0x0000000180140690
			private int _assignToPlayerId; // 0x18
			[CustomObfuscation] // 0x00000001801408B0-0x0000000180140910
			[SerializeField] // 0x00000001801408B0-0x0000000180140910
			[Tooltip] // 0x00000001801408B0-0x0000000180140910
			private bool _destroyCustomController; // 0x1C
	
			// Properties
			public bool createCustomController { get; set; } // 0x0000000180375540-0x0000000180375550 0x0000000181433720-0x0000000181433760
			public int customControllerSourceId { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
			public int assignToPlayerId { get; set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
			public bool destroyCustomController { get; set; } // 0x000000018036CB20-0x000000018036CB30 0x000000018036CBC0-0x000000018036CBD0
	
			// Constructors
			public CreateCustomControllerSettings(); // 0x0000000181433700-0x0000000181433720
		}
	
		private struct InputEvent // TypeDefIndex: 5801
		{
			// Fields
			public CustomControllerElementSelector.ElementType elementType; // 0x00
			public int elementIndex; // 0x04
			public float value; // 0x08
	
			// Constructors
			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, float value); // 0x0000000180006720-0x0000000180006730
			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, bool value); // 0x0000000180228B60-0x0000000180228B90
	
			// Methods
			public bool TargetMatches(CustomControllerElementSelector.ElementType elementType, int elementIndex); // 0x0000000180228B50-0x0000000180228B60
			public void Merge(float value); // 0x0000000180228B20-0x0000000180228B50
			public void Merge(bool value); // 0x0000000180228B10-0x0000000180228B20
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal CustomController(); // 0x0000000181439770-0x0000000181439870
	
		// Methods
		public Rewired.CustomController GetCustomController(); // 0x0000000181437AB0-0x0000000181437AC0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnEnable(); // 0x00000001814332C0-0x00000001814333B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDisable(); // 0x0000000181437CB0-0x0000000181437D20
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnValidate(); // 0x00000001814380D0-0x0000000181438160
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void OnDestroy(); // 0x0000000181437AC0-0x0000000181437CB0
		internal override bool OnInitialize(); // 0x0000000181437D20-0x0000000181437E60
		internal override void OnSubscribeEvents(); // 0x0000000181437F20-0x0000000181438050
		internal override void OnUnsubscribeEvents(); // 0x0000000181438050-0x00000001814380D0
		public override void ClearControlValues(); // 0x0000000181436D00-0x0000000181436D60
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual bool GetUseCustomController(); // 0x00000001803C29F0-0x00000001803C2A00
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal virtual void SetUseCustomController(bool value); // 0x00000001803581E0-0x00000001803581F0
		internal void SetAxisValue(CustomControllerElementSelector element, float value); // 0x0000000181438430-0x0000000181438720
		internal void SetButtonValue(CustomControllerElementSelector element, bool value); // 0x0000000181438720-0x0000000181438F30
		internal void ClearElementValue(CustomControllerElementTargetSet targetSet); // 0x00000001814373A0-0x0000000181437490
		internal void ClearElementValue(CustomControllerElementTarget target); // 0x0000000181437050-0x00000001814373A0
		internal void ClearElementValue(CustomControllerElementSelector element); // 0x0000000181436D60-0x0000000181437050
		internal int ElementExists_Editor(CustomControllerElementSelector element); // 0x0000000181437490-0x00000001814377A0
		internal bool ElementExists(CustomControllerElementSelector element); // 0x00000001814377A0-0x00000001814377F0
		internal bool ValidateElements(CustomControllerElementTargetSet targetSet); // 0x0000000181439690-0x0000000181439770
		internal bool ValidateElement(CustomControllerElementTarget target); // 0x0000000181439670-0x0000000181439690
		internal bool ValidateElement(CustomControllerElementSelector element); // 0x00000001814392B0-0x0000000181439670
		private void OnSetProperty(); // 0x0000000181437E90-0x0000000181437F20
		private bool CheckIsRewiredReady(); // 0x0000000181436C30-0x0000000181436D00
		private void ProcessInputEvents(); // 0x0000000181438160-0x0000000181438430
		private Rewired.CustomController GetCustomController(bool warn); // 0x00000001814377F0-0x0000000181437AB0
		private void TryAssignCustomControllerToPlayer(Rewired.CustomController customController); // 0x0000000181438F30-0x0000000181439100
		private void TryDestroyCustomController(); // 0x0000000181439100-0x00000001814392B0
		private void OnInputSourceUpdate(); // 0x0000000181437E60-0x0000000181437E90
	}
}

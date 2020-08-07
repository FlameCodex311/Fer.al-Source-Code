/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugButton_Field : MonoBehaviour // TypeDefIndex: 16248
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _fieldName; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Toggle _favoriteToggle; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Toggle _valueToggle; // 0x30
		[Header] // 0x00000001801CEE10-0x00000001801CEE60
		[SerializeField] // 0x00000001801CEE10-0x00000001801CEE60
		private TextMeshProUGUI _readonlyFieldValueText; // 0x38
		[Header] // 0x00000001801CEFD0-0x00000001801CF020
		[SerializeField] // 0x00000001801CEFD0-0x00000001801CF020
		private TMP_InputField _fieldValueInput; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _fieldValueHint; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayoutElement _inputTextAreaLayoutElement; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject _SetButton; // 0x58
		private DebugButtonPanel _panel; // 0x60
		private ConsoleFieldInfo _info; // 0x68
		private bool _readonly; // 0x70
		private bool _isBoolean; // 0x71
	
		// Properties
		private string _fieldValue { get; set; } // 0x00000001806635D0-0x0000000180663610 0x0000000180663610-0x0000000180663650
	
		// Constructors
		public DebugButton_Field(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(ConsoleFieldInfo inInfo, DebugButtonPanel inPanel); // 0x0000000180662AE0-0x0000000180663010
		private void OnDestroy(); // 0x00000001806629C0-0x0000000180662AD0
		public void BtnClicked_SetValue(); // 0x00000001806626A0-0x00000001806626F0
		public void BtnClicked_SetValue(string inValueText); // 0x00000001806626F0-0x00000001806629C0
		public void ToggleChanged_Favorite(); // 0x0000000180663010-0x0000000180663280
		public void ToggleChanged_Value(bool inIsOn); // 0x0000000180663280-0x0000000180663330
		private void OnSubmit(string inText); // 0x0000000180662AD0-0x0000000180662AE0
		private void Update(); // 0x00000001806634C0-0x00000001806635D0
		private void UpdateFieldValue(); // 0x0000000180663330-0x00000001806634C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugButton_Field : MonoBehaviour // TypeDefIndex: 15688
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _fieldName; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Toggle _favoriteToggle; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Toggle _valueToggle; // 0x30
		[Header] // 0x0000000180159470-0x00000001801594C0
		[SerializeField] // 0x0000000180159470-0x00000001801594C0
		private TextMeshProUGUI _readonlyFieldValueText; // 0x38
		[Header] // 0x0000000180159760-0x00000001801597B0
		[SerializeField] // 0x0000000180159760-0x00000001801597B0
		private TMP_InputField _fieldValueInput; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _fieldValueHint; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayoutElement _inputTextAreaLayoutElement; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject _SetButton; // 0x58
		private DebugButtonPanel _panel; // 0x60
		private ConsoleFieldInfo _info; // 0x68
		private bool _readonly; // 0x70
		private bool _isBoolean; // 0x71
	
		// Properties
		private string _fieldValue { get; set; } // 0x000000018111DA10-0x000000018111DA60 0x000000018111DA60-0x000000018111DAA0
	
		// Constructors
		public DebugButton_Field(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(ConsoleFieldInfo inInfo, DebugButtonPanel inPanel); // 0x000000018111CEE0-0x000000018111D430
		private void OnDestroy(); // 0x000000018111CDB0-0x000000018111CED0
		public void BtnClicked_SetValue(); // 0x000000018111CA70-0x000000018111CAD0
		public void BtnClicked_SetValue(string inValueText); // 0x000000018111CAD0-0x000000018111CDB0
		public void ToggleChanged_Favorite(); // 0x000000018111D430-0x000000018111D6B0
		public void ToggleChanged_Value(bool inIsOn); // 0x000000018111D6B0-0x000000018111D760
		private void OnSubmit(string inText); // 0x000000018111CED0-0x000000018111CEE0
		private void Update(); // 0x000000018111D900-0x000000018111DA10
		private void UpdateFieldValue(); // 0x000000018111D760-0x000000018111D900
	}
}

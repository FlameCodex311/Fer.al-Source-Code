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
	public class DebugButton_WParam : MonoBehaviour // TypeDefIndex: 16251
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _placeholderText; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_InputField _paramText; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Toggle _paramToggle; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _buttonText; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button _button; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Toggle _favoriteToggle; // 0x48
		private ConsoleMethodInfo _methodInfo; // 0x50
		private DebugButtonPanel _panel; // 0x58
	
		// Constructors
		public DebugButton_WParam(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(ConsoleMethodInfo inMethodInfo, DebugButtonPanel inPanel); // 0x0000000180664180-0x00000001806648B0
		private void OnButtonClicked(); // 0x0000000180663C60-0x0000000180664070
		public void ToggleChanged_Favorite(); // 0x00000001806648B0-0x0000000180664910
		private void OnDestroy(); // 0x0000000180664070-0x0000000180664180
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Setup>b__8_0(string inString); // 0x0000000180664910-0x0000000180664920
	}
}

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
	public class DebugButton_WParam : MonoBehaviour // TypeDefIndex: 15691
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _placeholderText; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_InputField _paramText; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Toggle _paramToggle; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _buttonText; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Button _button; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Toggle _favoriteToggle; // 0x48
		private ConsoleMethodInfo _methodInfo; // 0x50
		private DebugButtonPanel _panel; // 0x58
	
		// Constructors
		public DebugButton_WParam(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(ConsoleMethodInfo inMethodInfo, DebugButtonPanel inPanel); // 0x000000018111E650-0x000000018111EDC0
		private void OnButtonClicked(); // 0x000000018111E0F0-0x000000018111E530
		public void ToggleChanged_Favorite(); // 0x000000018111EDC0-0x000000018111EE30
		private void OnDestroy(); // 0x000000018111E530-0x000000018111E650
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Setup>b__8_0(string inString); // 0x000000018111EE30-0x000000018111EE40
	}
}

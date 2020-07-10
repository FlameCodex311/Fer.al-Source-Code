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
	public class DebugButton_Simple : MonoBehaviour // TypeDefIndex: 15690
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _buttonText; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Button _button; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Toggle _favoriteToggle; // 0x30
		private ConsoleMethodInfo _methodInfo; // 0x38
		private DebugButtonPanel _panel; // 0x40
	
		// Constructors
		public DebugButton_Simple(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(ConsoleMethodInfo inMethodInfo, DebugButtonPanel inPanel); // 0x000000018111DE00-0x000000018111E080
		private void OnButtonClicked(); // 0x000000018111DC40-0x000000018111DCE0
		public void ToggleChanged_Favorite(); // 0x000000018111E080-0x000000018111E0F0
		private void OnDestroy(); // 0x000000018111DCE0-0x000000018111DE00
	}
}

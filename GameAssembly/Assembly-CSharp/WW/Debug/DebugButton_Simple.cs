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
	public class DebugButton_Simple : MonoBehaviour // TypeDefIndex: 16250
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _buttonText; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button _button; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Toggle _favoriteToggle; // 0x30
		private ConsoleMethodInfo _methodInfo; // 0x38
		private DebugButtonPanel _panel; // 0x40
	
		// Constructors
		public DebugButton_Simple(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(ConsoleMethodInfo inMethodInfo, DebugButtonPanel inPanel); // 0x0000000180663990-0x0000000180663C00
		private void OnButtonClicked(); // 0x00000001806637E0-0x0000000180663880
		public void ToggleChanged_Favorite(); // 0x0000000180663C00-0x0000000180663C60
		private void OnDestroy(); // 0x0000000180663880-0x0000000180663990
	}
}

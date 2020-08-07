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
	public class DebugButton_Link : MonoBehaviour // TypeDefIndex: 16249
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _buttonText; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button _button; // 0x28
		private DebugButtonPanel _panel; // 0x30
		private string _path; // 0x38
	
		// Constructors
		public DebugButton_Link(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(string inPath, DebugButtonPanel inPanel); // 0x0000000180663680-0x00000001806637E0
		private void OnButtonClicked(); // 0x0000000180663650-0x0000000180663680
	}
}

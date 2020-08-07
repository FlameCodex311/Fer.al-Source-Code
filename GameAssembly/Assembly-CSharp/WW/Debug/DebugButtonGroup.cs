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
	public class DebugButtonGroup : MonoBehaviour // TypeDefIndex: 16241
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _headerText; // 0x20
		[Header] // 0x0000000180295B10-0x0000000180295B60
		[SerializeField] // 0x0000000180295B10-0x0000000180295B60
		private LayoutGroup _simpleButtonGroup; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayoutGroup _parameterButtonGroup; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayoutGroup _linkButtonGroup; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayoutGroup _fieldButtonGroup; // 0x40
		[Header] // 0x0000000180295F70-0x0000000180295FC0
		[SerializeField] // 0x0000000180295F70-0x0000000180295FC0
		private DebugButton_Simple _simpleButtonPrefab; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugButton_WParam _parameterButtonPrefab; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugButton_Link _linkButtonPrefab; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugButton_Field _fieldButtonPrefab; // 0x60
	
		// Constructors
		public DebugButtonGroup(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(DebugMethodGroup inGroup, DebugButtonPanel inPanel); // 0x000000018065FD50-0x00000001806603B0
	}
}

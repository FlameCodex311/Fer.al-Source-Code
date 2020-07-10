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
	public class DebugButtonGroup : MonoBehaviour // TypeDefIndex: 15694
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _headerText; // 0x20
		[Header] // 0x000000018015B180-0x000000018015B1D0
		[SerializeField] // 0x000000018015B180-0x000000018015B1D0
		private LayoutGroup _simpleButtonGroup; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayoutGroup _parameterButtonGroup; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayoutGroup _linkButtonGroup; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayoutGroup _fieldButtonGroup; // 0x40
		[Header] // 0x000000018015BB50-0x000000018015BBA0
		[SerializeField] // 0x000000018015BB50-0x000000018015BBA0
		private DebugButton_Simple _simpleButtonPrefab; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugButton_WParam _parameterButtonPrefab; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugButton_Link _linkButtonPrefab; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugButton_Field _fieldButtonPrefab; // 0x60
	
		// Constructors
		public DebugButtonGroup(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(DebugMethodGroup inGroup, DebugButtonPanel inPanel); // 0x000000018111A050-0x000000018111A6D0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugCustomPanel : MonoBehaviour // TypeDefIndex: 15709
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugConsoleWindow _console; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayoutGroup _contentParent; // 0x28
		private bool _layoutRebuildNeeded; // 0x30
	
		// Constructors
		public DebugCustomPanel(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		private void OnEnable(); // 0x00000001811240F0-0x0000000181124260
		private void OnDisable(); // 0x0000000181123F80-0x00000001811240F0
		private void LateUpdate(); // 0x0000000181123EE0-0x0000000181123F80
		private void OnShown(); // 0x0000000181124260-0x0000000181124290
		private void OnHidden(); // 0x00000001803581E0-0x00000001803581F0
		[ContextMenu] // 0x000000018015CD30-0x000000018015CD60
		public void ReportFieldUpdated(); // 0x0000000181124290-0x00000001811242A0
	}
}

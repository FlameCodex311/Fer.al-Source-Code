/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugCustomPanel : MonoBehaviour // TypeDefIndex: 16261
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugConsoleWindow _console; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayoutGroup _contentParent; // 0x28
		private bool _layoutRebuildNeeded; // 0x30
	
		// Constructors
		public DebugCustomPanel(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void OnEnable(); // 0x0000000180969110-0x0000000180969280
		private void OnDisable(); // 0x0000000180968FA0-0x0000000180969110
		private void LateUpdate(); // 0x0000000180968F00-0x0000000180968FA0
		private void OnShown(); // 0x0000000180969280-0x00000001809692B0
		private void OnHidden(); // 0x00000001803774A0-0x00000001803774B0
		[ContextMenu] // 0x00000001801CE000-0x00000001801CE030
		public void ReportFieldUpdated(); // 0x00000001809692B0-0x00000001809692C0
	}
}

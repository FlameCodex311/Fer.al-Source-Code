/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugCommandOutput : MonoBehaviour // TypeDefIndex: 15701
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int _lineCount; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text _text; // 0x28
		private StringBuilder _stringBuilder; // 0x30
		private List<string> _lines; // 0x38
	
		// Constructors
		public DebugCommandOutput(); // 0x000000018111F1F0-0x000000018111F280
	
		// Methods
		private void Start(); // 0x000000018111F1A0-0x000000018111F1F0
		public void Log(string inLogText); // 0x000000018111EED0-0x000000018111F1A0
		public void ClearLog(); // 0x000000018111EE40-0x000000018111EED0
	}
}

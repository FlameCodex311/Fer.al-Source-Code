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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugCommandOutput : MonoBehaviour // TypeDefIndex: 16252
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int _lineCount; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text _text; // 0x28
		private StringBuilder _stringBuilder; // 0x30
		private List<string> _lines; // 0x38
	
		// Constructors
		public DebugCommandOutput(); // 0x0000000180664CB0-0x0000000180664D40
	
		// Methods
		private void Start(); // 0x0000000180664C60-0x0000000180664CB0
		public void Log(string inLogText); // 0x00000001806649B0-0x0000000180664C60
		public void ClearLog(); // 0x0000000180664920-0x00000001806649B0
	}
}

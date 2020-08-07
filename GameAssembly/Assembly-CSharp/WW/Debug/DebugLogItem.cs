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
	public class DebugLogItem : MonoBehaviour // TypeDefIndex: 16264
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform transformComponent; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image imageComponent; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text logText; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image logTypeImage; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject logCountParent; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text logCountText; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject _copyBtn; // 0x50
		private DebugLogEntry logEntry; // 0x58
		private int entryIndex; // 0x60
		private DebugLogRecycledListView manager; // 0x68
	
		// Properties
		public RectTransform Transform { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public Image Image { get; } // 0x00000001803745B0-0x00000001803745C0 
		public int Index { get; } // 0x00000001804ADA80-0x00000001804ADA90 
	
		// Constructors
		public DebugLogItem(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Initialize(DebugLogRecycledListView manager); // 0x00000001804ADAC0-0x00000001804ADAD0
		public void SetContent(DebugLogEntry logEntry, int entryIndex, bool isExpanded); // 0x0000000180969940-0x0000000180969B20
		public void ShowCount(); // 0x0000000180969B20-0x0000000180969B90
		public void HideCount(); // 0x0000000180969910-0x0000000180969940
		public void Clicked(); // 0x00000001809698E0-0x0000000180969910
		public void BtnClicked_CopyContent(); // 0x0000000180969720-0x0000000180969750
		public float CalculateExpandedHeight(string content); // 0x0000000180969750-0x00000001809698E0
		public override string ToString(); // 0x0000000180969B90-0x0000000180969BC0
	}
}

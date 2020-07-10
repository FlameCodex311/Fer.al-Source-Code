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
	public class DebugLogItem : MonoBehaviour // TypeDefIndex: 15712
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform transformComponent; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image imageComponent; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text logText; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image logTypeImage; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject logCountParent; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text logCountText; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject _copyBtn; // 0x50
		private DebugLogEntry logEntry; // 0x58
		private int entryIndex; // 0x60
		private DebugLogRecycledListView manager; // 0x68
	
		// Properties
		public RectTransform Transform { get; } // 0x000000018036AC70-0x000000018036AC80 
		public Image Image { get; } // 0x0000000180369B60-0x0000000180369B70 
		public int Index { get; } // 0x00000001804A3730-0x00000001804A3740 
	
		// Constructors
		public DebugLogItem(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Initialize(DebugLogRecycledListView manager); // 0x00000001803A27D0-0x00000001803A27E0
		public void SetContent(DebugLogEntry logEntry, int entryIndex, bool isExpanded); // 0x00000001811248F0-0x0000000181124AE0
		public void ShowCount(); // 0x0000000181124AE0-0x0000000181124B60
		public void HideCount(); // 0x00000001811248C0-0x00000001811248F0
		public void Clicked(); // 0x0000000181124890-0x00000001811248C0
		public void BtnClicked_CopyContent(); // 0x00000001811246D0-0x0000000181124700
		public float CalculateExpandedHeight(string content); // 0x0000000181124700-0x0000000181124890
		public override string ToString(); // 0x0000000181124B60-0x0000000181124B90
	}
}

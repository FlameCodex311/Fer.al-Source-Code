/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public abstract class DebugPanel : MonoBehaviour // TypeDefIndex: 15718
	{
		// Fields
		[Header] // 0x0000000180161F00-0x0000000180161F50
		[SerializeField] // 0x0000000180161F00-0x0000000180161F50
		protected DebugConsoleWindow _console; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected InputField _inputField; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected GameObject snapToBottomButton; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ScrollRect logItemsScrollRect; // 0x38
		protected bool snapToBottom; // 0x40
		protected PointerEventData nullPointerEventData; // 0x48
	
		// Properties
		protected bool _isVisible { get; } // 0x0000000181129350-0x0000000181129380 
	
		// Constructors
		protected DebugPanel(); // 0x0000000181129340-0x0000000181129350
	
		// Methods
		protected virtual void OnEnable(); // 0x0000000181129260-0x0000000181129340
		protected virtual void OnDisable(); // 0x0000000181129190-0x0000000181129260
		protected virtual void OnConsoleShown(); // 0x0000000181129160-0x0000000181129190
		protected virtual void LateUpdate(); // 0x0000000181129060-0x0000000181129160
		public void SetSnapToBottom(bool snapToBottom); // 0x00000001807009C0-0x00000001807009D0
		public void ValidateScrollPosition(); // 0x0000000181129160-0x0000000181129190
		public virtual void BtnClicked_Clear(); // 0x0000000181129050-0x0000000181129060
	}
}

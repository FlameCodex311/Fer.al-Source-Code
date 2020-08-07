/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public abstract class DebugPanel : MonoBehaviour // TypeDefIndex: 16270
	{
		// Fields
		[Header] // 0x00000001801D4940-0x00000001801D4990
		[SerializeField] // 0x00000001801D4940-0x00000001801D4990
		protected DebugConsoleWindow _console; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected InputField _inputField; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected GameObject snapToBottomButton; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ScrollRect logItemsScrollRect; // 0x38
		protected bool snapToBottom; // 0x40
		protected PointerEventData nullPointerEventData; // 0x48
	
		// Properties
		protected bool _isVisible { get; } // 0x000000018096E600-0x000000018096E620 
	
		// Constructors
		protected DebugPanel(); // 0x000000018096E5F0-0x000000018096E600
	
		// Methods
		protected virtual void OnEnable(); // 0x000000018096E510-0x000000018096E5F0
		protected virtual void OnDisable(); // 0x000000018096E440-0x000000018096E510
		protected virtual void OnConsoleShown(); // 0x000000018096E410-0x000000018096E440
		protected virtual void LateUpdate(); // 0x000000018096E310-0x000000018096E410
		public void SetSnapToBottom(bool snapToBottom); // 0x0000000180455C20-0x0000000180455C30
		public void ValidateScrollPosition(); // 0x000000018096E410-0x000000018096E440
		public virtual void BtnClicked_Clear(); // 0x000000018096E300-0x000000018096E310
	}
}

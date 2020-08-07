/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x0000000180221550-0x0000000180221580
public class UI_ChangeCursorOnHover : ManagedBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 13867
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CursorManager.MouseCursorType _cursorType; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _maintainCursorWhileDragging; // 0x54
	private bool _isHovered; // 0x55
	private bool _isDragging; // 0x56

	// Constructors
	public UI_ChangeCursorOnHover(); // 0x000000018053DD50-0x000000018053DDB0

	// Methods
	public override void MStart(); // 0x000000018053DB50-0x000000018053DBD0
	public override void MOnDestroy(); // 0x000000018053DAE0-0x000000018053DB50
	public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018053DBE0-0x000000018053DC50
	public virtual void OnPointerExit(PointerEventData eventData); // 0x000000018053DC50-0x000000018053DCD0
	public void OnPointerDown(PointerEventData eventData); // 0x000000018053DBD0-0x000000018053DBE0
	public void OnPointerUp(PointerEventData eventData); // 0x000000018053DCD0-0x000000018053DD50
}


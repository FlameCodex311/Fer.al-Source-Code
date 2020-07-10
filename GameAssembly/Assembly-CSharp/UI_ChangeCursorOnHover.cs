/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001801292B0-0x00000001801292E0
public class UI_ChangeCursorOnHover : ManagedBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 12283
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CursorManager.MouseCursorType _cursorType; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _maintainCursorWhileDragging; // 0x54
	private bool _isHovered; // 0x55
	private bool _isDragging; // 0x56

	// Constructors
	public UI_ChangeCursorOnHover(); // 0x0000000180F20240-0x0000000180F202A0

	// Methods
	public override void MStart(); // 0x0000000180F20040-0x0000000180F200C0
	public override void MOnDestroy(); // 0x0000000180F1FFC0-0x0000000180F20040
	public virtual void OnPointerEnter(PointerEventData eventData); // 0x0000000180F200D0-0x0000000180F20140
	public virtual void OnPointerExit(PointerEventData eventData); // 0x0000000180F20140-0x0000000180F201C0
	public void OnPointerDown(PointerEventData eventData); // 0x0000000180F200C0-0x0000000180F200D0
	public void OnPointerUp(PointerEventData eventData); // 0x0000000180F201C0-0x0000000180F20240
}


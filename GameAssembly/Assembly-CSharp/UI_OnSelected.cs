/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_OnSelected : MonoBehaviour, ISelectHandler, IDeselectHandler // TypeDefIndex: 13648
{
	// Fields
	public UnityEvent onSelectedEvent; // 0x20
	public UnityEvent onDeselectedEvent; // 0x28

	// Constructors
	public UI_OnSelected(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void OnSelect(BaseEventData eventData); // 0x0000000180E847E0-0x0000000180E84800
	public void OnDeselect(BaseEventData eventData); // 0x0000000180E847C0-0x0000000180E847E0
}


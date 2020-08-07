/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_OnSelected : MonoBehaviour, ISelectHandler, IDeselectHandler // TypeDefIndex: 11315
{
	// Fields
	public UnityEvent onSelectedEvent; // 0x20
	public UnityEvent onDeselectedEvent; // 0x28

	// Constructors
	public UI_OnSelected(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void OnSelect(BaseEventData eventData); // 0x00000001803CE0B0-0x00000001803CE0D0
	public void OnDeselect(BaseEventData eventData); // 0x00000001803CE090-0x00000001803CE0B0
}


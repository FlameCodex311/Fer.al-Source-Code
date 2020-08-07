/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_FurnitureDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 13610
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SanctuaryDecoration _listItem; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13611
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnBeginDrag>b__0(SanctuaryObjectBase so); // 0x00000001803734E0-0x0000000180373530
	}

	// Constructors
	public UI_FurnitureDragHandler(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void OnBeginDrag(PointerEventData eventData); // 0x0000000180377270-0x00000001803774A0
	public void OnDrag(PointerEventData eventData); // 0x00000001803774A0-0x00000001803774B0
	public void OnEndDrag(PointerEventData eventData); // 0x00000001803774A0-0x00000001803774B0
}


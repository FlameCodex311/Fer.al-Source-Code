/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_FurnitureDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 12064
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SanctuaryDecoration _listItem; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12065
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnBeginDrag>b__0(SanctuaryObjectBase so); // 0x0000000180E3E330-0x0000000180E3E380
	}

	// Constructors
	public UI_FurnitureDragHandler(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void OnBeginDrag(PointerEventData eventData); // 0x0000000180E3FA40-0x0000000180E3FC70
	public void OnDrag(PointerEventData eventData); // 0x00000001803581E0-0x00000001803581F0
	public void OnEndDrag(PointerEventData eventData); // 0x00000001803581E0-0x00000001803581F0
}


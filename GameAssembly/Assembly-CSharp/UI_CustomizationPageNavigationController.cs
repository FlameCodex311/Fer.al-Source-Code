/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CustomizationPageNavigationController : MonoBehaviour // TypeDefIndex: 11988
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationPageBody _bodyA; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationPageBody _bodyB; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_GoToCustomizationPage _navButtonPrefab; // 0x30
	private ItemPool _navButtonPool; // 0x38
	private Stack<UI_CustomizationPageInfo> _pageStack; // 0x40
	private UI_CustomizationPageInfo _currentPage; // 0x48
	private UI_CustomizationPageBody _currentBody; // 0x50
	public Action<UI_CustomizationPageInfo> OnNavigation; // 0x58

	// Properties
	public ItemPool NavButtonPool { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public Stack<UI_CustomizationPageInfo> PageStack { get; } // 0x0000000180369B30-0x0000000180369B40 

	// Nested types
	public class ItemPool // TypeDefIndex: 11989
	{
		// Fields
		private Transform _itemParent; // 0x10
		private UI_GoToCustomizationPage _itemPrefab; // 0x18
		private Stack<UI_GoToCustomizationPage> _availableItems; // 0x20
		private List<UI_GoToCustomizationPage> _itemsInUse; // 0x28

		// Constructors
		public ItemPool(Transform inItemParent, UI_GoToCustomizationPage inItemPrefab, int inInitialPoolSize = 50 /* Metadata: 0x00782D83 */); // 0x0000000180F1B380-0x0000000180F1EFD0

		// Methods
		public UI_GoToCustomizationPage GetItemFromPool(); // 0x0000000180F1B090-0x0000000180F1B1E0
		public void ReturnItemToPool(UI_GoToCustomizationPage inItem); // 0x0000000180F1B1E0-0x0000000180F1B2B0
		private void SpawnItem(); // 0x0000000180F1B2B0-0x0000000180F1B380
	}

	// Constructors
	public UI_CustomizationPageNavigationController(); // 0x0000000180F32920-0x0000000180F32980

	// Methods
	private void Awake(); // 0x0000000180F322A0-0x0000000180F32390
	private void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
	public void NavigateToRootPage(UI_CustomizationPageInfo inPageInfo); // 0x0000000180F32890-0x0000000180F32920
	public void NavigateForwardToPage(UI_CustomizationPageInfo inPageInfo); // 0x0000000180F32510-0x0000000180F325F0
	public void NavigateBackToPage(UI_CustomizationPageInfo inPageInfo); // 0x0000000180F32390-0x0000000180F324A0
	public void NavigateBack(); // 0x0000000180F324A0-0x0000000180F32510
	private void NavigateToPage(UI_CustomizationPageInfo inPageInfo, bool inForward); // 0x0000000180F325F0-0x0000000180F32890
}


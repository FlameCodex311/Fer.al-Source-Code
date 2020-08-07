/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CustomizationPageNavigationController : MonoBehaviour // TypeDefIndex: 13534
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationPageBody _bodyA; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationPageBody _bodyB; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_GoToCustomizationPage _navButtonPrefab; // 0x30
	private ItemPool _navButtonPool; // 0x38
	private Stack<UI_CustomizationPageInfo> _pageStack; // 0x40
	private UI_CustomizationPageInfo _currentPage; // 0x48
	private UI_CustomizationPageBody _currentBody; // 0x50
	public Action<UI_CustomizationPageInfo> OnNavigation; // 0x58

	// Properties
	public ItemPool NavButtonPool { get; } // 0x00000001803743D0-0x00000001803743E0 
	public Stack<UI_CustomizationPageInfo> PageStack { get; } // 0x00000001803C7290-0x00000001803C72A0 

	// Nested types
	public class ItemPool // TypeDefIndex: 13535
	{
		// Fields
		private Transform _itemParent; // 0x10
		private UI_GoToCustomizationPage _itemPrefab; // 0x18
		private Stack<UI_GoToCustomizationPage> _availableItems; // 0x20
		private List<UI_GoToCustomizationPage> _itemsInUse; // 0x28

		// Constructors
		public ItemPool(Transform inItemParent, UI_GoToCustomizationPage inItemPrefab, int inInitialPoolSize = 50 /* Metadata: 0x007BA491 */); // 0x0000000180539410-0x000000018053CF50

		// Methods
		public UI_GoToCustomizationPage GetItemFromPool(); // 0x0000000180539130-0x0000000180539270
		public void ReturnItemToPool(UI_GoToCustomizationPage inItem); // 0x0000000180539270-0x0000000180539340
		private void SpawnItem(); // 0x0000000180539340-0x0000000180539410
	}

	// Constructors
	public UI_CustomizationPageNavigationController(); // 0x0000000180550130-0x0000000180550190

	// Methods
	private void Awake(); // 0x000000018054F960-0x000000018054FA50
	private void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
	public void NavigateToRootPage(UI_CustomizationPageInfo inPageInfo); // 0x00000001805500A0-0x0000000180550130
	public void NavigateForwardToPage(UI_CustomizationPageInfo inPageInfo); // 0x000000018054FBD0-0x000000018054FCB0
	public void NavigateBackToPage(UI_CustomizationPageInfo inPageInfo); // 0x000000018054FA50-0x000000018054FB60
	public void NavigateBack(); // 0x000000018054FB60-0x000000018054FBD0
	private void NavigateToPage(UI_CustomizationPageInfo inPageInfo, bool inForward); // 0x000000018054FCB0-0x00000001805500A0
}


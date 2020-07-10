/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SecretCraftingItemPopup : UI_Window // TypeDefIndex: 12594
{
	// Fields
	[Header] // 0x00000001800EE6D0-0x00000001800EE720
	[SerializeField] // 0x00000001800EE6D0-0x00000001800EE720
	private UI_ItemImage _commonItemImage; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _commonItemName; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _commonItemDescr; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_RarityBadge _commonItemRarityBadge; // 0x120
	[Header] // 0x00000001800EECA0-0x00000001800EECF0
	[SerializeField] // 0x00000001800EECA0-0x00000001800EECF0
	private UI_ItemImage _rareItemImage; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _rareItemOutlineImage; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rareItemName; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rareItemDescr; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_RarityBadge _rareItemRarityBadge; // 0x148
	private Action _buttonCallback; // 0x150
	private BaseDef _commonItem; // 0x158
	private BaseDef _rareItem; // 0x160

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12595
	{
		// Fields
		public BaseDef inCommonItem; // 0x10
		public BaseDef inRareItem; // 0x18
		public Action inButtonCallback; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SecretCraftingItemPopup window); // 0x0000000180E9DA70-0x0000000180E9DAC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12596
	{
		// Fields
		public BaseDef inCommonItem; // 0x10
		public BaseDef inRareItem; // 0x18
		public Action inButtonCallback; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E8E0-0x0000000180E9E9D0
	}

	// Constructors
	public UI_Window_SecretCraftingItemPopup(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(BaseDef inCommonItem, BaseDef inRareItem, Action inButtonCallback = null); // 0x0000000180EA9FE0-0x0000000180EAA0C0
	public static void QueueWindow(BaseDef inCommonItem, BaseDef inRareItem, Action inButtonCallback = null); // 0x0000000180EAA0C0-0x0000000180EAA1A0
	public static void CloseWindow(); // 0x0000000180EA9DB0-0x0000000180EA9E00
	public void Setup(BaseDef inCommonItem, BaseDef inRareItem, int inCommonItemCount = 1 /* Metadata: 0x00782FE0 */, int inRareItemCount = 1 /* Metadata: 0x00782FE4 */, Action inButtonCallback = null); // 0x0000000180EAA1A0-0x0000000180EAA5C0
	public void BtnClicked_Ok(); // 0x0000000180EA9D70-0x0000000180EA9DB0
	protected override void OnOpen(); // 0x0000000180EA9EF0-0x0000000180EA9FE0
	protected override void OnClose(bool inAnimate); // 0x0000000180EA9E00-0x0000000180EA9EF0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}


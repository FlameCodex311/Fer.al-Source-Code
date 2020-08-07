/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SecretCraftingItemPopup : UI_Window // TypeDefIndex: 14196
{
	// Fields
	[Header] // 0x00000001801DF0C0-0x00000001801DF110
	[SerializeField] // 0x00000001801DF0C0-0x00000001801DF110
	private UI_ItemImage _commonItemImage; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _commonItemName; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _commonItemDescr; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _commonItemRarityBadge; // 0x120
	[Header] // 0x00000001801DF9A0-0x00000001801DF9F0
	[SerializeField] // 0x00000001801DF9A0-0x00000001801DF9F0
	private UI_ItemImage _rareItemImage; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _rareItemOutlineImage; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rareItemName; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rareItemDescr; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _rareItemRarityBadge; // 0x148
	private Action _buttonCallback; // 0x150
	private BaseDef _commonItem; // 0x158
	private BaseDef _rareItem; // 0x160

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14197
	{
		// Fields
		public BaseDef inCommonItem; // 0x10
		public BaseDef inRareItem; // 0x18
		public Action inButtonCallback; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SecretCraftingItemPopup window); // 0x00000001803B2E60-0x00000001803B2EB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14198
	{
		// Fields
		public BaseDef inCommonItem; // 0x10
		public BaseDef inRareItem; // 0x18
		public Action inButtonCallback; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3A10-0x00000001803B3B00
	}

	// Constructors
	public UI_Window_SecretCraftingItemPopup(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(BaseDef inCommonItem, BaseDef inRareItem, Action inButtonCallback = null); // 0x00000001803C03F0-0x00000001803C04D0
	public static void QueueWindow(BaseDef inCommonItem, BaseDef inRareItem, Action inButtonCallback = null); // 0x00000001803C04D0-0x00000001803C05B0
	public static void CloseWindow(); // 0x00000001803C01C0-0x00000001803C0210
	public void Setup(BaseDef inCommonItem, BaseDef inRareItem, int inCommonItemCount = 1 /* Metadata: 0x007BA6F8 */, int inRareItemCount = 1 /* Metadata: 0x007BA6FC */, Action inButtonCallback = null); // 0x00000001803C05B0-0x00000001803C09C0
	public void BtnClicked_Ok(); // 0x00000001803C0180-0x00000001803C01C0
	protected override void OnOpen(); // 0x00000001803C0300-0x00000001803C03F0
	protected override void OnClose(bool inAnimate); // 0x00000001803C0210-0x00000001803C0300
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}


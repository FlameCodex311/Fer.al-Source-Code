/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SeasonPassTier : UI_Window // TypeDefIndex: 12588
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _tierNumberText; // 0x108
	[Header] // 0x00000001800ECA20-0x00000001800ECA70
	[SerializeField] // 0x00000001800ECA20-0x00000001800ECA70
	private UI_ItemImage _rewardItemImage; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _rewardCountGroup; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardCountText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardNameText; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardDescriptionText; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _bundleInfoGroup; // 0x138
	[Header] // 0x00000001800ED250-0x00000001800ED2A0
	[SerializeField] // 0x00000001800ED250-0x00000001800ED2A0
	private GameObject _statusCompleteGroup; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _statusCompleteUnearnedGroup; // 0x148
	[Header] // 0x00000001800ED4E0-0x00000001800ED530
	[SerializeField] // 0x00000001800ED4E0-0x00000001800ED530
	private GameObject _freeGroup; // 0x150
	[Header] // 0x00000001800ED610-0x00000001800ED660
	[SerializeField] // 0x00000001800ED610-0x00000001800ED660
	private GameObject _groupPreviousTiers; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _previousTiersHeaderText; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _previousTiersDescrText; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_SeasonPassTier _previousTiersList; // 0x170
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _previousTiersCostText; // 0x178
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LazyLayoutGroup _layoutGroup; // 0x180
	private ISeasonPassTier _seasonPassTier; // 0x188
	private List<ISeasonPassTier> _previousTiers; // 0x190
	private int _unlockCost; // 0x198
	private BaseDef _rewardDef; // 0x1A0
	private Waiter _previousTiersWaiter; // 0x1A8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12589
	{
		// Fields
		public ISeasonPassTier inSeasonPassTier; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SeasonPassTier window); // 0x0000000180E9D890-0x0000000180E9D8C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12590
	{
		// Fields
		public ISeasonPassTier inSeasonPassTier; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E030-0x0000000180E9E100
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12591
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<bool> <>9__31_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E9F210-0x0000000180E9F270
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BtnClicked_Purchase>b__31_0(bool inResponse); // 0x0000000180E9CE70-0x0000000180E9CEE0
	}

	// Constructors
	public UI_Window_SeasonPassTier(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(ISeasonPassTier inSeasonPassTier); // 0x0000000180EA82C0-0x0000000180EA8380
	public static void QueueWindow(ISeasonPassTier inSeasonPassTier); // 0x0000000180EA8380-0x0000000180EA8440
	public static void CloseWindow(); // 0x0000000180EA7FE0-0x0000000180EA8030
	private void Setup(ISeasonPassTier inSeasonPassTier); // 0x0000000180EA8790-0x0000000180EA8B50
	private void SetupPreviousTiers(); // 0x0000000180EA8690-0x0000000180EA8790
	private void Refresh(); // 0x0000000180EA8440-0x0000000180EA8690
	protected override void OnOpen(); // 0x0000000180EA8170-0x0000000180EA82B0
	protected override void OnClose(bool inAnimate); // 0x0000000180EA8030-0x0000000180EA8170
	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x0000000180EA82B0-0x0000000180EA82C0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Purchase(); // 0x0000000180EA7C90-0x0000000180EA7FE0
	public void BtnClicked_Info(); // 0x0000000180EA7BE0-0x0000000180EA7C90
	public void BtnClicked_BuySeasonPass(); // 0x0000000180EA7B70-0x0000000180EA7BE0
	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage); // 0x0000000180EA82B0-0x0000000180EA82C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetupPreviousTiers>b__25_0(); // 0x0000000180EA8BF0-0x0000000180EA8C20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Purchase>b__31_1(bool inResponse); // 0x0000000180EA8B50-0x0000000180EA8BF0
}


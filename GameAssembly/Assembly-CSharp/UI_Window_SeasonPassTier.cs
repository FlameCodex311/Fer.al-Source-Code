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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SeasonPassTier : UI_Window // TypeDefIndex: 14190
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _tierNumberText; // 0x108
	[Header] // 0x00000001801DB1B0-0x00000001801DB200
	[SerializeField] // 0x00000001801DB1B0-0x00000001801DB200
	private UI_ItemImage _rewardItemImage; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _rewardCountGroup; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardCountText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardNameText; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardDescriptionText; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _bundleInfoGroup; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _rarityBadge; // 0x140
	[Header] // 0x00000001801DBBF0-0x00000001801DBC40
	[SerializeField] // 0x00000001801DBBF0-0x00000001801DBC40
	private GameObject _statusCompleteGroup; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _statusCompleteUnearnedGroup; // 0x150
	[Header] // 0x00000001801DD140-0x00000001801DD190
	[SerializeField] // 0x00000001801DD140-0x00000001801DD190
	private GameObject _freeGroup; // 0x158
	[Header] // 0x00000001801DD2A0-0x00000001801DD2F0
	[SerializeField] // 0x00000001801DD2A0-0x00000001801DD2F0
	private GameObject _groupPreviousTiers; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _previousTiersHeaderText; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _previousTiersDescrText; // 0x170
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_SeasonPassTier _previousTiersList; // 0x178
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _previousTiersCostText; // 0x180
	[RootSelector] // 0x00000001801DDD10-0x00000001801DDD90
	[SerializeField] // 0x00000001801DDD10-0x00000001801DDD90
	private string _notEnoughColorDefId; // 0x188
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LazyLayoutGroup _layoutGroup; // 0x190
	private ISeasonPassTier _seasonPassTier; // 0x198
	private List<ISeasonPassTier> _previousTiers; // 0x1A0
	private int _unlockCost; // 0x1A8
	private int _unlockAuraPointCost; // 0x1AC
	private BaseDef _rewardDef; // 0x1B0
	private Waiter _previousTiersWaiter; // 0x1B8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14191
	{
		// Fields
		public ISeasonPassTier inSeasonPassTier; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SeasonPassTier window); // 0x00000001803B2CA0-0x00000001803B2CD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14192
	{
		// Fields
		public ISeasonPassTier inSeasonPassTier; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3190-0x00000001803B3260
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoTierPurchase>d__35 : IAsyncStateMachine // TypeDefIndex: 14193
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_SeasonPassTier <>4__this; // 0x28
		private TaskAwaiter<SeasonPassPurchaseTierResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002390-0x00000001800023A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_SeasonPassTier(); // 0x00000001803BF090-0x00000001803BF0E0

	// Methods
	public static void OpenWindow(ISeasonPassTier inSeasonPassTier); // 0x00000001803BDD00-0x00000001803BDDC0
	public static void QueueWindow(ISeasonPassTier inSeasonPassTier); // 0x00000001803BDDC0-0x00000001803BDE80
	public static void CloseWindow(); // 0x00000001803BD900-0x00000001803BD950
	private void Setup(ISeasonPassTier inSeasonPassTier); // 0x00000001803BEA30-0x00000001803BEEA0
	private void SetupPreviousTiers(); // 0x00000001803BDFD0-0x00000001803BEA30
	private void Refresh(); // 0x00000001803BDE80-0x00000001803BDFD0
	protected override void OnOpen(); // 0x00000001803BDB40-0x00000001803BDC80
	protected override void OnClose(bool inAnimate); // 0x00000001803BDA00-0x00000001803BDB40
	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x00000001803BDC90-0x00000001803BDD00
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Purchase(); // 0x00000001803BD3E0-0x00000001803BD900
	[AsyncStateMachine] // 0x00000001801DE180-0x00000001801DE1D0
	private void DoTierPurchase(); // 0x00000001803BD950-0x00000001803BDA00
	public void BtnClicked_Info(); // 0x00000001803BD330-0x00000001803BD3E0
	public void BtnClicked_BuySeasonPass(); // 0x00000001803BD2C0-0x00000001803BD330
	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage); // 0x00000001803BDC80-0x00000001803BDC90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetupPreviousTiers>b__28_0(); // 0x00000001803BF060-0x00000001803BF090
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTierCompleted>b__32_0(); // 0x00000001803BEFF0-0x00000001803BF060
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Purchase>b__34_0(bool inResponse); // 0x00000001803BEEA0-0x00000001803BEF50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Purchase>b__34_1(bool inResponse); // 0x00000001803BEF50-0x00000001803BEFF0
}


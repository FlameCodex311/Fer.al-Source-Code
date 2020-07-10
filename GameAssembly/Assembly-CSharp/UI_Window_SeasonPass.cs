/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SeasonPass : UI_Window // TypeDefIndex: 12582
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _playerIconImage; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _seasonPassNameText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _daysRemainingText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _currentTierText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _seasonPassCompletedGroup; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _seasonPassProgressImage; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _getPassButton; // 0x138
	private ISeasonPass _seasonPass; // 0x140

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12583
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SeasonPass> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E9F3F0-0x0000000180E9F450
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SeasonPass window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D0D0-0x0000000180E9D150
	}

	// Constructors
	public UI_Window_SeasonPass(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180EA9640-0x0000000180EA9740
	public static void QueueWindow(); // 0x0000000180EA9740-0x0000000180EA9840
	public static void CloseWindow(); // 0x0000000180EA90D0-0x0000000180EA9120
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EA9330-0x0000000180EA9630
	protected override void DoDelayedOpenAnimation(); // 0x0000000180EA9120-0x0000000180EA9190
	private void Refresh(); // 0x0000000180EA9840-0x0000000180EA9D70
	protected override void OnClose(bool inAnimate); // 0x0000000180EA9190-0x0000000180EA9330
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_IAPShop(); // 0x0000000180EA90C0-0x0000000180EA90D0
	public void BtnClicked_MyChallenges(); // 0x0000000180EA7720-0x0000000180EA7820
	public void BtnClicked_FAQ(); // 0x0000000180EA7970-0x0000000180EA7A70
	public void BtnClicked_BuySeasonPass(); // 0x0000000180EA9050-0x0000000180EA90C0
	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x0000000180EA9630-0x0000000180EA9640
	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage); // 0x0000000180EA9630-0x0000000180EA9640
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__13_0(); // 0x00000001809E8060-0x00000001809E8080
}


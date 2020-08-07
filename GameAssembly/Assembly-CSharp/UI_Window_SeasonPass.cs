/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SeasonPass : UI_Window // TypeDefIndex: 14184
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _playerIconImage; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _seasonPassNameText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _daysRemainingText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _currentTierText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _seasonPassCompletedGroup; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _seasonPassProgressImage; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _getPassButton; // 0x138
	private ISeasonPass _seasonPass; // 0x140

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14185
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SeasonPass> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803B4280-0x00000001803B42E0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SeasonPass window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B24F0-0x00000001803B2570
	}

	// Constructors
	public UI_Window_SeasonPass(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803BFAE0-0x00000001803BFBE0
	public static void QueueWindow(); // 0x00000001803BFBE0-0x00000001803BFCE0
	public static void CloseWindow(); // 0x00000001803BF570-0x00000001803BF5C0
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803BF7D0-0x00000001803BFAD0
	protected override void DoDelayedOpenAnimation(); // 0x00000001803BF5C0-0x00000001803BF630
	private void Refresh(); // 0x00000001803BFCE0-0x00000001803C0180
	protected override void OnClose(bool inAnimate); // 0x00000001803BF630-0x00000001803BF7D0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_IAPShop(); // 0x00000001803BF560-0x00000001803BF570
	public void BtnClicked_MyChallenges(); // 0x00000001803BCE70-0x00000001803BCF70
	public void BtnClicked_FAQ(); // 0x00000001803BD0C0-0x00000001803BD1C0
	public void BtnClicked_BuySeasonPass(); // 0x00000001803BF4F0-0x00000001803BF560
	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x00000001803BFAD0-0x00000001803BFAE0
	private void OnSeasonPassPurchased(SeasonPassPurchasedMessage inMessage); // 0x00000001803BFAD0-0x00000001803BFAE0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__13_0(); // 0x00000001803B6890-0x00000001803B68B0
}


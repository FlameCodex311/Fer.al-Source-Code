/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SeasonPassChallenges : UI_Window // TypeDefIndex: 12584
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _seasonPassNameText; // 0x108
	[Header] // 0x00000001800EB980-0x00000001800EB9D0
	[SerializeField] // 0x00000001800EB980-0x00000001800EB9D0
	private UI_TabGroup _categoryTabGroup; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_SeasonPassChallenges _itemList; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _categoryText; // 0x120
	[Header] // 0x00000001800EBD20-0x00000001800EBD70
	[SerializeField] // 0x00000001800EBD20-0x00000001800EBD70
	private WWTextMeshProUGUI _tierRewardNameText; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _tierRewardProgressText; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _rewardCountGroup; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardCountText; // 0x140
	[Header] // 0x00000001800EC2E0-0x00000001800EC330
	[SerializeField] // 0x00000001800EC2E0-0x00000001800EC330
	private UI_StageSubjectPositioner _stagePositioner; // 0x148
	private UI_Stage_3DItem _itemStage; // 0x150
	private BaseDef _rewardItem; // 0x158

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12585
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SeasonPassChallenges> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E9F390-0x0000000180E9F3F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SeasonPassChallenges window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D250-0x0000000180E9D2D0
	}

	// Constructors
	public UI_Window_SeasonPassChallenges(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180EA7720-0x0000000180EA7820
	public static void QueueWindow(); // 0x0000000180EA7820-0x0000000180EA7920
	public static void CloseWindow(); // 0x0000000180EA6D10-0x0000000180EA6D60
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EA6F50-0x0000000180EA7530
	protected override void OnClose(bool inAnimate); // 0x0000000180EA6D60-0x0000000180EA6F50
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x0000000180EA75C0-0x0000000180EA7670
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x0000000180EA7530-0x0000000180EA75C0
	private void OnTabSelected(int inTabIndex); // 0x0000000180EA7670-0x0000000180EA7720
}


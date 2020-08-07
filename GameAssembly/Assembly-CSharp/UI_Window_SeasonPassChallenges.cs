/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SeasonPassChallenges : UI_Window // TypeDefIndex: 14186
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _seasonPassNameText; // 0x108
	[Header] // 0x00000001801D9A80-0x00000001801D9AD0
	[SerializeField] // 0x00000001801D9A80-0x00000001801D9AD0
	private UI_TabGroup _categoryTabGroup; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_SeasonPassChallenges _itemList; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _categoryText; // 0x120
	[Header] // 0x00000001801D9E80-0x00000001801D9ED0
	[SerializeField] // 0x00000001801D9E80-0x00000001801D9ED0
	private GameObject _tierProgressGroup; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _tierRewardNameText; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _tierRewardProgressText; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _rewardCountGroup; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardCountText; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _passCompletedGroup; // 0x150
	[Header] // 0x00000001801DAA10-0x00000001801DAA60
	[SerializeField] // 0x00000001801DAA10-0x00000001801DAA60
	private UI_StageSubjectPositioner _stagePositioner; // 0x158
	private UI_Stage_3DItem _itemStage; // 0x160
	private BaseDef _rewardItem; // 0x168

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14187
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SeasonPassChallenges> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803B4220-0x00000001803B4280
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SeasonPassChallenges window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B2670-0x00000001803B26F0
	}

	// Constructors
	public UI_Window_SeasonPassChallenges(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803BCE70-0x00000001803BCF70
	public static void QueueWindow(); // 0x00000001803BCF70-0x00000001803BD070
	public static void CloseWindow(); // 0x00000001803BC420-0x00000001803BC470
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803BC660-0x00000001803BCC90
	protected override void OnClose(bool inAnimate); // 0x00000001803BC470-0x00000001803BC660
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x00000001803BCD10-0x00000001803BCDC0
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x00000001803BCC90-0x00000001803BCD10
	private void OnTabSelected(int inTabIndex); // 0x00000001803BCDC0-0x00000001803BCE70
}


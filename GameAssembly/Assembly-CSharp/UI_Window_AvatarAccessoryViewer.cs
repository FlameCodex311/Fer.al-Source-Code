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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_AvatarAccessoryViewer : UI_Window // TypeDefIndex: 13998
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ListItem_AAVPreview _previewItemPrefabReference; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _content; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ScrollRect _scrollRect; // 0x118
	[Header] // 0x00000001802590E0-0x0000000180259130
	[SerializeField] // 0x00000001802590E0-0x0000000180259130
	private float _itemSize; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _zoomSpeed; // 0x124
	[Header] // 0x00000001802594C0-0x0000000180259510
	[SerializeField] // 0x00000001802594C0-0x0000000180259510
	private float _rotationSpeed; // 0x128
	[Header] // 0x00000001802596D0-0x0000000180259720
	[SerializeField] // 0x00000001802596D0-0x0000000180259720
	private float _panSpeed; // 0x12C
	private Vector3 _currentOffset; // 0x130
	[Header] // 0x0000000180259950-0x00000001802599A0
	[SerializeField] // 0x0000000180259950-0x00000001802599A0
	private UI_ListItem_AAVClothingChoice _clothingChoicePrefab; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _clothingChoiceParent; // 0x148
	[Header] // 0x0000000180259CA0-0x0000000180259CF0
	[SerializeField] // 0x0000000180259CA0-0x0000000180259CF0
	private WWTextMeshProUGUI _classNameText; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _classItemImage; // 0x158
	[Header] // 0x000000018025A120-0x000000018025A170
	[SerializeField] // 0x000000018025A120-0x000000018025A170
	private TMP_Dropdown _actionDropdown; // 0x160
	private ActorClassDefComponent _actorClass; // 0x168
	private List<ActorInfo> _actorInfos; // 0x170
	private List<UI_ListItem_AAVPreview> _previewItems; // 0x178
	private List<UI_ListItem_AAVClothingChoice> _clothingChoices; // 0x180
	private Vector2 _prevMousePos; // 0x188
	private bool _isAnimating; // 0x190
	private ActorActionType[] _animations; // 0x198
	private List<ActorBodyPartDefComponent> _headParts; // 0x1A0
	private List<ActorBodyPartDefComponent> _hornParts; // 0x1A8
	private List<ActorBodyPartDefComponent> _earParts; // 0x1B0
	private List<ActorBodyPartDefComponent> _wingParts; // 0x1B8
	private List<ActorBodyPartDefComponent> _tailParts; // 0x1C0
	private List<ActorBodyPartDefComponent> _legParts; // 0x1C8
	private ActorClothingDefComponent _chosenClothing; // 0x1D0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13999
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AvatarAccessoryViewer> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Comparison<ActorClothingDefComponent> <>9__34_0; // 0x18
		public static Comparison<ActorClothingDefComponent> <>9__35_0; // 0x20

		// Constructors
		static <>c(); // 0x0000000180635520-0x0000000180635580
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AvatarAccessoryViewer window); // 0x00000001803774A0-0x00000001803774B0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803774A0-0x00000001803774B0
		internal int <BtnClicked_PrevItem>b__34_0(ActorClothingDefComponent a, ActorClothingDefComponent b); // 0x0000000180634A60-0x0000000180634AD0
		internal int <BtnClicked_NextItem>b__35_0(ActorClothingDefComponent a, ActorClothingDefComponent b); // 0x0000000180634A60-0x0000000180634AD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 14000
	{
		// Fields
		public UI_ListItem_AAVClothingChoice inItemToReplace; // 0x10
		public UI_Window_AvatarAccessoryViewer <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BtnClicked_ReplaceItem>b__0(ActorClothingDefComponent chosenItem); // 0x0000000180635380-0x0000000180635410
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass46_0 // TypeDefIndex: 14001
	{
		// Fields
		public ActorClothingDefComponent inChosenClothing; // 0x10

		// Constructors
		public <>c__DisplayClass46_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnClothingChosen>b__0(UI_ListItem_AAVClothingChoice item); // 0x0000000180635410-0x0000000180635460
	}

	// Constructors
	public UI_Window_AvatarAccessoryViewer(); // 0x0000000180645090-0x0000000180645290

	// Methods
	public static void OpenWindow(); // 0x00000001806433C0-0x00000001806434C0
	public static void QueueWindow(); // 0x00000001806434C0-0x00000001806435C0
	public static void CloseWindow(); // 0x0000000180642CC0-0x0000000180642D10
	private void Setup(ActorClassDefComponent inActorClass); // 0x0000000180644110-0x00000001806442D0
	public void BtnClicked_ChooseItem(); // 0x0000000180641F20-0x0000000180641F90
	public void BtnClicked_ReplaceItem(UI_ListItem_AAVClothingChoice inItemToReplace); // 0x0000000180642AD0-0x0000000180642B70
	public void BtnClicked_ClearClothing(); // 0x0000000180641F90-0x0000000180642220
	public void BtnClicked_PrevItem(UI_ListItem_AAVClothingChoice inItemToReplace); // 0x0000000180642590-0x0000000180642900
	public void BtnClicked_NextItem(UI_ListItem_AAVClothingChoice inItemToReplace); // 0x0000000180642220-0x0000000180642590
	public void BtnClicked_RemoveClothingChoice(UI_ListItem_AAVClothingChoice inItemToRemove, bool inDestroyChoiceItem = true /* Metadata: 0x007BA5E0 */); // 0x0000000180642900-0x0000000180642AD0
	public void BtnClicked_ChooseClass(); // 0x0000000180641E20-0x0000000180641F20
	public void ToggleBtnClicked_Animate(bool inValue); // 0x0000000180644740-0x0000000180644880
	public void DropdownItemSelected_Animation(int inItemIndex); // 0x0000000180642D10-0x0000000180642D50
	public void BtnClicked_ReplayAnimation(); // 0x0000000180642B70-0x0000000180642BD0
	private void SetupPartLists(); // 0x0000000180643CE0-0x0000000180644110
	private void ClearPartLists(); // 0x0000000180642BD0-0x0000000180642CC0
	private void SetupActorInfos(); // 0x00000001806435C0-0x0000000180643AC0
	private void SpawnPreviewItems(); // 0x0000000180644400-0x0000000180644740
	private void SetupAnimationOptions(); // 0x0000000180643AC0-0x0000000180643CE0
	private void OnClothingChosen(ActorClothingDefComponent inChosenClothing); // 0x0000000180642F50-0x00000001806433A0
	private void SpawnClothingChoiceItem(ActorClothingDefComponent inChosenClothing); // 0x00000001806442D0-0x0000000180644400
	private void OnClassChosen(ActorClassDefComponent inChosenClass); // 0x0000000180642E80-0x0000000180642F50
	private void OnActionChosen(ActorActionType inAction); // 0x0000000180642D50-0x0000000180642E80
	private void Update(); // 0x0000000180644880-0x0000000180645090
	protected override void OnOpen(); // 0x00000001806433A0-0x00000001806433C0
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}


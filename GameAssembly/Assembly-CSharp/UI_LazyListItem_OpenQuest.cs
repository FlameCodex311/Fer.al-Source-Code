/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_OpenQuest : UI_LazyListItem<QuestItemComponent>, ISelectHandler // TypeDefIndex: 12108
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _isUnreadImage; // 0x70
	[DeBeginGroup] // 0x00000001800E8530-0x00000001800E85B0
	[DeHeader] // 0x00000001800E8530-0x00000001800E85B0
	[SerializeField] // 0x00000001800E8530-0x00000001800E85B0
	private WWTextMeshProUGUI _titleTextQuest; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _locationTextQuest; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _timeRemainingTextQuest; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _timerProgressImageQuest; // 0x90
	[DeEndGroup] // 0x00000001800E5D10-0x00000001800E5D40
	[SerializeField] // 0x00000001800E5D10-0x00000001800E5D40
	private CanvasGroup _timeLimitGroupQuest; // 0x98
	[DeBeginGroup] // 0x00000001800E5EC0-0x00000001800E5F40
	[DeHeader] // 0x00000001800E5EC0-0x00000001800E5F40
	[SerializeField] // 0x00000001800E5EC0-0x00000001800E5F40
	private Rectangle _challengeBannerImage; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleTextChallenge; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _locationTextChallenge; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _timeRemainingTextChallenge; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _timerProgressImageChallenge; // 0xC0
	[DeEndGroup] // 0x00000001800E5D10-0x00000001800E5D40
	[SerializeField] // 0x00000001800E5D10-0x00000001800E5D40
	private CanvasGroup _timeLimitGroupChallenge; // 0xC8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0xD0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _challengeGroup; // 0xD8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _questGroup; // 0xE0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LazyLayoutGroup _layoutGroup; // 0xE8
	private bool _isActiveQuest; // 0xF0

	// Constructors
	public UI_LazyListItem_OpenQuest(); // 0x0000000180E78C10-0x0000000180E78C50

	// Methods
	private void Awake(); // 0x0000000180E78180-0x0000000180E78250
	private void OnDestroy(); // 0x0000000180E78250-0x0000000180E78320
	public override void Setup(Action<UI_LazyListItem<QuestItemComponent>> inOnClicked, Action<UI_LazyListItem<QuestItemComponent>> inOnSelected, QuestItemComponent inData, UI_LazyItemList<QuestItemComponent> inItemList); // 0x0000000180E78650-0x0000000180E78BE0
	public override void OnSelect(BaseEventData eventData); // 0x0000000180E78430-0x0000000180E784A0
	private void OnEnable(); // 0x0000000180E78320-0x0000000180E78370
	private void RefreshIsActive(); // 0x0000000180E784A0-0x0000000180E785A0
	private void OnItemUnread(ItemUnreadMessage inMessage); // 0x0000000180E783D0-0x0000000180E78430
	private void OnItemRead(ItemReadMessage inMessage); // 0x0000000180E78370-0x0000000180E783D0
	private void RefreshIsUnread(); // 0x0000000180E785A0-0x0000000180E78650
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__20_0(Sprite sprite); // 0x0000000180E78BE0-0x0000000180E78C10
}


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

public class UI_LazyListItem_CompletedQuest : UI_LazyListItem<QuestItemComponent>, ISelectHandler // TypeDefIndex: 12107
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _isUnreadImage; // 0x70
	[DeBeginGroup] // 0x00000001800E5990-0x00000001800E59F0
	[Header] // 0x00000001800E5990-0x00000001800E59F0
	[SerializeField] // 0x00000001800E5990-0x00000001800E59F0
	private WWTextMeshProUGUI _titleText; // 0x78
	[DeEndGroup] // 0x00000001800E5D10-0x00000001800E5D40
	[SerializeField] // 0x00000001800E5D10-0x00000001800E5D40
	private WWTextMeshProUGUI _locationText; // 0x80
	[DeBeginGroup] // 0x00000001800E5EC0-0x00000001800E5F40
	[DeHeader] // 0x00000001800E5EC0-0x00000001800E5F40
	[SerializeField] // 0x00000001800E5EC0-0x00000001800E5F40
	private Rectangle _challengeBannerImage; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleTextChallenge; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _locationTextChallenge; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _timeRemainingTextChallenge; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _timerProgressImageChallenge; // 0xA8
	[DeEndGroup] // 0x00000001800E5D10-0x00000001800E5D40
	[SerializeField] // 0x00000001800E5D10-0x00000001800E5D40
	private CanvasGroup _timeLimitGroupChallenge; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _completionCountText; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _challengeGroup; // 0xC8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _questGroup; // 0xD0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LazyLayoutGroup _layoutGroup; // 0xD8

	// Constructors
	public UI_LazyListItem_CompletedQuest(); // 0x0000000180E72EB0-0x0000000180E72EF0

	// Methods
	private void Awake(); // 0x0000000180E72580-0x0000000180E72650
	private void OnDestroy(); // 0x0000000180E72650-0x0000000180E72720
	public override void Setup(Action<UI_LazyListItem<QuestItemComponent>> inOnClicked, Action<UI_LazyListItem<QuestItemComponent>> inOnSelected, QuestItemComponent inData, UI_LazyItemList<QuestItemComponent> inItemList); // 0x0000000180E72960-0x0000000180E72E80
	public override void OnSelect(BaseEventData eventData); // 0x0000000180E72830-0x0000000180E728B0
	private void OnEnable(); // 0x0000000180E72720-0x0000000180E72770
	private void OnItemUnread(ItemUnreadMessage inMessage); // 0x0000000180E727D0-0x0000000180E72830
	private void OnItemRead(ItemReadMessage inMessage); // 0x0000000180E72770-0x0000000180E727D0
	private void RefreshIsUnread(); // 0x0000000180E728B0-0x0000000180E72960
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__17_0(Sprite sprite); // 0x0000000180E72E80-0x0000000180E72EB0
}


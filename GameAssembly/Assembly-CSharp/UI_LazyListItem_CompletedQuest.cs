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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_CompletedQuest : UI_LazyListItem<QuestItemComponent>, ISelectHandler // TypeDefIndex: 13658
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _isUnreadImage; // 0x70
	[DeBeginGroup] // 0x000000018028D0F0-0x000000018028D150
	[Header] // 0x000000018028D0F0-0x000000018028D150
	[SerializeField] // 0x000000018028D0F0-0x000000018028D150
	private WWTextMeshProUGUI _titleText; // 0x78
	[DeEndGroup] // 0x00000001801E59A0-0x00000001801E59D0
	[SerializeField] // 0x00000001801E59A0-0x00000001801E59D0
	private WWTextMeshProUGUI _locationText; // 0x80
	[DeBeginGroup] // 0x000000018028D540-0x000000018028D5C0
	[DeHeader] // 0x000000018028D540-0x000000018028D5C0
	[SerializeField] // 0x000000018028D540-0x000000018028D5C0
	private Rectangle _challengeBannerImage; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleTextChallenge; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _locationTextChallenge; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _timeRemainingTextChallenge; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _timerProgressImageChallenge; // 0xA8
	[DeEndGroup] // 0x00000001801E59A0-0x00000001801E59D0
	[SerializeField] // 0x00000001801E59A0-0x00000001801E59D0
	private CanvasGroup _timeLimitGroupChallenge; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _completionCountText; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _challengeGroup; // 0xC8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _questGroup; // 0xD0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LazyLayoutGroup _layoutGroup; // 0xD8

	// Constructors
	public UI_LazyListItem_CompletedQuest(); // 0x00000001803A4B00-0x00000001803A4B40

	// Methods
	private void Awake(); // 0x00000001803A4200-0x00000001803A42D0
	private void OnDestroy(); // 0x00000001803A42D0-0x00000001803A43A0
	public override void Setup(Action<UI_LazyListItem<QuestItemComponent>> inOnClicked, Action<UI_LazyListItem<QuestItemComponent>> inOnSelected, QuestItemComponent inData, UI_LazyItemList<QuestItemComponent> inItemList); // 0x00000001803A45D0-0x00000001803A4AD0
	public override void OnSelect(BaseEventData eventData); // 0x00000001803A44B0-0x00000001803A4530
	private void OnEnable(); // 0x00000001803A43A0-0x00000001803A43F0
	private void OnItemUnread(ItemUnreadMessage inMessage); // 0x00000001803A4450-0x00000001803A44B0
	private void OnItemRead(ItemReadMessage inMessage); // 0x00000001803A43F0-0x00000001803A4450
	private void RefreshIsUnread(); // 0x00000001803A4530-0x00000001803A45D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__17_0(Sprite sprite); // 0x00000001803A4AD0-0x00000001803A4B00
}


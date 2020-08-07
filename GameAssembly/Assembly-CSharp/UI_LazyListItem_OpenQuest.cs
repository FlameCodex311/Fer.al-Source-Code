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

public class UI_LazyListItem_OpenQuest : UI_LazyListItem<QuestItemComponent>, ISelectHandler // TypeDefIndex: 13659
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _isUnreadImage; // 0x70
	[DeBeginGroup] // 0x000000018028E7D0-0x000000018028E850
	[DeHeader] // 0x000000018028E7D0-0x000000018028E850
	[SerializeField] // 0x000000018028E7D0-0x000000018028E850
	private WWTextMeshProUGUI _titleTextQuest; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _locationTextQuest; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _timeRemainingTextQuest; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _timerProgressImageQuest; // 0x90
	[DeEndGroup] // 0x00000001801E59A0-0x00000001801E59D0
	[SerializeField] // 0x00000001801E59A0-0x00000001801E59D0
	private CanvasGroup _timeLimitGroupQuest; // 0x98
	[DeBeginGroup] // 0x000000018028D540-0x000000018028D5C0
	[DeHeader] // 0x000000018028D540-0x000000018028D5C0
	[SerializeField] // 0x000000018028D540-0x000000018028D5C0
	private Rectangle _challengeBannerImage; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleTextChallenge; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _locationTextChallenge; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _timeRemainingTextChallenge; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _timerProgressImageChallenge; // 0xC0
	[DeEndGroup] // 0x00000001801E59A0-0x00000001801E59D0
	[SerializeField] // 0x00000001801E59A0-0x00000001801E59D0
	private CanvasGroup _timeLimitGroupChallenge; // 0xC8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0xD0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _challengeGroup; // 0xD8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _questGroup; // 0xE0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LazyLayoutGroup _layoutGroup; // 0xE8
	private bool _isActiveQuest; // 0xF0

	// Constructors
	public UI_LazyListItem_OpenQuest(); // 0x00000001803AA6E0-0x00000001803AA720

	// Methods
	private void Awake(); // 0x00000001803A9CA0-0x00000001803A9D70
	private void OnDestroy(); // 0x00000001803A9D70-0x00000001803A9E40
	public override void Setup(Action<UI_LazyListItem<QuestItemComponent>> inOnClicked, Action<UI_LazyListItem<QuestItemComponent>> inOnSelected, QuestItemComponent inData, UI_LazyItemList<QuestItemComponent> inItemList); // 0x00000001803AA150-0x00000001803AA6B0
	public override void OnSelect(BaseEventData eventData); // 0x00000001803A9F50-0x00000001803A9FC0
	private void OnEnable(); // 0x00000001803A9E40-0x00000001803A9E90
	private void RefreshIsActive(); // 0x00000001803A9FC0-0x00000001803AA0B0
	private void OnItemUnread(ItemUnreadMessage inMessage); // 0x00000001803A9EF0-0x00000001803A9F50
	private void OnItemRead(ItemReadMessage inMessage); // 0x00000001803A9E90-0x00000001803A9EF0
	private void RefreshIsUnread(); // 0x00000001803AA0B0-0x00000001803AA150
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__20_0(Sprite sprite); // 0x00000001803AA6B0-0x00000001803AA6E0
}


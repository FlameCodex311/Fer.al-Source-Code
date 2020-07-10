/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SocialPanel_Party : MonoBehaviour // TypeDefIndex: 12359
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _noPartyGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _partyGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_PartyMemberItem> _partyMemberItems; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _startQuestButton; // 0x38
	private int _partySize; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 12360
	{
		// Fields
		public GroupTeamUserLeftMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnUserLeave>b__0(UI_PartyMemberItem i); // 0x0000000180EE18A0-0x0000000180EE1900
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12361
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<UI_PartyMemberItem> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180EE1CF0-0x0000000180EE1D50
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnUserJoin>b__12_0(UI_PartyMemberItem i); // 0x0000000180EE1820-0x0000000180EE1840
	}

	// Constructors
	public UI_SocialPanel_Party(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void BtnClicked_LeaveParty(); // 0x0000000180EF5290-0x0000000180EF5310
	public void BtnClicked_StartQuest(); // 0x0000000180EF5310-0x0000000180EF53F0
	private void Start(); // 0x0000000180EF5DC0-0x0000000180EF6120
	private void OnDestroy(); // 0x0000000180EF53F0-0x0000000180EF5540
	private void RefreshHasParty(); // 0x0000000180EF5D70-0x0000000180EF5DC0
	private void OnPartyCreated(RequestGroupTeamCreateSuccessMessage inMessage); // 0x0000000180EF5540-0x0000000180EF5780
	private void OnUserLeave(GroupTeamUserLeftMessage inMessage); // 0x0000000180EF5A00-0x0000000180EF5D70
	private void OnUserJoin(GroupTeamUserJoinedMessage inMessage); // 0x0000000180EF57D0-0x0000000180EF5A00
	private void OnPartyDisbanded(GroupTeamLeaveMessage inMessage); // 0x0000000180EF5780-0x0000000180EF57D0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SocialPanel_Party : MonoBehaviour // TypeDefIndex: 13944
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _noPartyGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _partyGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_PartyMemberItem> _partyMemberItems; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _startQuestButton; // 0x38
	private int _partySize; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13945
	{
		// Fields
		public GroupTeamUserLeftMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnUserLeave>b__0(UI_PartyMemberItem i); // 0x00000001804C2C40-0x00000001804C2CA0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13946
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<UI_PartyMemberItem> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804C3500-0x00000001804C3560
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnUserJoin>b__12_0(UI_PartyMemberItem i); // 0x00000001804C29E0-0x00000001804C2A00
	}

	// Constructors
	public UI_SocialPanel_Party(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void BtnClicked_LeaveParty(); // 0x00000001804CA3D0-0x00000001804CA450
	public void BtnClicked_StartQuest(); // 0x00000001804CA450-0x00000001804CA530
	private void Start(); // 0x00000001804CAE20-0x00000001804CB170
	private void OnDestroy(); // 0x00000001804CA530-0x00000001804CA680
	private void RefreshHasParty(); // 0x00000001804CADD0-0x00000001804CAE20
	private void OnPartyCreated(RequestGroupTeamCreateSuccessMessage inMessage); // 0x00000001804CA680-0x00000001804CA8B0
	private void OnUserLeave(GroupTeamUserLeftMessage inMessage); // 0x00000001804CAB20-0x00000001804CADD0
	private void OnUserJoin(GroupTeamUserJoinedMessage inMessage); // 0x00000001804CA900-0x00000001804CAB20
	private void OnPartyDisbanded(GroupTeamLeaveMessage inMessage); // 0x00000001804CA8B0-0x00000001804CA900
}


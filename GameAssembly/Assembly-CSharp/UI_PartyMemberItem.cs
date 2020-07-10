/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_PartyMemberItem : MonoBehaviour // TypeDefIndex: 12333
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _noUserGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _userGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _displayNameText; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _partyLeaderGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _meColor; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _notMeColor; // 0x58
	private UserInfo _user; // 0x68

	// Properties
	public UserInfo User { get; } // 0x0000000180358970-0x0000000180358980 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetAvatarIcon>d__11 : IEnumerator<object> // TypeDefIndex: 12334
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_PartyMemberItem <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetAvatarIcon>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0690-0x0000000180EE0870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EE0870-0x0000000180EE16F0
	}

	// Constructors
	public UI_PartyMemberItem(); // 0x0000000180EE2380-0x0000000180EE23C0

	// Methods
	public void Setup(UserInfo inUser, bool inIsPartyLeader); // 0x0000000180EE2190-0x0000000180EE2380
	[IteratorStateMachine] // 0x00000001801400B0-0x0000000180140100
	private IEnumerator SetAvatarIcon(); // 0x0000000180EE2130-0x0000000180EE2190
}


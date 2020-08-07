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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_PartyMemberItem : MonoBehaviour // TypeDefIndex: 13917
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _noUserGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _userGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _displayNameText; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _partyLeaderGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _meColor; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _notMeColor; // 0x58
	private UserInfo _user; // 0x68

	// Properties
	public UserInfo User { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetAvatarIcon>d__11 : IEnumerator<object> // TypeDefIndex: 13918
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_PartyMemberItem <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetAvatarIcon>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5D60-0x00000001803C5F40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001803C5F40-0x00000001803C62E0
	}

	// Constructors
	public UI_PartyMemberItem(); // 0x00000001803D17B0-0x00000001803D17F0

	// Methods
	public void Setup(UserInfo inUser, bool inIsPartyLeader); // 0x00000001803D15D0-0x00000001803D17B0
	[IteratorStateMachine] // 0x000000018023A570-0x000000018023A5C0
	private IEnumerator SetAvatarIcon(); // 0x00000001803D1570-0x00000001803D15D0
}


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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_TimeRemainingBadge : MonoBehaviour // TypeDefIndex: 12373
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupNew; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupLeavingSoon; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _timeRemainingText; // 0x30
	[Range] // 0x0000000180154C10-0x0000000180154C50
	[SerializeField] // 0x0000000180154C10-0x0000000180154C50
	private int _daysAfterNewStatus; // 0x38
	[Range] // 0x0000000180154C10-0x0000000180154C50
	[SerializeField] // 0x0000000180154C10-0x0000000180154C50
	private int _daysBeforExpiringStatus; // 0x3C
	private DateTime? _newItemStartDate; // 0x40
	private DateTime? _expirationDate; // 0x50
	private TimeSpan _newItemTimeSpan; // 0x60
	private TimeSpan _expiringTimeSpan; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateTimeRemainingBadge>d__14 : IEnumerator<object> // TypeDefIndex: 12374
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_TimeRemainingBadge <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateTimeRemainingBadge>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F8F490-0x0000000180F8F650
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F8F650-0x0000000180F8F6A0
	}

	// Constructors
	public UI_TimeRemainingBadge(); // 0x0000000180F989D0-0x0000000180F989F0

	// Methods
	private void OnDisable(); // 0x0000000180F984E0-0x0000000180F984F0
	public void Setup(BaseDef inDef); // 0x0000000180F984F0-0x0000000180F98970
	private void EnableNewGroup(); // 0x0000000180F97ED0-0x0000000180F97F70
	private void EnableExpirationGroup(); // 0x0000000180F97E30-0x0000000180F97ED0
	private void Disable(); // 0x0000000180F97D90-0x0000000180F97E30
	[IteratorStateMachine] // 0x0000000180155180-0x00000001801551D0
	private IEnumerator UpdateTimeRemainingBadge(); // 0x0000000180F98970-0x0000000180F989D0
	private string GetTimeRemaining(TimeSpan timeDifference); // 0x0000000180F980B0-0x0000000180F98190
	private string GetTimeValueUnit(int value, string unit); // 0x0000000180F98190-0x0000000180F98220
	private bool IsNew(); // 0x0000000180F98370-0x0000000180F984E0
	private bool IsExpiring(); // 0x0000000180F98220-0x0000000180F98300
	private bool IsNegative(TimeSpan timeDifference); // 0x0000000180F98300-0x0000000180F98370
	private TimeSpan GetNewDateDifference(); // 0x0000000180F98010-0x0000000180F980B0
	private TimeSpan GetExpirationDateDifference(); // 0x0000000180F97F70-0x0000000180F98010
}


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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_TimeRemainingBadge : MonoBehaviour // TypeDefIndex: 13958
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupNew; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupLeavingSoon; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _timeRemainingText; // 0x30
	[Range] // 0x000000018024BAA0-0x000000018024BAE0
	[SerializeField] // 0x000000018024BAA0-0x000000018024BAE0
	private int _daysAfterNewStatus; // 0x38
	[Range] // 0x000000018024BAA0-0x000000018024BAE0
	[SerializeField] // 0x000000018024BAA0-0x000000018024BAE0
	private int _daysBeforExpiringStatus; // 0x3C
	private DateTime? _newItemStartDate; // 0x40
	private DateTime? _expirationDate; // 0x50
	private TimeSpan _newItemTimeSpan; // 0x60
	private TimeSpan _expiringTimeSpan; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateTimeRemainingBadge>d__14 : IEnumerator<object> // TypeDefIndex: 13959
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_TimeRemainingBadge <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateTimeRemainingBadge>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806356A0-0x0000000180635850
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180635850-0x00000001806358A0
	}

	// Constructors
	public UI_TimeRemainingBadge(); // 0x00000001806393D0-0x00000001806393F0

	// Methods
	private void OnDisable(); // 0x0000000180638EF0-0x0000000180638F00
	public void Setup(BaseDef inDef); // 0x0000000180638F00-0x0000000180639370
	private void EnableNewGroup(); // 0x00000001806388E0-0x0000000180638980
	private void EnableExpirationGroup(); // 0x0000000180638840-0x00000001806388E0
	private void Disable(); // 0x00000001806387A0-0x0000000180638840
	[IteratorStateMachine] // 0x000000018024C030-0x000000018024C080
	private IEnumerator UpdateTimeRemainingBadge(); // 0x0000000180639370-0x00000001806393D0
	private string GetTimeRemaining(TimeSpan timeDifference); // 0x0000000180638AC0-0x0000000180638BA0
	private string GetTimeValueUnit(int value, string unit); // 0x0000000180638BA0-0x0000000180638C30
	private bool IsNew(); // 0x0000000180638D80-0x0000000180638EF0
	private bool IsExpiring(); // 0x0000000180638C30-0x0000000180638D10
	private bool IsNegative(TimeSpan timeDifference); // 0x0000000180638D10-0x0000000180638D80
	private TimeSpan GetNewDateDifference(); // 0x0000000180638A20-0x0000000180638AC0
	private TimeSpan GetExpirationDateDifference(); // 0x0000000180638980-0x0000000180638A20
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FCCrowIdle : MonoBehaviour // TypeDefIndex: 10043
{
	// Fields
	public Animator animator; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string[] parameterNames; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float blendSpeed; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float minChangeTime; // 0x34
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float maxChangeTime; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject wings; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject branchParent; // 0x48
	private float timer; // 0x50
	private float randomWait; // 0x54
	private float[] previousValues; // 0x58
	private float[] destinationValues; // 0x60
	private bool lostGame; // 0x68
	private bool _crowShown; // 0x69

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoseGame>d__16 : IEnumerator<object> // TypeDefIndex: 10044
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FCCrowIdle <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoseGame>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119C4A0-0x000000018119C610
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119C610-0x000000018119CA30
	}

	// Constructors
	public FCCrowIdle(); // 0x0000000181194690-0x00000001811946C0

	// Methods
	private void Start(); // 0x00000001811942B0-0x0000000181194470
	private void ResetIdleTimes(); // 0x0000000181194280-0x00000001811942B0
	private void Update(); // 0x0000000181194670-0x0000000181194690
	private void UpdateIdle(); // 0x0000000181194470-0x0000000181194670
	[IteratorStateMachine] // 0x000000018013E6D0-0x000000018013E720
	public IEnumerator LoseGame(); // 0x0000000181194010-0x0000000181194070
	public void ResetCrow(); // 0x0000000181194210-0x0000000181194280
	private void PickNewIdle(); // 0x0000000181194070-0x0000000181194210
	internal void ShowCrow(bool inShow); // 0x0000000180866A40-0x0000000180866A50
}


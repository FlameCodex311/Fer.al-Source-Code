/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Waiters
{
	public class WaitController : MonoBehaviour // TypeDefIndex: 15683
	{
		// Fields
		private static WaitController _instance; // 0x00
		private List<Waiter> _trackedWaiters; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<Waiter> _pendingWaiters; // 0x28
		private float _timeLastFrame; // 0x30
	
		// Properties
		private static WaitController Instance { get; } // 0x0000000181135020-0x0000000181135230 
		public List<Waiter> TrackedWaiters { get; } // 0x000000018036AC70-0x000000018036AC80 
		public List<Waiter> PendingWaiters { get; } // 0x0000000180369B60-0x0000000180369B70 
	
		// Constructors
		public WaitController(); // 0x0000000181134FA0-0x0000000181135020
	
		// Methods
		public static void Init(); // 0x0000000181134940-0x0000000181134AD0
		public static Waiter DoAfter(Func<bool> inCompletionCheck, Action inOnCompleteAction); // 0x00000001811344E0-0x0000000181134580
		public static TimeWaiter DoAfterWait(float inTimeToWait, Action inOnCompleteAction); // 0x00000001811343E0-0x00000001811344E0
		public static FrameWaiter DoAfterFrames(int inFramesToWait, Action inOnCompleteAction); // 0x00000001811342F0-0x00000001811343E0
		public static List<Waiter> GetWaitersWithID(object inID); // 0x0000000181134700-0x0000000181134940
		public static void CancelWaitersWithID(object inID); // 0x00000001811340F0-0x0000000181134220
		public static void CancelAllWaiters(); // 0x0000000181133F60-0x00000001811340F0
		private void Start(); // 0x0000000181134D00-0x0000000181134E00
		private void Update(); // 0x0000000181134E00-0x0000000181134FA0
		private void FixedUpdate(); // 0x0000000181134580-0x0000000181134700
		private void LateUpdate(); // 0x0000000181134AD0-0x0000000181134D00
		private void CleanupTrackedRoutines(); // 0x0000000181134220-0x00000001811342F0
	}
}

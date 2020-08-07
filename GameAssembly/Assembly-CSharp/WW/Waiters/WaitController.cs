/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Waiters
{
	public class WaitController : MonoBehaviour // TypeDefIndex: 16234
	{
		// Fields
		private static WaitController _instance; // 0x00
		private List<Waiter> _trackedWaiters; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<Waiter> _pendingWaiters; // 0x28
		private float _timeLastFrame; // 0x30
	
		// Properties
		private static WaitController Instance { get; } // 0x000000018097E3A0-0x000000018097E5A0 
		public List<Waiter> TrackedWaiters { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public List<Waiter> PendingWaiters { get; } // 0x00000001803745B0-0x00000001803745C0 
	
		// Constructors
		public WaitController(); // 0x000000018097E320-0x000000018097E3A0
	
		// Methods
		public static void Init(); // 0x000000018097DCD0-0x000000018097DE60
		public static Waiter DoAfter(Func<bool> inCompletionCheck, Action inOnCompleteAction); // 0x000000018097D880-0x000000018097D920
		public static TimeWaiter DoAfterWait(float inTimeToWait, Action inOnCompleteAction); // 0x000000018097D780-0x000000018097D880
		public static FrameWaiter DoAfterFrames(int inFramesToWait, Action inOnCompleteAction); // 0x000000018097D690-0x000000018097D780
		public static List<Waiter> GetWaitersWithID(object inID); // 0x000000018097DAA0-0x000000018097DCD0
		public static void CancelWaitersWithID(object inID); // 0x000000018097D290-0x000000018097D5C0
		public static void CancelAllWaiters(); // 0x000000018097D110-0x000000018097D290
		private void Start(); // 0x000000018097E080-0x000000018097E180
		private void Update(); // 0x000000018097E180-0x000000018097E320
		private void FixedUpdate(); // 0x000000018097D920-0x000000018097DAA0
		private void LateUpdate(); // 0x000000018097DE60-0x000000018097E080
		private void CleanupTrackedRoutines(); // 0x000000018097D5C0-0x000000018097D690
	}
}

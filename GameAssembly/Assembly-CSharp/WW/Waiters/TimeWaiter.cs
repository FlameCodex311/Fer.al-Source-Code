/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Waiters
{
	public class TimeWaiter : Waiter // TypeDefIndex: 16233
	{
		// Fields
		private float _timeToWait; // 0x38
		private float _remainingTime; // 0x3C
	
		// Constructors
		public TimeWaiter(float inTimeToWait, Action inOnCompleteAction); // 0x000000018097BDB0-0x000000018097BE50
	
		// Methods
		protected override void RestartForLoop(); // 0x0000000180970CF0-0x0000000180970D00
		protected override bool CheckForCompletion(float inDeltaTime); // 0x000000018097BD40-0x000000018097BDA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <.ctor>b__2_0(); // 0x000000018097BDA0-0x000000018097BDB0
	}
}

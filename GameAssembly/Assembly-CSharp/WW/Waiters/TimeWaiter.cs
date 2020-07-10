/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Waiters
{
	public class TimeWaiter : Waiter // TypeDefIndex: 15682
	{
		// Fields
		private float _timeToWait; // 0x38
		private float _remainingTime; // 0x3C
	
		// Constructors
		public TimeWaiter(float inTimeToWait, Action inOnCompleteAction); // 0x000000018112BF80-0x000000018112C020
	
		// Methods
		protected override void RestartForLoop(); // 0x0000000181129AA0-0x0000000181129AB0
		protected override bool CheckForCompletion(float inDeltaTime); // 0x000000018112BF10-0x000000018112BF70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <.ctor>b__2_0(); // 0x000000018112BF70-0x000000018112BF80
	}
}

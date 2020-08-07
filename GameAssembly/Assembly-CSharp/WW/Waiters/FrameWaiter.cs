/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Waiters
{
	public class FrameWaiter : Waiter // TypeDefIndex: 16232
	{
		// Fields
		private int _framesToWait; // 0x38
		private int _remainingFrames; // 0x3C
	
		// Constructors
		public FrameWaiter(int inFramesToWait, Action inOnCompleteAction); // 0x0000000180970D10-0x0000000180970DA0
	
		// Methods
		protected override void RestartForLoop(); // 0x0000000180970CF0-0x0000000180970D00
		protected override bool CheckForCompletion(float inDeltaTime); // 0x0000000180970CA0-0x0000000180970CF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <.ctor>b__2_0(); // 0x0000000180970D00-0x0000000180970D10
	}
}

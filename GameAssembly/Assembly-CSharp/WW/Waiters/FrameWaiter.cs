/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Waiters
{
	public class FrameWaiter : Waiter // TypeDefIndex: 15681
	{
		// Fields
		private int _framesToWait; // 0x38
		private int _remainingFrames; // 0x3C
	
		// Constructors
		public FrameWaiter(int inFramesToWait, Action inOnCompleteAction); // 0x0000000181129AC0-0x0000000181129B50
	
		// Methods
		protected override void RestartForLoop(); // 0x0000000181129AA0-0x0000000181129AB0
		protected override bool CheckForCompletion(float inDeltaTime); // 0x0000000181129A50-0x0000000181129AA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <.ctor>b__2_0(); // 0x0000000181129AB0-0x0000000181129AC0
	}
}

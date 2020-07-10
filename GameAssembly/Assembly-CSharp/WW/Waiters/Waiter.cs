/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Waiters
{
	public class Waiter // TypeDefIndex: 15684
	{
		// Fields
		protected Action _action; // 0x10
		protected Func<bool> _completionCheck; // 0x18
		private RoutineState _routineState; // 0x20
		private UpdateType _updateType; // 0x24
		private int _remainingLoops; // 0x28
		private object _id; // 0x30
	
		// Properties
		public RoutineState state { get; } // 0x00000001803C2700-0x00000001803C2710 
		public UpdateType updateType { get; } // 0x00000001803C26F0-0x00000001803C2700 
		public bool IsRunning { get; } // 0x000000018060E1A0-0x000000018060E1B0 
		public object ID { get; } // 0x0000000180397720-0x0000000180397730 
	
		// Constructors
		public Waiter(); // 0x00000001811353D0-0x00000001811353F0
		public Waiter(Func<bool> inCompletionCheck, Action inOnCompleteAction); // 0x00000001811353F0-0x0000000181135430
	
		// Methods
		protected void Init(); // 0x0000000181135280-0x0000000181135290
		public Waiter SetLoops(int inLoopCount); // 0x0000000181135290-0x00000001811352A0
		public Waiter SetUpdateType(UpdateType inUpdateType); // 0x00000001811352A0-0x00000001811352B0
		public Waiter SetID(object inID); // 0x0000000180DD0740-0x0000000180DD0750
		public void Cancel(); // 0x0000000180701EF0-0x0000000180701F00
		public void Update(float inDeltaTime); // 0x00000001811352B0-0x00000001811353D0
		protected virtual void RestartForLoop(); // 0x00000001809A7670-0x00000001809A7680
		protected virtual bool CheckForCompletion(float inDeltaTime); // 0x0000000181135230-0x0000000181135280
	}
}

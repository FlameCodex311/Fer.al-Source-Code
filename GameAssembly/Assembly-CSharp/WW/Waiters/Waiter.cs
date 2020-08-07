/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Waiters
{
	public class Waiter // TypeDefIndex: 16235
	{
		// Fields
		protected Action _action; // 0x10
		protected Func<bool> _completionCheck; // 0x18
		private RoutineState _routineState; // 0x20
		private UpdateType _updateType; // 0x24
		private int _remainingLoops; // 0x28
		private object _id; // 0x30
	
		// Properties
		public RoutineState state { get; } // 0x00000001803FB670-0x00000001803FB680 
		public UpdateType updateType { get; } // 0x0000000180491DB0-0x0000000180491DC0 
		public bool IsRunning { get; } // 0x000000018097E7D0-0x000000018097E7E0 
		public object ID { get; } // 0x00000001803745C0-0x00000001803745D0 
	
		// Constructors
		public Waiter(); // 0x000000018097E770-0x000000018097E790
		public Waiter(Func<bool> inCompletionCheck, Action inOnCompleteAction); // 0x000000018097E790-0x000000018097E7D0
	
		// Methods
		protected void Init(); // 0x000000018097E600-0x000000018097E610
		public Waiter SetLoops(int inLoopCount); // 0x000000018097E630-0x000000018097E640
		public Waiter SetUpdateType(UpdateType inUpdateType); // 0x000000018097E640-0x000000018097E650
		public Waiter SetID(object inID); // 0x000000018097E620-0x000000018097E630
		public void Cancel(); // 0x000000018097E5A0-0x000000018097E5B0
		public void Update(float inDeltaTime); // 0x000000018097E650-0x000000018097E770
		protected virtual void RestartForLoop(); // 0x000000018097E610-0x000000018097E620
		protected virtual bool CheckForCompletion(float inDeltaTime); // 0x000000018097E5B0-0x000000018097E600
	}
}

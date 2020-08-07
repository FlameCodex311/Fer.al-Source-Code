/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	public abstract class PlayerLoopReusablePromiseBase : ReusablePromise, IPlayerLoopItem // TypeDefIndex: 8871
	{
		// Fields
		private readonly PlayerLoopTiming timing; // 0x28
		protected readonly CancellationToken cancellationToken; // 0x30
		private bool isRunning; // 0x38
	
		// Properties
		public override bool IsCompleted { get; } // 0x0000000180E1A470-0x0000000180E1A4D0 
	
		// Constructors
		public PlayerLoopReusablePromiseBase(PlayerLoopTiming timing, CancellationToken cancellationToken, int skipTrackFrameCountAdditive); // 0x0000000180E1A430-0x0000000180E1A470
	
		// Methods
		protected abstract void OnRunningStart();
		protected void Complete(); // 0x0000000180E1A420-0x0000000180E1A430
		public abstract bool MoveNext();
	}
}

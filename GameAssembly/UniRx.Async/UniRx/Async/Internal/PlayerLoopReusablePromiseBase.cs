/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	public abstract class PlayerLoopReusablePromiseBase : ReusablePromise, IPlayerLoopItem // TypeDefIndex: 8705
	{
		// Fields
		private readonly PlayerLoopTiming timing; // 0x28
		protected readonly CancellationToken cancellationToken; // 0x30
		private bool isRunning; // 0x38
	
		// Properties
		public override bool IsCompleted { get; } // 0x000000018166D990-0x000000018166D9F0 
	
		// Constructors
		public PlayerLoopReusablePromiseBase(PlayerLoopTiming timing, CancellationToken cancellationToken, int skipTrackFrameCountAdditive); // 0x000000018166D950-0x000000018166D990
	
		// Methods
		protected abstract void OnRunningStart();
		protected void Complete(); // 0x0000000180A860A0-0x0000000180A860B0
		public abstract bool MoveNext();
	}
}

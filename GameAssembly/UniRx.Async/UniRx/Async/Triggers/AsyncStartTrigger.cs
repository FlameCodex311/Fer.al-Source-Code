/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncStartTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 8834
	{
		// Fields
		private bool awakeCalled; // 0x18
		private bool called; // 0x19
		private UniTaskCompletionSource promise; // 0x20
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem // TypeDefIndex: 8835
		{
			// Fields
			private readonly AsyncStartTrigger trigger; // 0x10
	
			// Constructors
			public AwakeMonitor(AsyncStartTrigger trigger); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public bool MoveNext(); // 0x0000000180E15160-0x0000000180E15210
		}
	
		// Constructors
		public AsyncStartTrigger(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000180B32300-0x0000000180B32310
		private void Start(); // 0x0000000180E11480-0x0000000180E114A0
		public UniTask StartAsync(); // 0x0000000180E113C0-0x0000000180E11480
		private void OnDestroy(); // 0x0000000180E0B580-0x0000000180E0B5A0
	}
}

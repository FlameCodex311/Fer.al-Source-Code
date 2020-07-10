/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncStartTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 8668
	{
		// Fields
		private bool awakeCalled; // 0x18
		private bool called; // 0x19
		private UniTaskCompletionSource promise; // 0x20
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem // TypeDefIndex: 8669
		{
			// Fields
			private readonly AsyncStartTrigger trigger; // 0x10
	
			// Constructors
			public AwakeMonitor(AsyncStartTrigger trigger); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public bool MoveNext(); // 0x00000001816680F0-0x00000001816681A0
		}
	
		// Constructors
		public AsyncStartTrigger(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x000000018050A050-0x000000018050A060
		private void Start(); // 0x0000000181663D40-0x0000000181663D60
		public UniTask StartAsync(); // 0x0000000181663C80-0x0000000181663D40
		private void OnDestroy(); // 0x000000018165DD10-0x000000018165DD30
	}
}

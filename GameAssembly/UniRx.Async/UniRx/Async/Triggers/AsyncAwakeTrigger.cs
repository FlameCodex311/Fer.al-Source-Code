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
	public class AsyncAwakeTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 8639
	{
		// Fields
		private bool called; // 0x18
		private UniTaskCompletionSource promise; // 0x20
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem // TypeDefIndex: 8640
		{
			// Fields
			private readonly AsyncAwakeTrigger trigger; // 0x10
	
			// Constructors
			public AwakeMonitor(AsyncAwakeTrigger trigger); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public bool MoveNext(); // 0x0000000181668040-0x00000001816680F0
		}
	
		// Constructors
		public AsyncAwakeTrigger(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x000000018165DCF0-0x000000018165DD10
		public UniTask AwakeAsync(); // 0x000000018165DC30-0x000000018165DCF0
		private void OnDestroy(); // 0x000000018165DD10-0x000000018165DD30
	}
}

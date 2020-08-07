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
	public class AsyncAwakeTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 8805
	{
		// Fields
		private bool called; // 0x18
		private UniTaskCompletionSource promise; // 0x20
	
		// Nested types
		private class AwakeMonitor : IPlayerLoopItem // TypeDefIndex: 8806
		{
			// Fields
			private readonly AsyncAwakeTrigger trigger; // 0x10
	
			// Constructors
			public AwakeMonitor(AsyncAwakeTrigger trigger); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public bool MoveNext(); // 0x0000000180E150B0-0x0000000180E15160
		}
	
		// Constructors
		public AsyncAwakeTrigger(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000180E0B560-0x0000000180E0B580
		public UniTask AwakeAsync(); // 0x0000000180E0B4A0-0x0000000180E0B560
		private void OnDestroy(); // 0x0000000180E0B580-0x0000000180E0B5A0
	}
}

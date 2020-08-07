/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncJointTrigger : AsyncTriggerBase // TypeDefIndex: 8821
	{
		// Fields
		private AsyncTriggerPromise<float> onJointBreak; // 0x30
		private AsyncTriggerPromiseDictionary<float> onJointBreaks; // 0x38
		private AsyncTriggerPromise<Joint2D> onJointBreak2D; // 0x40
		private AsyncTriggerPromiseDictionary<Joint2D> onJointBreak2Ds; // 0x48
	
		// Constructors
		public AsyncJointTrigger(); // 0x0000000180E0F1A0-0x0000000180E0F200
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0EF50-0x0000000180E0EFE0
		private void OnJointBreak(float breakForce); // 0x0000000180E0F140-0x0000000180E0F1A0
		public UniTask<float> OnJointBreakAsync(CancellationToken cancellationToken = default); // 0x0000000180E0F0C0-0x0000000180E0F140
		private void OnJointBreak2D(Joint2D brokenJoint); // 0x0000000180E0F060-0x0000000180E0F0C0
		public UniTask<Joint2D> OnJointBreak2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E0EFE0-0x0000000180E0F060
	}
}

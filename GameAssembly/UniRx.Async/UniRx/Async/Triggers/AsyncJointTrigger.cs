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

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncJointTrigger : AsyncTriggerBase // TypeDefIndex: 8655
	{
		// Fields
		private AsyncTriggerPromise<float> onJointBreak; // 0x30
		private AsyncTriggerPromiseDictionary<float> onJointBreaks; // 0x38
		private AsyncTriggerPromise<Joint2D> onJointBreak2D; // 0x40
		private AsyncTriggerPromiseDictionary<Joint2D> onJointBreak2Ds; // 0x48
	
		// Constructors
		public AsyncJointTrigger(); // 0x0000000181661A00-0x0000000181661A60
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x00000001816617B0-0x0000000181661840
		private void OnJointBreak(float breakForce); // 0x00000001816619A0-0x0000000181661A00
		public UniTask<float> OnJointBreakAsync(CancellationToken cancellationToken = default); // 0x0000000181661920-0x00000001816619A0
		private void OnJointBreak2D(Joint2D brokenJoint); // 0x00000001816618C0-0x0000000181661920
		public UniTask<Joint2D> OnJointBreak2DAsync(CancellationToken cancellationToken = default); // 0x0000000181661840-0x00000001816618C0
	}
}

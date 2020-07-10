/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[ExecuteInEditMode] // 0x000000018014A770-0x000000018014A7B0
	[RenderHierarchyIcon] // 0x000000018014A770-0x000000018014A7B0
	public abstract class CameraSystemTriggerBase : MonoBehaviour // TypeDefIndex: 13913
	{
		// Fields
		[SerializeField] // 0x000000018014AA20-0x000000018014AA60
		[Tooltip] // 0x000000018014AA20-0x000000018014AA60
		private TriggerColliderType _triggerColliderType; // 0x20
		[SerializeField] // 0x000000018014ABF0-0x000000018014AC30
		[Tooltip] // 0x000000018014ABF0-0x000000018014AC30
		private Mesh _mesh; // 0x28
		[SerializeField] // 0x000000018014AE30-0x000000018014AE70
		[Tooltip] // 0x000000018014AE30-0x000000018014AE70
		private Color _volumeColor; // 0x30
		[SerializeField] // 0x000000018014B050-0x000000018014B090
		[Tooltip] // 0x000000018014B050-0x000000018014B090
		private bool _renderSolidVolume; // 0x40
		[SerializeField] // 0x000000018014B3B0-0x000000018014B3F0
		[Tooltip] // 0x000000018014B3B0-0x000000018014B3F0
		private bool _renderOnlyWhenSelected; // 0x41
		[SerializeField] // 0x000000018014B5C0-0x000000018014B600
		[Tooltip] // 0x000000018014B5C0-0x000000018014B600
		protected string _tagFilter; // 0x48
		[SerializeField] // 0x000000018014B8D0-0x000000018014B910
		[Tooltip] // 0x000000018014B8D0-0x000000018014B910
		protected LayerMask _layerMask; // 0x50
		[SerializeField] // 0x000000018014BCC0-0x000000018014BD00
		[Tooltip] // 0x000000018014BCC0-0x000000018014BD00
		protected bool _singleUseTrigger; // 0x54
		private bool _triggerEnabled; // 0x55
		private Collider _collider; // 0x58
		private List<ITriggerGate> _triggerGates; // 0x60
		private bool _didTrigger; // 0x68
	
		// Nested types
		public enum TriggerColliderType // TypeDefIndex: 13914
		{
			Box = 0,
			Sphere = 1,
			ConvexMesh = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <SpinOnGatedEnter>d__18 : IEnumerator<object> // TypeDefIndex: 13915
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraSystemTriggerBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <SpinOnGatedEnter>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181360270-0x00000001813603D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813603D0-0x0000000181360420
		}
	
		// Constructors
		protected CameraSystemTriggerBase(); // 0x000000018134AF00-0x000000018134AF70
	
		// Methods
		private void Start(); // 0x000000018134B7B0-0x000000018134BB10
		protected abstract void TriggerEntered();
		protected abstract void TriggerExited();
		private void OnTriggerEnter(Collider other); // 0x000000018134B2B0-0x000000018134B5A0
		private void OnTriggerExit(Collider other); // 0x000000018134B5A0-0x000000018134B750
		[IteratorStateMachine] // 0x000000018014BFF0-0x000000018014C040
		private IEnumerator SpinOnGatedEnter(); // 0x000000018134B750-0x000000018134B7B0
		private bool IsTriggerGated(); // 0x000000018134B1F0-0x000000018134B240
		private bool IsTriggerBlocked(); // 0x000000018134B090-0x000000018134B1F0
		private void OnDestroy(); // 0x000000018134B240-0x000000018134B2B0
	}
}

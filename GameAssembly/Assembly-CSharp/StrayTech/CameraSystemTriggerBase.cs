/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[ExecuteInEditMode] // 0x0000000180278310-0x0000000180278350
	[RenderHierarchyIcon] // 0x0000000180278310-0x0000000180278350
	public abstract class CameraSystemTriggerBase : MonoBehaviour // TypeDefIndex: 14580
	{
		// Fields
		[SerializeField] // 0x0000000180278580-0x00000001802785C0
		[Tooltip] // 0x0000000180278580-0x00000001802785C0
		private TriggerColliderType _triggerColliderType; // 0x20
		[SerializeField] // 0x00000001802787A0-0x00000001802787E0
		[Tooltip] // 0x00000001802787A0-0x00000001802787E0
		private Mesh _mesh; // 0x28
		[SerializeField] // 0x0000000180278A40-0x0000000180278A80
		[Tooltip] // 0x0000000180278A40-0x0000000180278A80
		private Color _volumeColor; // 0x30
		[SerializeField] // 0x0000000180278D40-0x0000000180278D80
		[Tooltip] // 0x0000000180278D40-0x0000000180278D80
		private bool _renderSolidVolume; // 0x40
		[SerializeField] // 0x0000000180278F50-0x0000000180278F90
		[Tooltip] // 0x0000000180278F50-0x0000000180278F90
		private bool _renderOnlyWhenSelected; // 0x41
		[SerializeField] // 0x0000000180279170-0x00000001802791B0
		[Tooltip] // 0x0000000180279170-0x00000001802791B0
		protected string _tagFilter; // 0x48
		[SerializeField] // 0x00000001802793D0-0x0000000180279410
		[Tooltip] // 0x00000001802793D0-0x0000000180279410
		protected LayerMask _layerMask; // 0x50
		[SerializeField] // 0x0000000180279630-0x0000000180279670
		[Tooltip] // 0x0000000180279630-0x0000000180279670
		protected bool _singleUseTrigger; // 0x54
		private bool _triggerEnabled; // 0x55
		private Collider _collider; // 0x58
		private List<ITriggerGate> _triggerGates; // 0x60
		private bool _didTrigger; // 0x68
	
		// Nested types
		public enum TriggerColliderType // TypeDefIndex: 14581
		{
			Box = 0,
			Sphere = 1,
			ConvexMesh = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <SpinOnGatedEnter>d__18 : IEnumerator<object> // TypeDefIndex: 14582
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraSystemTriggerBase <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <SpinOnGatedEnter>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CBDFA0-0x0000000180CBE100
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CBE100-0x0000000180CBE150
		}
	
		// Constructors
		protected CameraSystemTriggerBase(); // 0x0000000180CA9B20-0x0000000180CA9B90
	
		// Methods
		private void Start(); // 0x0000000180CAA450-0x0000000180CAA7A0
		protected abstract void TriggerEntered();
		protected abstract void TriggerExited();
		private void OnTriggerEnter(Collider other); // 0x0000000180CA9F70-0x0000000180CAA250
		private void OnTriggerExit(Collider other); // 0x0000000180CAA250-0x0000000180CAA3F0
		[IteratorStateMachine] // 0x0000000180279860-0x00000001802798B0
		private IEnumerator SpinOnGatedEnter(); // 0x0000000180CAA3F0-0x0000000180CAA450
		private bool IsTriggerGated(); // 0x0000000180CA9EC0-0x0000000180CA9F00
		private bool IsTriggerBlocked(); // 0x0000000180CA9D70-0x0000000180CA9EC0
		private void OnDestroy(); // 0x0000000180CA9F00-0x0000000180CA9F70
	}
}

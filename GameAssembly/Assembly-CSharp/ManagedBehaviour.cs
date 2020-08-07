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

public class ManagedBehaviour : MonoBehaviour // TypeDefIndex: 11098
{
	// Fields
	private ManagedBehaviourManagerAttribute _managerAttribute; // 0x20
	private string _managerName; // 0x28
	private Dictionary<string, Transform> _fastFindChildByNameDict; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <managedRegistered>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <managedAwoken>k__BackingField; // 0x39
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <managedStarted>k__BackingField; // 0x3A
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <managedStartedAfterLocal>k__BackingField; // 0x3B
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <managedEnabled>k__BackingField; // 0x3C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <managedDisabled>k__BackingField; // 0x3D
	private static Dictionary<string, string> _managerNameDict; // 0x00
	private ManagerBase _manager; // 0x40
	private Coroutine _registerWithManagerRoutine; // 0x48

	// Properties
	public bool managedRegistered { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379B20-0x0000000180379B30 0x00000001804F1690-0x00000001804F16A0
	public bool managedAwoken { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804F1610-0x00000001804F1620 0x00000001804F1660-0x00000001804F1670
	public bool managedStarted { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804F1650-0x00000001804F1660 0x00000001804F16B0-0x00000001804F16C0
	public bool managedStartedAfterLocal { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804F1640-0x00000001804F1650 0x00000001804F16A0-0x00000001804F16B0
	public bool managedEnabled { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804F1630-0x00000001804F1640 0x00000001804F1680-0x00000001804F1690
	public bool managedDisabled { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804F1620-0x00000001804F1630 0x00000001804F1670-0x00000001804F1680
	private ManagerBase Manager { get; } // 0x00000001804F11C0-0x00000001804F1610 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RegisterWithManager>d__55 : IEnumerator<object> // TypeDefIndex: 11099
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagedBehaviour <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RegisterWithManager>d__55(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805084C0-0x0000000180508710
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180508710-0x00000001805090C0
	}

	// Constructors
	public ManagedBehaviour(); // 0x00000001803743C0-0x00000001803743D0
	static ManagedBehaviour(); // 0x00000001804F1160-0x00000001804F11C0

	// Methods
	private void AddToFastFindChildByNameDict(Transform inTransform); // 0x00000001804F0200-0x00000001804F0340
	public void ResetFastFindChildByName(); // 0x00000001804F0F30-0x00000001804F0F40
	public Transform FastFindChildByName(Transform inParent, string inFindName, bool InExcludeParent = false /* Metadata: 0x0077C768 */, bool inFuzzySearch = true /* Metadata: 0x0077C769 */, bool inShowMissingError = false /* Metadata: 0x0077C76A */); // 0x00000001804F03A0-0x00000001804F0880
	private Transform PrivateSlowFindChildByName(Transform inParent, string inFindName); // 0x00000001804F0D90-0x00000001804F0ED0
	public virtual void Awake(); // 0x00000001804F0360-0x00000001804F03A0
	public virtual void UAwake(); // 0x00000001803774A0-0x00000001803774B0
	public void AwakeInternal(); // 0x00000001804F0340-0x00000001804F0360
	public virtual void MAwake(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void OnEnable(); // 0x00000001804F0CA0-0x00000001804F0D90
	public void OnEnableInternal(); // 0x00000001804F0C80-0x00000001804F0CA0
	public virtual void MOnEnable(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void Start(); // 0x00000001803774A0-0x00000001803774B0
	public void StartInternal(); // 0x00000001804F0F60-0x00000001804F0F80
	public virtual void MStart(); // 0x00000001803774A0-0x00000001803774B0
	public void StartAfterLocalInternal(); // 0x00000001804F0F40-0x00000001804F0F60
	public virtual void MStartAfterLocal(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void OnDisable(); // 0x00000001804F0A00-0x00000001804F0C80
	public void OnDisableInternal(); // 0x00000001804F09E0-0x00000001804F0A00
	public virtual void MOnDisable(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void OnDestroy(); // 0x00000001804F0880-0x00000001804F09E0
	public virtual void MOnDestroy(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void UpdateInternal(); // 0x00000001804F1140-0x00000001804F1160
	public virtual void MUpdate(); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x00000001802365F0-0x0000000180236640
	private IEnumerator RegisterWithManager(); // 0x00000001804F0ED0-0x00000001804F0F30
	private void UnregisterWithManager(); // 0x00000001804F0F80-0x00000001804F1140
	public virtual void SetInstanceInternal(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void UnsetInstanceInternal(); // 0x00000001803774A0-0x00000001803774B0
}


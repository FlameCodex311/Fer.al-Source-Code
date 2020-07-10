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

public class ManagedBehaviour : MonoBehaviour // TypeDefIndex: 13427
{
	// Fields
	private ManagedBehaviourManagerAttribute _managerAttribute; // 0x20
	private string _managerName; // 0x28
	private Dictionary<string, Transform> _fastFindChildByNameDict; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <managedRegistered>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <managedAwoken>k__BackingField; // 0x39
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <managedStarted>k__BackingField; // 0x3A
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <managedStartedAfterLocal>k__BackingField; // 0x3B
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <managedEnabled>k__BackingField; // 0x3C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <managedDisabled>k__BackingField; // 0x3D
	private static Dictionary<string, string> _managerNameDict; // 0x00
	private ManagerBase _manager; // 0x40
	private Coroutine _registerWithManagerRoutine; // 0x48

	// Properties
	public bool managedRegistered { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x000000018044E330-0x000000018044E340
	public bool managedAwoken { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001806EDE30-0x00000001806EDE40 0x0000000180DDE770-0x0000000180DDE780
	public bool managedStarted { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001806EDE20-0x00000001806EDE30 0x00000001806EDE40-0x00000001806EDE50
	public bool managedStartedAfterLocal { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811EAA80-0x00000001811EAA90 0x00000001811EAA90-0x00000001811EAAA0
	public bool managedEnabled { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180736E00-0x0000000180736E10 0x0000000180736E10-0x0000000180736E20
	public bool managedDisabled { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180D61900-0x0000000180D61910 0x0000000180D61CF0-0x0000000180D61D00
	private ManagerBase Manager { get; } // 0x00000001811EA620-0x00000001811EAA80 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RegisterWithManager>d__55 : IEnumerator<object> // TypeDefIndex: 13428
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagedBehaviour <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RegisterWithManager>d__55(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F33D0-0x00000001811F3630
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F3630-0x00000001811F5470
	}

	// Constructors
	public ManagedBehaviour(); // 0x0000000180E095D0-0x0000000180E095E0
	static ManagedBehaviour(); // 0x00000001811EA5C0-0x00000001811EA620

	// Methods
	private void AddToFastFindChildByNameDict(Transform inTransform); // 0x00000001811E9660-0x00000001811E97A0
	public void ResetFastFindChildByName(); // 0x0000000180BFA1E0-0x0000000180BFA1F0
	public Transform FastFindChildByName(Transform inParent, string inFindName, bool InExcludeParent = false /* Metadata: 0x00783CAD */, bool inFuzzySearch = true /* Metadata: 0x00783CAE */, bool inShowMissingError = false /* Metadata: 0x00783CAF */); // 0x00000001811E9800-0x00000001811E9CF0
	private Transform PrivateSlowFindChildByName(Transform inParent, string inFindName); // 0x00000001811EA200-0x00000001811EA340
	public virtual void Awake(); // 0x00000001811E97C0-0x00000001811E9800
	public virtual void UAwake(); // 0x00000001803581E0-0x00000001803581F0
	public void AwakeInternal(); // 0x00000001811E97A0-0x00000001811E97C0
	public virtual void MAwake(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void OnEnable(); // 0x00000001811EA110-0x00000001811EA200
	public void OnEnableInternal(); // 0x00000001811EA0F0-0x00000001811EA110
	public virtual void MOnEnable(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void Start(); // 0x00000001803581E0-0x00000001803581F0
	public void StartInternal(); // 0x00000001811EA3C0-0x00000001811EA3E0
	public virtual void MStart(); // 0x00000001803581E0-0x00000001803581F0
	public void StartAfterLocalInternal(); // 0x00000001811EA3A0-0x00000001811EA3C0
	public virtual void MStartAfterLocal(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void OnDisable(); // 0x00000001811E9E70-0x00000001811EA0F0
	public void OnDisableInternal(); // 0x00000001811E9E50-0x00000001811E9E70
	public virtual void MOnDisable(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void OnDestroy(); // 0x00000001811E9CF0-0x00000001811E9E50
	public virtual void MOnDestroy(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void UpdateInternal(); // 0x00000001811EA5A0-0x00000001811EA5C0
	public virtual void MUpdate(); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x00000001801547E0-0x0000000180154830
	private IEnumerator RegisterWithManager(); // 0x00000001811EA340-0x00000001811EA3A0
	private void UnregisterWithManager(); // 0x00000001811EA3E0-0x00000001811EA5A0
	public virtual void SetInstanceInternal(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void UnsetInstanceInternal(); // 0x00000001803581E0-0x00000001803581F0
}


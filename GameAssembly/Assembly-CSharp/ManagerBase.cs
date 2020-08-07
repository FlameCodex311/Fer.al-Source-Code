/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ManagerBase : MonoBehaviour // TypeDefIndex: 11191
{
	// Fields
	public bool debugAlwaysVerboseOnDevice; // 0x20
	[NonSerialized]
	private bool _inited; // 0x21
	[NonSerialized]
	public bool initedByCore; // 0x22
	[NonSerialized]
	public bool sceneManager; // 0x23
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <loaded>k__BackingField; // 0x24
	private List<ManagedBehaviour> _registeredBehaviours; // 0x28
	private List<ManagedBehaviour> _registeredDisableBehaviours; // 0x30
	private List<string> _registeredBehaviourNames; // 0x38
	private Type _cachedType; // 0x40
	private static Dictionary<string, ManagerBase> _instanceDictionary; // 0x00
	[NonSerialized]
	public string currentSplashProgressName; // 0x48
	private string _debugVerboseName; // 0x50
	private bool _verbose; // 0x58

	// Properties
	public bool DebugVerbose { get; set; } // 0x00000001804F2E20-0x00000001804F2E80 0x00000001803774A0-0x00000001803774B0
	public bool Inited { get; } // 0x00000001804F2E80-0x00000001804F2E90 
	public bool loaded { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804F2E90-0x00000001804F2EA0 0x00000001804F2EA0-0x00000001804F2EB0
	public List<ManagedBehaviour> registeredBehaviours { get; } // 0x00000001803745B0-0x00000001803745C0 
	public List<ManagedBehaviour> registeredDisableBehaviours { get; } // 0x00000001803745C0-0x00000001803745D0 
	public string DebugVerboseName { get; } // 0x00000001804F2DA0-0x00000001804F2E20 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForCoreAndInit>d__27 : IEnumerator<object> // TypeDefIndex: 11192
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagerBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForCoreAndInit>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180509580-0x00000001805096E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805096E0-0x0000000180509730
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__38 : IEnumerator<object> // TypeDefIndex: 11193
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180506CA0-0x0000000180506CF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FinishCoroutine>d__40 : IEnumerator<object> // TypeDefIndex: 11194
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FinishCoroutine>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180506C50-0x0000000180506CA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForLoadedAndStart>d__44 : IEnumerator<object> // TypeDefIndex: 11195
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagerBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForLoadedAndStart>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180509730-0x00000001805098C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805098C0-0x0000000180509910
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RefreshDebugVerbose>d__56 : IEnumerator<object> // TypeDefIndex: 11196
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagerBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RefreshDebugVerbose>d__56(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180508370-0x0000000180508470
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180508470-0x00000001805084C0
	}

	// Constructors
	public ManagerBase(); // 0x00000001804F2CF0-0x00000001804F2DA0
	static ManagerBase(); // 0x00000001804F2C90-0x00000001804F2CF0

	// Methods
	public Type GetTypeCached(); // 0x00000001804F1970-0x00000001804F19F0
	public void RegisterManagedBehaviour(ManagedBehaviour inManagedBehaviour); // 0x00000001804F1D20-0x00000001804F1DF0
	public void UnregisterManagedBehaviour(ManagedBehaviour inManagedBehaviour); // 0x00000001804F2010-0x00000001804F2120
	private void OnEnable(); // 0x00000001804F1C50-0x00000001804F1CC0
	private void OnDestroy(); // 0x00000001804F1B50-0x00000001804F1C50
	public virtual void MOnDestroy(); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x0000000180256160-0x00000001802561B0
	private IEnumerator WaitForCoreAndInit(); // 0x00000001804F2BD0-0x00000001804F2C30
	public static ManagerBase GetInstanceForManagerName(string inName); // 0x00000001804F1900-0x00000001804F1970
	public void AddInstanceToDictInternal(); // 0x00000001804F16C0-0x00000001804F1870
	public void InitInternal(); // 0x00000001804F1A40-0x00000001804F1A60
	public void SetInstance(); // 0x00000001804F1DF0-0x00000001804F1FA0
	public void UnsetInstance(); // 0x00000001804F2120-0x00000001804F23C0
	public virtual void SetInstanceInternal(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void UnsetInstanceInternal(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void Init(); // 0x00000001803774A0-0x00000001803774B0
	public virtual bool HasInitCoroutine(); // 0x0000000180380950-0x0000000180380960
	[IteratorStateMachine] // 0x0000000180256320-0x0000000180256370
	public virtual IEnumerator InitCoroutine(); // 0x00000001804F19F0-0x00000001804F1A40
	public virtual bool HasFinishCoroutine(); // 0x0000000180380950-0x0000000180380960
	[IteratorStateMachine] // 0x0000000180256670-0x00000001802566C0
	public virtual IEnumerator FinishCoroutine(); // 0x00000001804F18B0-0x00000001804F1900
	public virtual int SplashProgressBarTotal(); // 0x000000018037DDC0-0x000000018037DDD0
	private void Start(); // 0x00000001804F1FA0-0x00000001804F2010
	[IteratorStateMachine] // 0x0000000180256800-0x0000000180256850
	private IEnumerator WaitForLoadedAndStart(); // 0x00000001804F2C30-0x00000001804F2C90
	public virtual void MStart(); // 0x00000001803774A0-0x00000001803774B0
	private void Update(); // 0x00000001804F24E0-0x00000001804F29C0
	private void ValidateRegisteredBehaviours(); // 0x00000001804F29C0-0x00000001804F2BD0
	public void UpdateInternal(); // 0x00000001804F23C0-0x00000001804F24E0
	public virtual void MUpdate(); // 0x00000001803774A0-0x00000001803774B0
	public void DeinitInternal(); // 0x00000001804F1870-0x00000001804F18B0
	public virtual void Deinit(); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x0000000180256B00-0x0000000180256B50
	private IEnumerator RefreshDebugVerbose(); // 0x00000001804F1CC0-0x00000001804F1D20
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public void Log(string inLog); // 0x00000001803774A0-0x00000001803774B0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	[Conditional] // 0x00000001801DFB50-0x00000001801DFBB0
	public void LogWarning(string inLog); // 0x00000001803774A0-0x00000001803774B0
	public void LogError(string inLog); // 0x00000001804F1A60-0x00000001804F1B50
}


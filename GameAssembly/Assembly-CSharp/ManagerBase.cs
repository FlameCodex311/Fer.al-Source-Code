/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ManagerBase : MonoBehaviour // TypeDefIndex: 13520
{
	// Fields
	public bool debugAlwaysVerboseOnDevice; // 0x20
	[NonSerialized]
	private bool _inited; // 0x21
	[NonSerialized]
	public bool initedByCore; // 0x22
	[NonSerialized]
	public bool sceneManager; // 0x23
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
	public bool DebugVerbose { get; set; } // 0x00000001811EC260-0x00000001811EC2C0 0x00000001803581E0-0x00000001803581F0
	public bool Inited { get; } // 0x00000001803C19F0-0x00000001803C1A00 
	public bool loaded { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487D80-0x0000000180487D90 0x00000001804884F0-0x0000000180488500
	public List<ManagedBehaviour> registeredBehaviours { get; } // 0x0000000180369B60-0x0000000180369B70 
	public List<ManagedBehaviour> registeredDisableBehaviours { get; } // 0x0000000180397720-0x0000000180397730 
	public string DebugVerboseName { get; } // 0x00000001811EC1D0-0x00000001811EC260 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForCoreAndInit>d__27 : IEnumerator<object> // TypeDefIndex: 13521
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagerBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForCoreAndInit>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F6710-0x00000001811F6870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F6870-0x00000001811F68C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__38 : IEnumerator<object> // TypeDefIndex: 13522
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F1670-0x00000001811F16C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FinishCoroutine>d__40 : IEnumerator<object> // TypeDefIndex: 13523
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FinishCoroutine>d__40(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F1620-0x00000001811F1670
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForLoadedAndStart>d__44 : IEnumerator<object> // TypeDefIndex: 13524
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagerBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForLoadedAndStart>d__44(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F68C0-0x00000001811F6A50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F6A50-0x00000001811F6AA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RefreshDebugVerbose>d__56 : IEnumerator<object> // TypeDefIndex: 13525
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManagerBase <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RefreshDebugVerbose>d__56(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F3280-0x00000001811F3380
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F3380-0x00000001811F33D0
	}

	// Constructors
	public ManagerBase(); // 0x00000001811EC120-0x00000001811EC1D0
	static ManagerBase(); // 0x00000001811EC0C0-0x00000001811EC120

	// Methods
	public Type GetTypeCached(); // 0x00000001811EAD50-0x00000001811EADD0
	public void RegisterManagedBehaviour(ManagedBehaviour inManagedBehaviour); // 0x00000001811EB100-0x00000001811EB1D0
	public void UnregisterManagedBehaviour(ManagedBehaviour inManagedBehaviour); // 0x00000001811EB3F0-0x00000001811EB500
	private void OnEnable(); // 0x00000001811EB030-0x00000001811EB0A0
	private void OnDestroy(); // 0x00000001811EAF30-0x00000001811EB030
	public virtual void MOnDestroy(); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x00000001800B79A0-0x00000001800B79F0
	private IEnumerator WaitForCoreAndInit(); // 0x00000001811EC000-0x00000001811EC060
	public static ManagerBase GetInstanceForManagerName(string inName); // 0x00000001811EACE0-0x00000001811EAD50
	public void AddInstanceToDictInternal(); // 0x00000001811EAAA0-0x00000001811EAC50
	public void InitInternal(); // 0x00000001811EAE20-0x00000001811EAE40
	public void SetInstance(); // 0x00000001811EB1D0-0x00000001811EB380
	public void UnsetInstance(); // 0x00000001811EB500-0x00000001811EB7C0
	public virtual void SetInstanceInternal(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void UnsetInstanceInternal(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void Init(); // 0x00000001803581E0-0x00000001803581F0
	public virtual bool HasInitCoroutine(); // 0x00000001803C28F0-0x00000001803C2900
	[IteratorStateMachine] // 0x00000001800B7CA0-0x00000001800B7CF0
	public virtual IEnumerator InitCoroutine(); // 0x00000001811EADD0-0x00000001811EAE20
	public virtual bool HasFinishCoroutine(); // 0x00000001803C28F0-0x00000001803C2900
	[IteratorStateMachine] // 0x00000001800B7FB0-0x00000001800B8000
	public virtual IEnumerator FinishCoroutine(); // 0x00000001811EAC90-0x00000001811EACE0
	public virtual int SplashProgressBarTotal(); // 0x000000018035FCC0-0x000000018035FCD0
	private void Start(); // 0x00000001811EB380-0x00000001811EB3F0
	[IteratorStateMachine] // 0x00000001800B8280-0x00000001800B82D0
	private IEnumerator WaitForLoadedAndStart(); // 0x00000001811EC060-0x00000001811EC0C0
	public virtual void MStart(); // 0x00000001803581E0-0x00000001803581F0
	private void Update(); // 0x00000001811EB8F0-0x00000001811EBDF0
	private void ValidateRegisteredBehaviours(); // 0x00000001811EBDF0-0x00000001811EC000
	public void UpdateInternal(); // 0x00000001811EB7C0-0x00000001811EB8F0
	public virtual void MUpdate(); // 0x00000001803581E0-0x00000001803581F0
	public void DeinitInternal(); // 0x00000001811EAC50-0x00000001811EAC90
	public virtual void Deinit(); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x00000001800B8500-0x00000001800B8550
	private IEnumerator RefreshDebugVerbose(); // 0x00000001811EB0A0-0x00000001811EB100
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public void Log(string inLog); // 0x00000001803581E0-0x00000001803581F0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	[Conditional] // 0x00000001800B8950-0x00000001800B89B0
	public void LogWarning(string inLog); // 0x00000001803581E0-0x00000001803581F0
	public void LogError(string inLog); // 0x00000001811EAE40-0x00000001811EAF30
}


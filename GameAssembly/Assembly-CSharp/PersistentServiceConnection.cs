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

public abstract class PersistentServiceConnection // TypeDefIndex: 12645
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsConnected>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsAuthorized>k__BackingField; // 0x11
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <Name>k__BackingField; // 0x18
	private PersistentServiceClient _client; // 0x20
	private string _host; // 0x28
	private int _port; // 0x30
	private Coroutine _reconnectCoroutine; // 0x38
	private int retrySeconds; // 0x40

	// Properties
	public bool IsConnected { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
	public bool IsAuthorized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
	public string Name { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RetryConnect>d__32 : IEnumerator<object> // TypeDefIndex: 12646
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public PersistentServiceConnection <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RetryConnect>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EB8A0-0x00000001804EB970
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EB970-0x00000001804EB9C0
	}

	// Constructors
	protected PersistentServiceConnection(); // 0x0000000180400110-0x0000000180400120

	// Methods
	protected void Init(string name, string host, int port, bool isDebug, bool isSecured); // 0x00000001804E1550-0x00000001804E1810
	~PersistentServiceConnection(); // 0x00000001804E14B0-0x00000001804E1550
	public void Connect(); // 0x00000001804E1000-0x00000001804E1240
	public void Login(string token, string uuid); // 0x00000001804E18A0-0x00000001804E19D0
	public void Disconnect(); // 0x00000001804E1240-0x00000001804E14B0
	public void ProcessEventQueue(); // 0x00000001803FFF60-0x00000001803FFF80
	public void Send(PersistentServiceRequest req); // 0x00000001803FFFE0-0x0000000180400040
	protected abstract void SendConnectMessage(bool succes, string error);
	protected abstract void SendConnectionLostMessage();
	protected abstract void ListenForAuthorizationMessage();
	protected void OnAuthMessage(PersistentServiceAuthResponse message); // 0x00000001804E19D0-0x00000001804E1A30
	protected virtual void OnAuthorized(); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void OnConnection(bool success, string error); // 0x00000001804E1A80-0x00000001804E1B30
	private void OnConnectionLost(); // 0x00000001804E1A30-0x00000001804E1A80
	private void StartReconnectCoroutine(); // 0x00000001804E1CC0-0x00000001804E1D90
	[IteratorStateMachine] // 0x00000001801EDCB0-0x00000001801EDD00
	private IEnumerator RetryConnect(); // 0x00000001804E1C60-0x00000001804E1CC0
	private void OnMessageReceived(string message); // 0x00000001803FFF50-0x00000001803FFF60
	private void OnDebugMessage(string message); // 0x00000001804E1B30-0x00000001804E1C60
	protected void Log(string message); // 0x00000001803774A0-0x00000001803774B0
	protected void LogError(string message); // 0x00000001804E1810-0x00000001804E18A0
}


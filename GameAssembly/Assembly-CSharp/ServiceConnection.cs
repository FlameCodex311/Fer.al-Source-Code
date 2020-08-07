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

public abstract class ServiceConnection // TypeDefIndex: 12650
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsConnected>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsAuthorized>k__BackingField; // 0x11
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <Name>k__BackingField; // 0x18
	private ServiceClient _client; // 0x20
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
	private sealed class <RetryConnect>d__32 : IEnumerator<object> // TypeDefIndex: 12651
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ServiceConnection <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RetryConnect>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180404E90-0x0000000180404F60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180404F60-0x0000000180404FB0
	}

	// Constructors
	protected ServiceConnection(); // 0x0000000180400110-0x0000000180400120

	// Methods
	protected void Init(string name, string host, int port, bool isDebug); // 0x00000001803FF840-0x00000001803FFB00
	~ServiceConnection(); // 0x00000001803FF7A0-0x00000001803FF840
	public void Connect(); // 0x00000001803FF2F0-0x00000001803FF530
	public void Login(string token, string uuid); // 0x00000001803FFB90-0x00000001803FFCC0
	public void Disconnect(); // 0x00000001803FF530-0x00000001803FF7A0
	public void ProcessEventQueue(); // 0x00000001803FFF60-0x00000001803FFF80
	public void Send(ServiceRequest req); // 0x00000001803FFFE0-0x0000000180400040
	protected abstract void SendConnectMessage(bool succes, string error);
	protected abstract void SendConnectionLostMessage();
	protected abstract void ListenForAuthorizationMessage();
	protected void OnAuthMessage(ServiceAuthResponse message); // 0x00000001803FFCC0-0x00000001803FFD20
	protected virtual void OnAuthorized(); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void OnConnection(bool success, string error); // 0x00000001803FFD70-0x00000001803FFE20
	private void OnConnectionLost(); // 0x00000001803FFD20-0x00000001803FFD70
	private void StartReconnectCoroutine(); // 0x0000000180400040-0x0000000180400110
	[IteratorStateMachine] // 0x00000001801EF5E0-0x00000001801EF630
	private IEnumerator RetryConnect(); // 0x00000001803FFF80-0x00000001803FFFE0
	private void OnMessageReceived(string message); // 0x00000001803FFF50-0x00000001803FFF60
	private void OnDebugMessage(string message); // 0x00000001803FFE20-0x00000001803FFF50
	protected void Log(string message); // 0x00000001803774A0-0x00000001803774B0
	protected void LogError(string message); // 0x00000001803FFB00-0x00000001803FFB90
}


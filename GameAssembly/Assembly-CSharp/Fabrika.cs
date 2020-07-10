/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Fabrika // TypeDefIndex: 13259
{
	// Fields
	private static bool isLoading; // 0x00
	private static UnityWebRequest www; // 0x08
	private static string _authToken; // 0x10
	private static string _userId; // 0x18
	private static string _userName; // 0x20
	private static int it; // 0x28
	private static delegateNetworkFabrikaSuccess _loginPromptCallback; // 0x30
	private static string _toolId; // 0x38

	// Properties
	public static string AuthToken { get; set; } // 0x0000000181198320-0x0000000181198380 0x0000000181198B40-0x0000000181198BA0
	public static string UserID { get; set; } // 0x0000000181198380-0x00000001811983E0 0x0000000181198BA0-0x0000000181198C00
	public static string UserName { get; set; } // 0x00000001811983E0-0x0000000181198440 0x0000000181198C00-0x0000000181198C60

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <OnGameUpdate>d__16 : IEnumerator<object> // TypeDefIndex: 13260
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <OnGameUpdate>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814AA9A0-0x00000001814AAAF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814AAAF0-0x00000001814AAFD0
	}

	// Constructors
	public Fabrika(); // 0x000000018036B6C0-0x000000018036B6D0
	static Fabrika(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private static void sendData(string email, string password, string toolId); // 0x00000001811986D0-0x0000000181198B40
	[IteratorStateMachine] // 0x0000000180112620-0x0000000180112670
	private static IEnumerator OnGameUpdate(); // 0x00000001811981A0-0x00000001811981F0
	public void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
	public static void LoadCompleted(); // 0x0000000181197C70-0x00000001811981A0
	public static void login(string email, string password); // 0x0000000181198440-0x00000001811984C0
	public static void clearCache(); // 0x00000001811981F0-0x0000000181198320
	public static void promptUserforAccess(string toolId, delegateNetworkFabrikaSuccess callBack = null, delegateNetworkFabrikaFail failCallBack = null); // 0x00000001811984C0-0x00000001811986D0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Fabrika // TypeDefIndex: 10925
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
	public static string AuthToken { get; set; } // 0x00000001808655B0-0x0000000180865610 0x0000000180865DA0-0x0000000180865E00
	public static string UserID { get; set; } // 0x0000000180865610-0x0000000180865670 0x0000000180865E00-0x0000000180865E60
	public static string UserName { get; set; } // 0x0000000180865670-0x00000001808656D0 0x0000000180865E60-0x0000000180865EC0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <OnGameUpdate>d__16 : IEnumerator<object> // TypeDefIndex: 10926
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <OnGameUpdate>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086AF30-0x000000018086B080
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086B080-0x000000018086B730
	}

	// Constructors
	public Fabrika(); // 0x0000000180373240-0x0000000180373250
	static Fabrika(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	private static void sendData(string email, string password, string toolId); // 0x0000000180865960-0x0000000180865DA0
	[IteratorStateMachine] // 0x00000001801EC270-0x00000001801EC2C0
	private static IEnumerator OnGameUpdate(); // 0x0000000180865440-0x0000000180865490
	public void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
	public static void LoadCompleted(); // 0x0000000180864F20-0x0000000180865440
	public static void login(string email, string password); // 0x00000001808656D0-0x0000000180865750
	public static void clearCache(); // 0x0000000180865490-0x00000001808655B0
	public static void promptUserforAccess(string toolId, delegateNetworkFabrikaSuccess callBack = null, delegateNetworkFabrikaFail failCallBack = null); // 0x0000000180865750-0x0000000180865960
}


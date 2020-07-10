/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	[AddComponentMenu] // 0x00000001800D1750-0x00000001800D17A0
	[DisallowMultipleComponent] // 0x00000001800D1750-0x00000001800D17A0
	public class CodeHashGenerator : KeepAliveBehaviour<CodeStage.AntiCheat.Genuine.CodeHash.CodeHashGenerator>, ICodeHashGenerator // TypeDefIndex: 7206
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static HashGeneratorResultHandler HashGenerated; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private HashGeneratorResult <LastResult>k__BackingField; // 0x20
		private readonly WaitForSeconds cachedWaitForSeconds; // 0x28
		private BaseWorker currentWorker; // 0x30
	
		// Properties
		public HashGeneratorResult LastResult { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public bool IsBusy { get; } // 0x0000000181BABE20-0x0000000181BABE30 
	
		// Events
		public static event HashGeneratorResultHandler HashGenerated {
			add; // 0x0000000181BABD70-0x0000000181BABE20
			remove; // 0x0000000181BABE30-0x0000000181BABEE0
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CalculationAwaiter>d__20 : IEnumerator<object> // TypeDefIndex: 7207
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CodeHashGenerator <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CalculationAwaiter>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181BB7570-0x0000000181BB7620
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181BB7620-0x0000000181BB7670
		}
	
		// Constructors
		public CodeHashGenerator(); // 0x0000000181BABD00-0x0000000181BABD70
	
		// Methods
		public static bool IsTargetPlatformCompatible(); // 0x00000001803C29F0-0x00000001803C2A00
		public static CodeHashGenerator AddToSceneOrGetExisting(); // 0x0000000181BAB5C0-0x0000000181BAB5F0
		public static ICodeHashGenerator Generate(); // 0x0000000181BAB650-0x0000000181BAB790
		internal static FileFilter[] GetFileFiltersAndroid(bool il2Cpp); // 0x0000000181BAB8C0-0x0000000181BABBC0
		internal static FileFilter[] GetFileFiltersStandaloneWindows(bool il2Cpp); // 0x0000000181BABBC0-0x0000000181BABCB0
		ICodeHashGenerator ICodeHashGenerator.Generate(); // 0x0000000181BAB650-0x0000000181BAB790
		protected override void OnDestroy(); // 0x0000000181BABCB0-0x0000000181BABD00
		protected override string GetComponentName(); // 0x0000000181BAB890-0x0000000181BAB8C0
		private ICodeHashGenerator GenerateInternal(); // 0x0000000181BAB790-0x0000000181BAB890
		[IteratorStateMachine] // 0x00000001800ECDF0-0x00000001800ECE40
		private IEnumerator CalculationAwaiter(); // 0x0000000181BAB5F0-0x0000000181BAB650
	}
}

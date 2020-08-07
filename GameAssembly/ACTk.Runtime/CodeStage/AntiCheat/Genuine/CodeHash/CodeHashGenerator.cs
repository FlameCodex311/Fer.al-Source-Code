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

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	[AddComponentMenu] // 0x0000000180232C10-0x0000000180232C60
	[DisallowMultipleComponent] // 0x0000000180232C10-0x0000000180232C60
	public class CodeHashGenerator : KeepAliveBehaviour<CodeStage.AntiCheat.Genuine.CodeHash.CodeHashGenerator>, ICodeHashGenerator // TypeDefIndex: 7372
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static HashGeneratorResultHandler HashGenerated; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private HashGeneratorResult <LastResult>k__BackingField; // 0x20
		private readonly WaitForSeconds cachedWaitForSeconds; // 0x28
		private BaseWorker currentWorker; // 0x30
	
		// Properties
		public HashGeneratorResult LastResult { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public bool IsBusy { get; } // 0x000000018187D720-0x000000018187D730 
	
		// Events
		public static event HashGeneratorResultHandler HashGenerated {
			add; // 0x000000018187D670-0x000000018187D720
			remove; // 0x000000018187D730-0x000000018187D7E0
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CalculationAwaiter>d__20 : IEnumerator<object> // TypeDefIndex: 7373
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CodeHashGenerator <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CalculationAwaiter>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181887640-0x00000001818876F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001818876F0-0x0000000181887740
		}
	
		// Constructors
		public CodeHashGenerator(); // 0x000000018187D600-0x000000018187D670
	
		// Methods
		public static bool IsTargetPlatformCompatible(); // 0x0000000180380B60-0x0000000180380B70
		public static CodeHashGenerator AddToSceneOrGetExisting(); // 0x000000018187CED0-0x000000018187CF00
		public static ICodeHashGenerator Generate(); // 0x000000018187CF60-0x000000018187D0A0
		internal static FileFilter[] GetFileFiltersAndroid(bool il2Cpp); // 0x000000018187D1D0-0x000000018187D4C0
		internal static FileFilter[] GetFileFiltersStandaloneWindows(bool il2Cpp); // 0x000000018187D4C0-0x000000018187D5B0
		ICodeHashGenerator ICodeHashGenerator.Generate(); // 0x000000018187CF60-0x000000018187D0A0
		protected override void OnDestroy(); // 0x000000018187D5B0-0x000000018187D600
		protected override string GetComponentName(); // 0x000000018187D1A0-0x000000018187D1D0
		private ICodeHashGenerator GenerateInternal(); // 0x000000018187D0A0-0x000000018187D1A0
		[IteratorStateMachine] // 0x000000018024D120-0x000000018024D170
		private IEnumerator CalculationAwaiter(); // 0x000000018187CF00-0x000000018187CF60
	}
}

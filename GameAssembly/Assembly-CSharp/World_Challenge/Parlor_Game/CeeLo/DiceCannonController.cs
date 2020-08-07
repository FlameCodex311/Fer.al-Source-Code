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

namespace World_Challenge.Parlor_Game.CeeLo
{
	public class DiceCannonController : MonoBehaviour // TypeDefIndex: 14755
	{
		// Fields
		public GameObject diePrefab; // 0x20
		public Transform dieLocator; // 0x28
		public Transform aimLocator; // 0x30
		public GameObject turret; // 0x38
		public float turretRotationSpeed; // 0x40
		public float minCannonForce; // 0x44
		public float maxCannonForce; // 0x48
		private float cannonForce; // 0x4C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <RollInProgress>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <RollComplete>k__BackingField; // 0x51
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsAutomatic>k__BackingField; // 0x52
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <DieValueA>k__BackingField; // 0x54
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <DieValueB>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <DieValueC>k__BackingField; // 0x5C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <AllDiceFired>k__BackingField; // 0x60
		private CeeLoController parentController; // 0x68
		private List<GameObject> dice; // 0x70
		private GameObject loadedDie; // 0x78
		private int diceOut; // 0x80
		private bool allDiceCounted; // 0x84
		private bool isFiringManual; // 0x85
		private float pivotTime; // 0x88
		private float elapsedPivotTime; // 0x8C
		private int pivotDir; // 0x90
		private Quaternion startRotation; // 0x94
	
		// Properties
		public bool RollInProgress { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0
		public bool RollComplete { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E6D370-0x0000000180E6D380 0x0000000180E6D390-0x0000000180E6D3A0
		public bool IsAutomatic { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E6D360-0x0000000180E6D370 0x0000000180E6D380-0x0000000180E6D390
		public int DieValueA { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180379EE0-0x0000000180379EF0 0x00000001807E3290-0x00000001807E32A0
		public int DieValueB { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180693DB0-0x0000000180693DC0 0x0000000180693DC0-0x0000000180693DD0
		public int DieValueC { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804D2E40-0x00000001804D2E50 0x00000001809C8380-0x00000001809C8390
		public bool AllDiceFired { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FireDieManual>d__52 : IEnumerator<object> // TypeDefIndex: 14756
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceCannonController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FireDieManual>d__52(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7BE30-0x0000000180E7C160
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7C160-0x0000000180E7C1B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AutoFire>d__53 : IEnumerator<object> // TypeDefIndex: 14757
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceCannonController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AutoFire>d__53(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E78C40-0x0000000180E78E90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E78E90-0x0000000180E78EE0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Fire>d__54 : IEnumerator<object> // TypeDefIndex: 14758
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceCannonController <>4__this; // 0x20
			private GameObject <die>5__2; // 0x28
			private Rigidbody <body>5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Fire>d__54(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7C1B0-0x0000000180E7C530
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7C530-0x0000000180E7C580
		}
	
		// Constructors
		public DiceCannonController(); // 0x0000000180E6D330-0x0000000180E6D360
	
		// Methods
		public void SetUp(CeeLoController parentController, bool isAutomatic); // 0x0000000180E6D060-0x0000000180E6D0C0
		public void ResetState(); // 0x0000000180E6CEF0-0x0000000180E6D060
		public void UpdateManual(); // 0x0000000180E6D160-0x0000000180E6D330
		public void CheckDice(); // 0x0000000180E6C790-0x0000000180E6C8D0
		public void StartFiring(); // 0x0000000180E6D0C0-0x0000000180E6D160
		private void LoadDieManual(); // 0x0000000180E6CDB0-0x0000000180E6CEF0
		[IteratorStateMachine] // 0x00000001801F3B70-0x00000001801F3BC0
		private IEnumerator FireDieManual(); // 0x0000000180E6C8D0-0x0000000180E6C930
		[IteratorStateMachine] // 0x00000001801F4020-0x00000001801F4070
		private IEnumerator AutoFire(); // 0x0000000180E6C730-0x0000000180E6C790
		[IteratorStateMachine] // 0x00000001801F42E0-0x00000001801F4330
		private IEnumerator Fire(); // 0x0000000180E6C930-0x0000000180E6C990
		private int GetDieValue(GameObject dieObject); // 0x0000000180E6C990-0x0000000180E6CDB0
	}
}

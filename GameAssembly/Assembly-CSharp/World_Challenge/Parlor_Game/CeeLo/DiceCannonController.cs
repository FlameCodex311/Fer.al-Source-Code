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

namespace World_Challenge.Parlor_Game.CeeLo
{
	public class DiceCannonController : MonoBehaviour // TypeDefIndex: 15600
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <RollInProgress>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <RollComplete>k__BackingField; // 0x51
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsAutomatic>k__BackingField; // 0x52
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <DieValueA>k__BackingField; // 0x54
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <DieValueB>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <DieValueC>k__BackingField; // 0x5C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
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
		public bool RollInProgress { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00
		public bool RollComplete { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001807D2610-0x00000001807D2620 0x00000001817085A0-0x00000001817085B0
		public bool IsAutomatic { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181708580-0x0000000181708590 0x0000000181708590-0x00000001817085A0
		public int DieValueA { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C60-0x0000000180369C70 0x00000001804D0B80-0x00000001804D0B90
		public int DieValueB { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018049CAA0-0x000000018049CAB0 0x000000018049CAB0-0x000000018049CAC0
		public int DieValueC { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804A3740-0x00000001804A3750 0x00000001804A3750-0x00000001804A3760
		public bool AllDiceFired { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804785B0-0x00000001804785C0 0x000000018062BA40-0x000000018062BA50
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FireDieManual>d__52 : IEnumerator<object> // TypeDefIndex: 15601
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceCannonController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FireDieManual>d__52(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181718400-0x0000000181718740
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181718740-0x0000000181718790
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AutoFire>d__53 : IEnumerator<object> // TypeDefIndex: 15602
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceCannonController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AutoFire>d__53(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817150D0-0x0000000181715320
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181715320-0x0000000181715370
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Fire>d__54 : IEnumerator<object> // TypeDefIndex: 15603
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceCannonController <>4__this; // 0x20
			private GameObject <die>5__2; // 0x28
			private Rigidbody <body>5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Fire>d__54(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181718790-0x0000000181718B20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181718B20-0x0000000181718B70
		}
	
		// Constructors
		public DiceCannonController(); // 0x0000000181708550-0x0000000181708580
	
		// Methods
		public void SetUp(CeeLoController parentController, bool isAutomatic); // 0x0000000181708280-0x00000001817082E0
		public void ResetState(); // 0x0000000181708110-0x0000000181708280
		public void UpdateManual(); // 0x0000000181708380-0x0000000181708550
		public void CheckDice(); // 0x00000001817079B0-0x0000000181707AF0
		public void StartFiring(); // 0x00000001817082E0-0x0000000181708380
		private void LoadDieManual(); // 0x0000000181707FD0-0x0000000181708110
		[IteratorStateMachine] // 0x0000000180136510-0x0000000180136560
		private IEnumerator FireDieManual(); // 0x0000000181707AF0-0x0000000181707B50
		[IteratorStateMachine] // 0x0000000180136620-0x0000000180136670
		private IEnumerator AutoFire(); // 0x0000000181707950-0x00000001817079B0
		[IteratorStateMachine] // 0x0000000180136800-0x0000000180136850
		private IEnumerator Fire(); // 0x0000000181707B50-0x0000000181707BB0
		private int GetDieValue(GameObject dieObject); // 0x0000000181707BB0-0x0000000181707FD0
	}
}

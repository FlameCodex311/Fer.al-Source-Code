/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180203190-0x00000001802031E0
public class BehaviorTreeTriggerVolume : ManagedBehaviour // TypeDefIndex: 14277
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ETriggerType _triggerType; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GraphOwner _graph; // 0x58
	private bool _triggerHitThisFrame; // 0x60

	// Properties
	private bool triggerHitThisFrame { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018045A0C0-0x000000018045A0D0

	// Nested types
	public enum ETriggerType // TypeDefIndex: 14278
	{
		NONE = 0,
		ENTER = 1,
		EXIT = 2
	}

	// Constructors
	public BehaviorTreeTriggerVolume(); // 0x000000018212BF20-0x000000018212BF80

	// Methods
	private void OnTriggerEnter(Collider inCollider); // 0x000000018212B9E0-0x000000018212BBF0
	private void OnTriggerExit(Collider inCollider); // 0x000000018212BBF0-0x000000018212BE00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerEnter>b__7_0(); // 0x00000001803CD8B0-0x00000001803CD8C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <OnTriggerEnter>b__7_1(); // 0x000000018212BE00-0x000000018212BE80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerEnter>b__7_2(); // 0x000000018212BE80-0x000000018212BEA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerExit>b__8_0(); // 0x00000001803CD8B0-0x00000001803CD8C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <OnTriggerExit>b__8_1(); // 0x000000018212BEA0-0x000000018212BF20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerExit>b__8_2(); // 0x000000018212BE80-0x000000018212BEA0
}


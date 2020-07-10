/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AnimatorSetter : ManagedBehaviour // TypeDefIndex: 11438
{
	// Fields
	public EActions actionId; // 0x50
	public ERotationOverrides rotationOverride; // 0x54
	public bool disableStickToGround; // 0x58
	private Animator _animator; // 0x60

	// Nested types
	public enum EActions // TypeDefIndex: 11439
	{
		None = -1,
		IdleBreak02 = 2,
		IdleBreak03 = 3,
		Jump = 10,
		Falling = 11,
		Dig = 20,
		Dive = 30,
		Sleep = 40,
		Tired = 41,
		Dizzy = 50,
		Sit = 60,
		Sit02 = 61,
		Sit03 = 62,
		Angry = 70,
		Excited = 80,
		Surprised = 90,
		Talk = 100,
		Agree = 110,
		Disagree = 120,
		GetAttention = 130,
		SendAway = 140,
		Laugh = 150,
		Dance = 160,
		Eat = 170,
		Sad = 180,
		Scared = 190,
		Strut = 200,
		Play = 210
	}

	public enum ERotationOverrides // TypeDefIndex: 11440
	{
		None = 0,
		Disable = 1,
		HeadOnly = 2
	}

	// Constructors
	public AnimatorSetter(); // 0x000000018103CBC0-0x000000018103CC20

	// Methods
	public void Init(); // 0x000000018103CA20-0x000000018103CBC0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Beetle : MonoBehaviour // TypeDefIndex: 12858
{
	// Fields
	public Transform holder; // 0x20
	public Animator beetleAnimator; // 0x28
	public Collider touchCollision; // 0x30
	public Collider beetleBodyCollision; // 0x38
	public Renderer beetleRenderer; // 0x40
	public float pushScale; // 0x48
	public bool canDiscard; // 0x4C
	private Rigidbody _rigidbody; // 0x50
	private CodeBreakerIngredient _ingredient; // 0x58
	private Vector3 _startingPosition; // 0x60
	private BeetleState _state; // 0x6C
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <CodeIndex>k__BackingField; // 0x70

	// Properties
	public int CodeIndex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAD00-0x00000001803DAD10 0x00000001803DAEA0-0x00000001803DAEB0
	public bool IsEmpty { get; } // 0x0000000181044C10-0x0000000181044C20 
	public CodeColor Color { get; } // 0x0000000181044B80-0x0000000181044C10 

	// Nested types
	private enum BeetleState // TypeDefIndex: 12859
	{
		Empty = 0,
		Catching = 1,
		Holding = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12860
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__25_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018104F750-0x000000018104FBD0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ReturnBeetleToSpawnPosition>b__25_0(); // 0x000000018104D6A0-0x000000018104D6B0
	}

	// Constructors
	public Beetle(); // 0x0000000181044B60-0x0000000181044B80

	// Methods
	private void Start(); // 0x0000000181044670-0x00000001810447A0
	private void Update(); // 0x0000000181044830-0x0000000181044B60
	private bool CheckIfClicked(); // 0x0000000181043DC0-0x0000000181043F20
	public void CatchIngredient(CodeBreakerIngredient inIngredient, Vector3 inCatchPos); // 0x0000000181043D80-0x0000000181043DC0
	public void MoveTo(Vector3 inPosition, bool snap = false /* Metadata: 0x007832B6 */); // 0x00000001810442A0-0x0000000181044450
	public void ReturnBeetleToSpawnPosition(float delay = 0f /* Metadata: 0x007832B7 */); // 0x0000000181044450-0x00000001810445B0
	public void HoldIngredient(CodeBreakerIngredient inIngredient); // 0x0000000180485C70-0x0000000180485C80
	public void DropIngredient(Vector3 dropDir, bool enableCollider = false /* Metadata: 0x007832BB */); // 0x0000000181044060-0x00000001810442A0
	public void DiscardIngredient(); // 0x0000000181043F20-0x0000000181044060
	public void SetMaterial(Material inMaterial); // 0x00000001810445B0-0x0000000181044670
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MoveTo>b__24_0(); // 0x00000001810447A0-0x0000000181044830
}


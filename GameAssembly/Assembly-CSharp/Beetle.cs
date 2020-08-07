/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Beetle : MonoBehaviour // TypeDefIndex: 10516
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <CodeIndex>k__BackingField; // 0x70

	// Properties
	public int CodeIndex { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804B4700-0x00000001804B4710 0x00000001804B47E0-0x00000001804B47F0
	public bool IsEmpty { get; } // 0x000000018212B9D0-0x000000018212B9E0 
	public CodeColor Color { get; } // 0x000000018212B940-0x000000018212B9D0 

	// Nested types
	private enum BeetleState // TypeDefIndex: 10517
	{
		Empty = 0,
		Catching = 1,
		Holding = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10518
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static TweenCallback <>9__25_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018214C520-0x000000018214C580
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ReturnBeetleToSpawnPosition>b__25_0(); // 0x000000018214C290-0x000000018214C2A0
	}

	// Constructors
	public Beetle(); // 0x000000018212B920-0x000000018212B940

	// Methods
	private void Start(); // 0x000000018212B440-0x000000018212B570
	private void Update(); // 0x000000018212B5F0-0x000000018212B920
	private bool CheckIfClicked(); // 0x000000018212ABA0-0x000000018212AD00
	public void CatchIngredient(CodeBreakerIngredient inIngredient, Vector3 inCatchPos); // 0x000000018212AB60-0x000000018212ABA0
	public void MoveTo(Vector3 inPosition, bool snap = false /* Metadata: 0x0077BD61 */); // 0x000000018212B080-0x000000018212B220
	public void ReturnBeetleToSpawnPosition(float delay = 0f /* Metadata: 0x0077BD62 */); // 0x000000018212B220-0x000000018212B380
	public void HoldIngredient(CodeBreakerIngredient inIngredient); // 0x00000001803A1740-0x00000001803A1750
	public void DropIngredient(Vector3 dropDir, bool enableCollider = false /* Metadata: 0x0077BD66 */); // 0x000000018212AE40-0x000000018212B080
	public void DiscardIngredient(); // 0x000000018212AD00-0x000000018212AE40
	public void SetMaterial(Material inMaterial); // 0x000000018212B380-0x000000018212B440
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MoveTo>b__24_0(); // 0x000000018212B570-0x000000018212B5F0
}


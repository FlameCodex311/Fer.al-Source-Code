/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class UI_Stage : MonoBehaviour // TypeDefIndex: 12640
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _doNotDestroyRoot; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected PlayerCameraMode _cameraMode; // 0x28
	protected PlayerCameraMode _previousPlayerCameraMode; // 0x2C
	protected Scene _scene; // 0x30

	// Properties
	public abstract Transform SpinTarget { get; }
	public abstract StageCameraSetting ActiveCameraSetting { get; }

	// Nested types
	[Serializable]
	public class StageCameraSetting // TypeDefIndex: 12641
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CinemachineVirtualCamera _virtualCamera; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _minFOV; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _maxFOV; // 0x1C
		private CinemachineComposer _composer; // 0x20

		// Properties
		public CinemachineVirtualCamera VirtualCamera { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CinemachineComposer Composer { get; } // 0x0000000180EDFB50-0x0000000180EE0630 

		// Constructors
		public StageCameraSetting(); // 0x0000000180EDFB30-0x0000000180EDFB50

		// Methods
		public void UpdatZoomLevel(float inNormalizedZoom); // 0x0000000180EDFA80-0x0000000180EDFB30
	}

	// Constructors
	protected UI_Stage(); // 0x0000000180EFB4F0-0x0000000180EFB500

	// Methods
	public virtual void RemoveScene(); // 0x0000000180EFB080-0x0000000180EFB130
	private void Awake(); // 0x0000000180EFAEB0-0x0000000180EFAF60
	protected virtual void Start(); // 0x0000000180EFB130-0x0000000180EFB390
	protected virtual void OnDestroy(); // 0x0000000180EFAF60-0x0000000180EFB080
	protected virtual void Update(); // 0x0000000180EFB390-0x0000000180EFB4F0
}


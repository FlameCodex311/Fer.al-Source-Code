/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class UI_Stage : MonoBehaviour // TypeDefIndex: 13829
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _doNotDestroyRoot; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected PlayerCameraMode _cameraMode; // 0x28
	protected PlayerCameraMode _previousPlayerCameraMode; // 0x2C
	protected Scene _scene; // 0x30

	// Properties
	public abstract Transform SpinTarget { get; }
	public abstract StageCameraSetting ActiveCameraSetting { get; }

	// Nested types
	[Serializable]
	public class StageCameraSetting // TypeDefIndex: 13830
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CinemachineVirtualCamera _virtualCamera; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _minFOV; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _maxFOV; // 0x1C
		private CinemachineComposer _composer; // 0x20

		// Properties
		public CinemachineVirtualCamera VirtualCamera { get; } // 0x0000000180372440-0x0000000180372450 
		public CinemachineComposer Composer { get; } // 0x00000001804BEC50-0x00000001804C29E0 

		// Constructors
		public StageCameraSetting(); // 0x00000001804BEC30-0x00000001804BEC50

		// Methods
		public void UpdatZoomLevel(float inNormalizedZoom); // 0x00000001804BEB80-0x00000001804BEC30
	}

	// Constructors
	protected UI_Stage(); // 0x00000001804D0D40-0x00000001804D0D50

	// Methods
	public virtual void RemoveScene(); // 0x00000001804D1DB0-0x00000001804D1E60
	private void Awake(); // 0x00000001804D0E50-0x00000001804D0F00
	protected virtual void Start(); // 0x00000001804D1EF0-0x00000001804D2140
	protected virtual void OnDestroy(); // 0x00000001804D1C90-0x00000001804D1DB0
	protected virtual void Update(); // 0x00000001804D2310-0x00000001804D2470
}


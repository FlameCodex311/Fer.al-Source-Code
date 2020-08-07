/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Common
{
	public abstract class KeepAliveBehaviour<T> : UnityEngine.MonoBehaviour // TypeDefIndex: 7401
		where T : KeepAliveBehaviour<T>
	{
		// Fields
		[Tooltip] // 0x0000000180256B50-0x0000000180256B80
		public bool keepAlive;
		protected int instancesInScene;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static T <Instance>k__BackingField;
	
		// Properties
		public static T Instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; }
		protected static T GetOrCreateInstance { get; }
	
		// Constructors
		protected KeepAliveBehaviour();
	
		// Methods
		protected virtual void Awake();
		protected virtual void Start();
		protected virtual void OnDestroy();
		protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode);
		protected virtual bool Init(T instance, string detectorName);
		protected virtual void DisposeInternal();
		protected abstract string GetComponentName();
	}
}

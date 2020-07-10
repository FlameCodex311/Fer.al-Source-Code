/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	[AddComponentMenu] // 0x00000001800F2460-0x00000001800F2490
	public class StudioBankLoader : UnityEngine.MonoBehaviour // TypeDefIndex: 9856
	{
		// Fields
		public LoaderGameEvent LoadEvent; // 0x18
		public LoaderGameEvent UnloadEvent; // 0x1C
		[BankRef] // 0x00000001800BDB50-0x00000001800BDB60
		public List<string> Banks; // 0x20
		public string CollisionTag; // 0x28
		public bool PreloadSamples; // 0x30
		private bool isQuitting; // 0x31
	
		// Constructors
		public StudioBankLoader(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void HandleGameEvent(LoaderGameEvent gameEvent); // 0x0000000181658840-0x0000000181658880
		private void Start(); // 0x0000000181658C50-0x0000000181658C90
		private void OnApplicationQuit(); // 0x0000000181658A40-0x0000000181658A50
		private void OnDestroy(); // 0x0000000181658A50-0x0000000181658A90
		private void OnTriggerEnter(Collider other); // 0x0000000181658B00-0x0000000181658B70
		private void OnTriggerExit(Collider other); // 0x0000000181658BE0-0x0000000181658C50
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000181658A90-0x0000000181658B00
		private void OnTriggerExit2D(Collider2D other); // 0x0000000181658B70-0x0000000181658BE0
		public void Load(); // 0x0000000181658880-0x0000000181658A40
		public void Unload(); // 0x0000000181658C90-0x0000000181658DD0
	}
}

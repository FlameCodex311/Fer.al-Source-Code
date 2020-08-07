/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	[Serializable]
	public class GaiaSession : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 9223
	{
		// Fields
		[TextArea] // 0x0000000180240590-0x00000001802405B0
		public string m_name; // 0x18
		[TextArea] // 0x0000000180240750-0x0000000180240770
		public string m_description; // 0x20
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Texture2D m_previewImage; // 0x28
		public string m_dateCreated; // 0x30
		public int m_terrainWidth; // 0x38
		public int m_terrainDepth; // 0x3C
		public int m_terrainHeight; // 0x40
		public float m_seaLevel; // 0x44
		public bool m_isLocked; // 0x48
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ScriptableObjectWrapper m_defaults; // 0x50
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Dictionary<string, ScriptableObjectWrapper> m_resources; // 0x58
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> m_resourcesKeys; // 0x60
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<ScriptableObjectWrapper> m_resourcesValues; // 0x68
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public byte[] m_previewImageBytes; // 0x70
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int m_previewImageWidth; // 0x78
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public int m_previewImageHeight; // 0x7C
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<GaiaOperation> m_operations; // 0x80
	
		// Constructors
		public GaiaSession(); // 0x0000000180E4DF40-0x0000000180E4E0A0
	
		// Methods
		public void OnBeforeSerialize(); // 0x0000000180E4DD90-0x0000000180E4DF40
		public void OnAfterDeserialize(); // 0x0000000180E4DC30-0x0000000180E4DD90
		public string GetSessionFileName(); // 0x0000000180E4DC20-0x0000000180E4DC30
		public Texture2D GetPreviewImage(); // 0x0000000180E4DB30-0x0000000180E4DC20
	}
}

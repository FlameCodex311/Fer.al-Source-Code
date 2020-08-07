/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	[fsDeserializeOverwrite] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class GraphSource : ISerializationCollector // TypeDefIndex: 15760
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<Task> <allTasks>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<BBParameter> <allParameters>k__BackingField; // 0x18
		public const float FRAMEWORK_VERSION = 3.09f; // Metadata: 0x007BB4CF
		[fsIgnoreInBuild] // 0x000000018022D170-0x000000018022D1E0
		[fsSerializeAs] // 0x000000018022D170-0x000000018022D1E0
		[fsWriteOnly] // 0x000000018022D170-0x000000018022D1E0
		[SerializeField] // 0x000000018022D170-0x000000018022D1E0
		private float _version; // 0x20
		[fsIgnoreInBuild] // 0x000000018022D420-0x000000018022D490
		[fsSerializeAs] // 0x000000018022D420-0x000000018022D490
		[fsWriteOnly] // 0x000000018022D420-0x000000018022D490
		[SerializeField] // 0x000000018022D420-0x000000018022D490
		private string _category; // 0x28
		[fsIgnoreInBuild] // 0x000000018022D800-0x000000018022D870
		[fsSerializeAs] // 0x000000018022D800-0x000000018022D870
		[fsWriteOnly] // 0x000000018022D800-0x000000018022D870
		[SerializeField] // 0x000000018022D800-0x000000018022D870
		private string _comments; // 0x30
		[fsIgnoreInBuild] // 0x000000018022DC20-0x000000018022DC90
		[fsSerializeAs] // 0x000000018022DC20-0x000000018022DC90
		[fsWriteOnly] // 0x000000018022DC20-0x000000018022DC90
		[SerializeField] // 0x000000018022DC20-0x000000018022DC90
		private Vector2 _translation; // 0x38
		[fsIgnoreInBuild] // 0x000000018022E080-0x000000018022E0F0
		[fsSerializeAs] // 0x000000018022E080-0x000000018022E0F0
		[fsWriteOnly] // 0x000000018022E080-0x000000018022E0F0
		[SerializeField] // 0x000000018022E080-0x000000018022E0F0
		private float _zoomFactor; // 0x40
		[fsSerializeAs] // 0x00000001801D3F40-0x00000001801D3F70
		private string _type; // 0x48
		[fsSerializeAs] // 0x000000018022E680-0x000000018022E6B0
		private List<Node> _nodes; // 0x50
		[fsSerializeAs] // 0x000000018022E820-0x000000018022E850
		private List<Connection> _connections; // 0x58
		[fsIgnoreInBuild] // 0x000000018022EA30-0x000000018022EA80
		[fsSerializeAs] // 0x000000018022EA30-0x000000018022EA80
		private List<NodeCanvas.Framework.CanvasGroup> _canvasGroups; // 0x60
		[fsSerializeAs] // 0x000000018022EE40-0x000000018022EE70
		private BlackboardSource _localBlackboard; // 0x68
		[fsSerializeAs] // 0x000000018022EFC0-0x000000018022EFF0
		private object _derivedData; // 0x70
	
		// Properties
		public List<Task> allTasks { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public List<BBParameter> allParameters { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public float version { get; set; } // 0x0000000180373AF0-0x0000000180373B00 0x0000000180373B00-0x0000000180373B10
		public string category { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public string comments { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public Vector2 translation { get; set; } // 0x0000000180CC8860-0x0000000180CC8880 0x00000001803FEB60-0x00000001803FEB70
		public float zoomFactor { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x0000000180CC8880-0x0000000180CC8890
		public string type { get; set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		public List<Node> nodes { get; set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public List<Connection> connections { get; private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups { get; set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public BlackboardSource localBlackboard { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
		public object derivedData { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
	
		// Constructors
		public GraphSource(); // 0x0000000180CC86F0-0x0000000180CC8860
	
		// Methods
		void ISerializationCollector.OnPush(ISerializationCollector parent); // 0x0000000180CC8260-0x0000000180CC82E0
		void ISerializationCollector.OnCollect(ISerializationCollectable child, int depth); // 0x0000000180CC80C0-0x0000000180CC8260
		void ISerializationCollector.OnPop(ISerializationCollector parent); // 0x00000001803774A0-0x00000001803774B0
		public GraphSource Pack(Graph graph); // 0x0000000180CC7EF0-0x0000000180CC80C0
		public GraphSource Unpack(Graph graph); // 0x0000000180CC8380-0x0000000180CC86F0
		public GraphSource SetMetaData(GraphSource source); // 0x0000000180CC8330-0x0000000180CC8380
		public void PurgeRedundantReferences(); // 0x0000000180CC82E0-0x0000000180CC8330
	}
}

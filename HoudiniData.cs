using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoudiniData : ScriptableObject
{
	[System.Serializable]
	public class Entry
	{
		public int nodeType;
		public Quaternion orient;
		public Vector3 P;
		public Vector3 scale;
	}

	public Entry[] _entries;
}

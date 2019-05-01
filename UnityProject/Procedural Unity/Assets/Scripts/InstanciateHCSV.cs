using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class InstanciateHCSV : MonoBehaviour {
	public HoudiniData HCVS; 
	public bool run = false;
	public GameObject parent;

	public List<GameObject> parts = new List<GameObject>();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (run) { 
			CleanUP ();
			InstancianteNow();
			run = false; 
		}
		
	}
	void CleanUP() {
		if (parent) {
			DestroyImmediate (parent);
		}
	}
	void InstancianteNow() {
		if (!parent) {
			parent = new GameObject ("RootParent");
		}
		for (int i = 0; i < HCVS._entries.Length; i++) {
			//Debug.Log (HCVS._entries [i].nodeType);
			GameObject go = Instantiate (parts[HCVS._entries [i].nodeType]);
			go.transform.SetParent(parent.transform);
			go.transform.position = HCVS._entries [i].P;
			go.transform.rotation = HCVS._entries [i].orient;
			go.transform.localScale = HCVS._entries [i].scale;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour {
	private Rect out_Rect;
	private Rect in_Rect;
	private Rect addBlood;
	private Rect subBlood;
	private int bloodValue=0;
	//private float resultValue;
	// Use this for initialization
	void Start () {
		//GUI.Button(new Rect (20, 20, 200, 20),"");
		addBlood = new Rect (20, 50, 40, 20);
		subBlood = new Rect (70, 50, 40, 20);
		//resultValue = bloodValue;
 	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Button(new Rect (20, 20, 200, 20),"");
		if (GUI.Button(addBlood,"加血")) {
			bloodValue += 20;
			in_Rect=new Rect(21,21,bloodValue,20);
		}
		if (GUI.Button(subBlood,"减血")) {
			bloodValue -= 20;
		}
		if (bloodValue <= 0) {
			bloodValue = 0;
		}
		if (bloodValue >= 200) {
			bloodValue = 200;
		}
		GUI.color = Color.red;
		GUI.Button (new Rect (21, 21, bloodValue, 20), "");
	}
}

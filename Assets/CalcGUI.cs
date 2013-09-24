using UnityEngine;
using System.Collections.Generic;
using System;



public class CalcGUI : MonoBehaviour {
	
	public CalcGUI() {
		
	}
	
	int n1,n2;
	
	// Use this for initialization
	void Start () {
		System.Random rnd = new System.Random();
		n1 = rnd.Next (0, 50);
		n2 = rnd.Next (0, 50);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	
	string svarTekst = "";
	string replyTekst = "";
	void OnGUI() {
		
		GUI.Label(new Rect(10, 10, 100, 20), "Velkommen til crappy-lommeregner 2.0!");
		GUI.Label(new Rect(10, 30, 100, 20), String.Format("Hvad er {0} + {1}?", n1, n2));
		svarTekst = GUI.TextField(new Rect(10, 50, 100, 20), svarTekst);
		if (GUI.Button(new Rect(10, 70, 100, 20), "Svar")) {
			int svar = Convert.ToInt32(svarTekst);
			if (svar == n1 + n2)
				replyTekst = "Korrekt!";
			else 
				replyTekst = "Prøv igen!";
		}
		GUI.Label(new Rect(10, 90, 100, 20), replyTekst);
		
	}
}

using UnityEngine;
using System.Collections;

public class EuchreManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Deck deck = new Deck();
        deck.DebugDeck();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

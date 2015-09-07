﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Board : MonoBehaviour
{

	public List<Gem>gems = new List<Gem> ();
	public int GridWidth;
	public int GridHeight;
	public GameObject gemPrefab;
	// Use this for initialization
	void Start ()
	{
		for (int y=0; y<GridHeight; y++) {
			for (int x=0; x<GridWidth; x++) {
				GameObject g = Instantiate (gemPrefab, new Vector3 (x, y, 0), Quaternion.identity)as GameObject;
				g.transform.parent = gameObject.transform;
				gems.Add (g.GetComponent<Gem> ());

			}
		}
	
		gameObject.transform.position = new Vector3 (-2.7f, -1.94f, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

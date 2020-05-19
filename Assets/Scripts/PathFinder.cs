﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
	/** Game State */
	Dictionary<Vector2Int, Waypoint> WorldGrid = new Dictionary<Vector2Int, Waypoint>();
	[SerializeField]	Waypoint StartBlock, EndBlock;

	// Start is called before the first frame update
	void Start()
	{
		LoadBlocks();
		StartBlock.SetTopColor(Color.yellow);
		EndBlock.SetTopColor(Color.red);
	}

	void	LoadBlocks()
	{
		var Waypoints = FindObjectsOfType<Waypoint>();
		foreach (Waypoint Waypoint in Waypoints)
		{
			/** if there are duplicates */
			if (WorldGrid.ContainsKey(Waypoint.GetGridPos()))
			{
				Debug.LogWarning("Overlapping grid: " + Waypoint.GetGridPos());
			}
			else
			{
				WorldGrid.Add(Waypoint.GetGridPos(), Waypoint);
			}
		}
		print("Loaded " + WorldGrid.Count + " blocks.");
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}

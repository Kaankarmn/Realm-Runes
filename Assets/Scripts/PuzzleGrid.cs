// PuzzleGrid.cs

using UnityEngine;
using System.Collections.Generic;

public class PuzzleGrid : MonoBehaviour
{
    public int width = 5;  // Width of the grid
    public int height = 5; // Height of the grid

    private List<List<int>> grid; // 2D grid to hold puzzle data

    void Start()
    {
        InitializeGrid();
    }

    void InitializeGrid()
    {
        grid = new List<List<int>>();

        for (int i = 0; i < height; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j < width; j++)
            {
                row.Add(0); // Initialize grid cells with 0
            }
            grid.Add(row);
        }
    }

    // Add more puzzle mechanics methods below
}
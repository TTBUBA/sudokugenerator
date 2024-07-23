using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private byte[,] SudokuGrid = new byte[9, 9];
    

    // Update is called once per frame
    void Update()
    {
        GenerateSudoku();
        grid();
    }

    public void GenerateSudoku()
    {
        for (int row = 0; row < 9; row++)
        {
            for(int col = 0; col < 9; col++)
            {
                SudokuGrid[row, col] = 0;
            }
        }
    }

    public void grid()
    {
        for( int row = 0;row < 9; row++)
        {
            string line = "";
            for (int col = 0;col < 9; col++)
            {
                line += SudokuGrid[row, col] + "";
            }

            Debug.Log(line);
        }
    }
}

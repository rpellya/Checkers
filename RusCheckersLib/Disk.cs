﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RusCheckersLib
{
    public enum DiskColor
    {
        Black,
        White
    }

    public abstract class Disk
    {
        public Disk()
        {

        }
        
        public Disk(DiskColor color, Point point)
        {
            Color = color;
            Point = point;
        }
        
        public DiskColor Color { get; set; }
        
        public Point Point { get; set; }
        
        public bool CanCapture { get; set; }
        
        public List<Point> AvailebleMoves = new List<Point>();

        public abstract List<Point> GetAvailableMoves(Board board);
        
        public bool CheckPointInBoard(int x, int y)
        {
            if (x < 8 && x >= 0 && y < 8 && y >= 0)
            {
                return true;
            }
            return false;
        }
        
        public bool MayCapture(Board board)
        {
            bool canCapture = false;
            for (int i = 0;i < 8;i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(board[i, j].Disk != null &&
                       board[i, j].Disk.Color == Color)
                    {
                        board[i, j].Disk.GetAvailableMoves(board);
                        if(board[i, j].Disk.CanCapture == true)
                        {
                            canCapture = true;
                        }
                    }
                }
            }
            return canCapture;
        }

        public override string ToString()
        {
            return Color + ", " + Point; 
        }
    }
}

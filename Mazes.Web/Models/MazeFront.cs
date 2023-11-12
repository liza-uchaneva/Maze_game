﻿namespace Mazes.Web.Models
{
    public class MazeFront
    {
        public string Id { get; set; }
        public Cell[][] Board { get; set; }

        public MazeFront(string id, Cell[][] board)
        {
            Id = id;
            Board = board;
        }
    }
}

﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Mazes.Web.Models
{
    public class Maze
    {
        public string Id { get; set; } = null!;
        public int Size { get; set; }
        [NotMapped]
        public Cell[] Board
        { 
            get 
            { 
                return DeserializeBoard(BoardData); 
            } 
            set
            {
                BoardData = SerializeBoard(value);
            } 
        }
        public string BoardData { get; set; } = null!;

        private string SerializeBoard(Cell[] board)
        {
            return JsonSerializer.Serialize(board);
        }

        private Cell[] DeserializeBoard(string boardData)
        {
            return JsonSerializer.Deserialize<Cell[]>(boardData);
        }
    }
}

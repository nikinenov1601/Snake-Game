using System;

namespace Snake
{
    public class Direction
    {
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);
        public Direction(int rowOffset, int columnOffset)
        {
            RowOffset = rowOffset;
            ColumnOffset = columnOffset;
        }

        public int RowOffset { get; }
        public int ColumnOffset { get; }

        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   RowOffset == direction.RowOffset &&
                   ColumnOffset == direction.ColumnOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColumnOffset);
        }

        public Direction Opposite()
        {
            return new Direction(-RowOffset, -ColumnOffset);
        }
    }
}

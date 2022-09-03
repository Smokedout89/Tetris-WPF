namespace Tetris;

using System;

public class BlockQueue
{
    private readonly Random random = new Random();

    private readonly Block[] blocks = new Block[]
    {
        new IBlock(),
        new JBlock(),
        new LBlock(),
        new OBlock(),
        new SBlock(),
        new TBlock(),
        new ZBlock()
    };

    public BlockQueue()
    {
        NextBlock = RandomBlock();
    }

    public Block NextBlock { get; private set; }

    private Block RandomBlock()
    {
        return blocks[random.Next(blocks.Length)];
    }

    public Block GetAndUpdate()
    {
        Block block = NextBlock;

        do
        {
            NextBlock = RandomBlock();
        } while (block.Id == NextBlock.Id);

        return block;
    }
}
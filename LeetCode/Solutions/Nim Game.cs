public partial class Solution
{
    public bool CanWinNim(int n)
    {
        // if there are less than or equal to three stones, i can pick them all at once.
        if(n < 3) return true;

        bool isMyTurn = false;
        while (n > 0)
        {
            isMyTurn = !isMyTurn;
            if (isMyTurn)
            {
                // means my turn
                if (!WillRemain(n))
                {
                    // if i can pick all the stones, then return true
                    return true;
                }
                else
                {

                }
            }
            else
            {
                // my friend's turn
                n -= 3;
            }
        }

        return isMyTurn;
    }

    private bool WillRemain(int num)
    {
        return num - 3 > 0;
    }
}
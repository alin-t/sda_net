namespace SDA
{
    interface IStack
    {
        void Push(int elem);
        int Pop();
        int Peek();
        bool IsEmpty();
    }
}

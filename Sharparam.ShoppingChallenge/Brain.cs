using System.Collections.Generic;
using Sharparam.ShoppingChallenge.Commands;

namespace Sharparam.ShoppingChallenge
{
    public class Brain
    {
        private readonly Queue<ICommand> _commandQueue;

        public Brain()
        {
            _commandQueue = new Queue<ICommand>();
        }

        public void Store(ICommand command)
        {
            _commandQueue.Enqueue(command);
        }

        public void Work()
        {
            _commandQueue.Dequeue().Execute();
        }

        public void Process(ICommand command)
        {
            Store(command);
            Work();
        }
    }
}

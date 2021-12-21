using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MessageBox
    {
        public event Action<State> OnClosed;

        public async void Open()
        {
            Console.WriteLine("Window has been opened");
            await Task.Delay(3000);
            Console.WriteLine("Window was closed by User");

            this.OnClosed?.Invoke((State)new Random().Next(2));
        }
    }
}
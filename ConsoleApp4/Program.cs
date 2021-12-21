using System;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var messageBox = new MessageBox();
            var tcs = new TaskCompletionSource();

            messageBox.OnClosed += (state) =>
            {
                var msg = state != State.Ok ? "Операция была отклонена" : "Операция была подтверждена";
                Console.WriteLine(msg);
                tcs.SetResult();
            };
            messageBox.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
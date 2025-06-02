using System;
using System.Threading;
public class Program {
    private static readonly object atm = new object();
    public static void Main(String[] args) {
        Thread t1 = new Thread(fives);
        Thread t2 = new Thread(sixes);
        t1.Start();
        t2.Start();
    }
    static void fives() {
        lock (atm) {
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("Person 1 is using ATM...");
            }
        }
    }
    static void sixes() {
        lock (atm) {
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("Person 2 is using ATM...");
            }
        }
    }
}

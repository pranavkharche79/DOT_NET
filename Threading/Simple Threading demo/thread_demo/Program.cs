using System;
using System.Threading;
using System.Threading.Tasks;
using help;

Thread theTread=Thread.CurrentThread;

Console.WriteLine("Main fn Thread =" + theTread.ManagedThreadId);

Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
Helper.StoreData();
Helper.GetRemoteData();
Console.WriteLine("In the main");
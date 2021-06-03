using StackExchange.Redis;
using System;
using System.Threading;

namespace StackExchangeRedisDemo
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            

            RedisTest();
        }
        public static void RedisTest()
        {
            Console.WriteLine("Redis写入缓存：Name:张三丰");
            StackExchangeRedisHelper.Set("Name", "张三丰", new TimeSpan(0, 0, 0, 0, 1000));
            Console.WriteLine("Redis获取缓存：Name：" + StackExchangeRedisHelper.Get("Name").ToString());
            Thread.Sleep(1000);
            Console.WriteLine("一秒后Redis获取缓存：Name：" + StackExchangeRedisHelper.Get("Name") ?? "");
            Console.ReadKey();
        }
    }

}

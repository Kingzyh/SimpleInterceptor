using System;

namespace SimpleInterceptor {

    public class Person {

        public virtual void SayHello() {
            Console.WriteLine("您好！");
        }

        public virtual void SayName(string hometown) {
            Console.WriteLine($"我是天涯人，我来自：{hometown}");
        }

        public void SayOther() {
            Console.WriteLine("我是中国人。");
        }
    }
}
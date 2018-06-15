using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInterceptor {

    class Program {
        static void Main(string[] args) {
            ProxyGenerator generator = new ProxyGenerator();
            PersonInterceptor interceptor = new PersonInterceptor();

            //使用【代理类生成器】创建Person对象，而不是使用new关键字来实例化  
            Person person = generator.CreateClassProxy<Person>(interceptor);

            Console.WriteLine("当前类型:{0},父类型:{1}", person.GetType(), person.GetType().BaseType);
            Console.WriteLine();

            person.SayHello();//跟普通调用没有两样吧？  
            Console.WriteLine();

            person.SayName("福建");//跟普通调用没有两样吧？  
            Console.WriteLine();

            person.SayOther();//它不是虚方法，无法拦截。待会检测输出情况就知道了。     
            Console.ReadLine();

            Console.WriteLine();
        }
    }
}

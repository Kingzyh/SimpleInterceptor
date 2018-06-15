using Castle.Core.Interceptor;
using System;

namespace PersonInterceptor {
    internal class PersonInterceptor : StandardInterceptor {

        protected override void PreProceed(IInvocation invocation) {
            Console.WriteLine($"调用前的拦截器，方法名是：{invocation.Method.Name}");
            base.PreProceed(invocation);
        }

        protected override void PerformProceed(IInvocation invocation) {
            Console.WriteLine($"拦截的方法返回时调用的拦截器，方法名是：{invocation.Method.Name}");
            base.PerformProceed(invocation);
        }

        protected override void PostProceed(IInvocation invocation) {
            Console.WriteLine($"调用后的拦截器，方法名是：{invocation.Method.Name}");
            base.PostProceed(invocation);
        }
    }
}
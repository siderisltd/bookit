﻿namespace BookIt.Server.Common
{
    using Ninject;

    public static class ObjectFactory
    {
        private static IKernel savedKernel;

        public static void Innitialize(IKernel kernel)
        {
            savedKernel = kernel;
        }

        public static T Get<T>()
        {
            return savedKernel.Get<T>();
        }
    }
}

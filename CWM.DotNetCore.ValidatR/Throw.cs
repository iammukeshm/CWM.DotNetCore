using System;

namespace CWM.DotNetCore.ValidatR
{
    public interface IThrow
    {

    }
    public class Throw : IThrow
    {
        public static IThrow Exception { get; } = new Throw();
        private Throw() { }
    }
}

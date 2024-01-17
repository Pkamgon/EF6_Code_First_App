using System;

namespace EF6_Code_First_App
{
    internal class SchoolContext : IDisposable
    {
        public object Students { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
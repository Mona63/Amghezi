using System;
using System.Collections.Generic;
using System.Text;
using Scout24.Core.Models;

namespace XUnitTestProject1
{
   public interface IScout24DbInitializer
    {
        void Initialize(Scout24Context db);
    }
}

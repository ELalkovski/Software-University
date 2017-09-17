using System.Collections.Generic;

namespace _08.Military_Elite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IList<IPrivate> Privates { get; }
    }
}
